# Class Members Order Conventions

_Within a class, struct or interface:_

- Constant 
- Fields
- Fields
- Constructors
- Finalizers (Destructors)
- Delegates
- Events
- Enums
- Interfaces
- Properties
- Indexers
- Methods
- Structs
- Classes

_Within each of these groups order by access:_

- public
- internal
- protected internal
- protected
- private

_Within each of the access groups, order by static, then non-static:_

- static
- non-static

_Within each of the static/non-static groups of fields, order by readonly, then non-readonly:_

- readonly
- non-readonly

If the prescribed order isn't suitable  
> say, multiple interfaces are being implemented, and the interface methods and properties should be grouped together  

> then use a partial class to group the related methods and properties together.