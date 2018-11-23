# Support for reliable data exchange in ISO 12006-3 (IFD)
## Value types, machine readable units and external schema representations

This is implementation of the current and development version of ISO 12006-3 (version 3) and suggestions of some of the changes for the version 4. These changes focuse on interoperability between IFC and IFD in the area of units and reliably encoded values.

There is also a samples project where sample data can be created using both schemas. 

`generator.exe`can be used to update the schema implementation when EXPRESS definitions are changed in the `.exp` file.


# Introduction
Based on the suggested topics outlined in document ISO-TC59-SC13-WG6_N0233 and our own investigation of the ISO 12006-3 standard we have focused our effort towards improved definitions of values to provide reliable data exchange definitions which can be used to inform data and data templates in IFC and external automated systems in general. Current implementation is focused on the human communication which is sufficient for the tasks where common agreement on the concept is a key. But it lacks reliable machine readable definitions of units and reliable numeric and logical values encoding which makes it hard or impossible to use those agreed multilingual concepts to inform external automated systems or IFC data or data templates. 

# Units
IFC (ISO 16739) already contains data schema which describes units in reliable way and it also uses EXPRESS modelling language and diagrams for data modelling. These data definitions are related to SI units and allow to define any unit based on those.  Interoperability with IFC is a key in context of building information modelling related standards. While N0233 document only suggests introduction of dimensional exponents we see this as insufficient because dimensional exponents only define kind of a measure (length, area, acceleration), but not the unit itself (meter, meter squared, meters per second etc.). 

We recognize that because IFC and ISO 12006-3 both use EXPRESS modelling language it would be possible to reference selected data entities from IFC in the ISO 12006-3 directly, making them part of the main schema.  Part of the IFC schema describing units is almost self-contained (without dependencies on other parts of the schema). But it is not independent completely so this approach would indirectly import number of entity types and defined types which are not necessary for the scope of ISO 12006- 3.

Because of that we decided to use another approach where we isolated part of the IFC data schema necessary to describe units in a full depth, made minor modifications to make it completely self-contained and used ISO 12006-3 naming convention to make those part of the core schema. 

# Values
Values are currently only stored as a text in ISO 12006-3. This is sufficient for human communication over concepts but can’t be used reliably to exchange numeric of logical data. EXPRESS schema already contains native support for other base data types and xtdValue should be able to contain these as well. Using these types brings reliable and well defined rules for value encoding when stored as STEP21, XML or other physical format. Together with machine readable units this provides base support for reliable data exchange between IFC and ISO 12006-3.

When investigating this part of the schema we also realised that xtdValue is used to define both the value or the value constraint. This allows for the level of ambiguity which might make it hard even for humans to get to common understanding of the actual meaning. Based on this observation we make a suggestion to separate those two concepts and to introduce xtdConstraint entity type which can be applied to property in a similar way to xtdValue. As a result, property might have a value and/or constraint (or more of them). 

For scenarios like product data templates constraints would be a lot more appropriate to describe actual concepts in the schema with good level of common understanding. Several new relations are introduced in our suggestion to support similar relations between xtdObject, xtdProperty and xtdConstraint as is already available for xtdProperty.

# External Schemas
If ISO 12006-3 is used to inform structure of external data than it is likely to represent data concepts present in external schemas. IFC is one of a particular interest as a widely used and adopted standard. But suggested approach is usable for any external system. It introduces new entity types which describe both the schema and external entity. External systems can use this information to identify the mapping reliably. Any xtdObject can have a mapping to external schema object. External object can be described by identifier and sub-identifier. This allows for more detailed description of the object. In case of IFC this can be used to describe entity type by identifier and predefined type as sub-identifier. Other external automated systems might use it for other fine grained differentiation.