using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Common.Metadata;
using Xbim.Common.Model;
using Xbim.Common.Step21;
using Xbim.IO.Step21;

namespace Xbim.ISO_12006_3_V4.Samples
{
    public class ModelHelper : IDisposable
    {
        public IModel Model { get; }
        private Dictionary<int, string> _comments = new Dictionary<int, string>();
        private ITransaction _txn;

        public ModelHelper(string version = "2.1", string date = null)
        {
            Model = new StepModel(new EntityFactoryIso120063Version4());
            _txn = Model.BeginTransaction("Model creation");

            version = version ?? "1.2";
            date = date ?? DateTime.Now.ToString("s");

            // set globally unique ID where necessary
            Model.EntityNew += (IPersistEntity entity) => {
                var idProps = entity.ExpressType
                    .Properties.Values
                    .Where(p => p.PropertyInfo.PropertyType == typeof(xtdGlobalUniqueID));
                foreach (var idProp in idProps)
                {
                    xtdGlobalUniqueID id = Guid.NewGuid();
                    idProp.PropertyInfo.SetValue(entity, id);
                }

                if (entity is xtdRoot root) {
                    root.VersionDate = date;
                    root.VersionID = version;
                }
            };
        }

        public void Comment(IPersistEntity entity, string comment)
        {
            if (_comments.TryGetValue(entity.EntityLabel, out string msg))
                _comments[entity.EntityLabel] = msg + "\r\n" + comment;
            else
                _comments.Add(entity.EntityLabel, comment);
        }

        public void Save(string file)
        {
            _txn.Commit();
            _txn = Model.BeginTransaction("Creation");

            if (!file.EndsWith(".stp", StringComparison.InvariantCultureIgnoreCase))
                file = file + ".stp";
            if (!Path.IsPathRooted(file))
                file = Path.Combine(@"..\..\..\..\Samples", file);
            using (var output = File.CreateText(file))
            {
                Write(Model, output);
                output.Close();
            }
        }

        /// <summary>
        /// Writes full model into output writer as STEP21 file
        /// </summary>
        /// <param name="model">Model to be serialized</param>
        /// <param name="output">Output writer</param>
        /// <param name="metadata">Metadata to be used for serialization</param>
        /// <param name="map">Optional map can be used to map occurrences in the file</param>
        private void Write(IModel model, TextWriter output)
        {
            ExpressMetaData metadata = model.Metadata;
            var header = model.Header ?? new StepFileHeader(StepFileHeader.HeaderCreationMode.InitWithXbimDefaults, model);
            string fallBackSchema = null;

            if (header.FileSchema == null || !header.FileSchema.Schemas.Any())
            {
                var instance = model.Instances.FirstOrDefault();
                if (instance != null)
                {
                    var eft = instance.GetType().GetTypeInfo().Assembly.GetTypes().Where(t => typeof(IEntityFactory).GetTypeInfo().IsAssignableFrom(t)).FirstOrDefault();
                    if (eft == null)
                        throw new XbimException("It wasn't possible to find valid schema definition");
                    if (!(Activator.CreateInstance(eft) is IEntityFactory ef))
                        throw new XbimException("It wasn't possible to find valid schema definition");
                    fallBackSchema = string.Join(",", ef.SchemasIds);
                }
            }

            Part21Writer.WriteHeader(header, output, fallBackSchema);

            foreach (var entity in model.Instances)
            {
                if (_comments.TryGetValue(entity.EntityLabel, out string comment))
                {
                    comment = comment.Trim('\r', '\n');
                    comment = comment.Replace("\r\n", "\r\n* ");
                    output.WriteLine();
                    output.WriteLine($"/**");
                    output.WriteLine("* " + comment);
                    output.WriteLine($"* {GetMetaComment(entity)}*/");
                }
                Part21Writer.WriteEntity(entity, output, metadata, null);
                output.WriteLine();
            }
            Part21Writer.WriteFooter(output);
        }

        private string GetMetaComment(IPersistEntity e)
        {
            var tName = e.ExpressType.ExpressNameUpper;
            var props = e.ExpressType.Properties.Select(kv => kv.Value.Name);
            return $"{tName}=({string.Join(", ", props)})";
        }

        public void Dispose()
        {
            _txn.Dispose();
            Model.Dispose();
        }

        public T New<T>(Action<T> init = null) where T : IInstantiableEntity
        {
            var e = Model.Instances.New<T>();
            init?.Invoke(e);
            return e;
        }
    }
}
