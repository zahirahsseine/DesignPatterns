# Design Patterns Summary

| **Category**  | **Pattern** | **Definition** | **Main Components** | **When NOT to Use** |
|---------------|-------------|----------------|----------------------|---------------------|
| **Creational** | **Singleton** | Ensures a class has only one instance and provides a global access point. | Private constructor, static instance, public accessor. | When multiple instances are required or global state is harmful. |
|  | **Factory Method** | Defines an interface for creating objects, but lets subclasses decide the instance type. | Creator, Concrete Creator, Product, Concrete Product. | When object creation is simple and doesn’t vary. |
|  | **Abstract Factory** | Provides an interface for creating families of related objects without specifying concrete classes. | Abstract Factory, Concrete Factory, Abstract Product, Concrete Product. | When products don’t need to be related or created in families. |
|  | **Builder** | Separates construction of a complex object from its representation. | Builder, Concrete Builder, Director, Product. | When object creation is straightforward. |
|  | **Prototype** | Creates new objects by cloning an existing instance. | Prototype interface, Concrete Prototype. | When objects are cheap to create with `new`. |
| **Structural** | **Adapter** | Converts the interface of a class into another interface clients expect. | Target, Adapter, Adaptee. | When you can modify the existing class directly. |
|  | **Bridge** | Decouples abstraction from implementation so both can vary independently. | Abstraction, Implementor, Concrete Implementor. | When abstraction and implementation rarely change. |
|  | **Composite** | Composes objects into tree structures to represent part-whole hierarchies. | Component, Leaf, Composite. | When the hierarchy is simple or flat. |
|  | **Decorator** | Adds responsibilities to an object dynamically. | Component, Concrete Component, Decorator, Concrete Decorator. | When inheritance is simpler and sufficient. |
|  | **Facade** | Provides a simplified interface to a complex subsystem. | Facade, Subsystems. | When direct subsystem use is already simple. |
|  | **Flyweight** | Minimizes memory by sharing common state between objects. | Flyweight, Concrete Flyweight, Flyweight Factory. | When object sharing is unnecessary or state is always unique. |
|  | **Proxy** | Controls access to another object. | Subject, Real Subject, Proxy. | When direct access is straightforward and cheap. |
| **Behavioral** | **Chain of Responsibility** | Passes a request along a chain of handlers until one handles it. | Handler, Concrete Handlers, Client. | When all requests should be handled by a single object. |
|  | **Command** | Encapsulates a request as an object. | Command, Concrete Command, Receiver, Invoker. | When direct method calls are sufficient. |
|  | **Interpreter** | Defines a grammar and an interpreter for a language. | Abstract Expression, Terminal Expression, Nonterminal Expression, Context. | When grammar is simple or rarely changes. |
|  | **Iterator** | Provides a way to access elements sequentially without exposing the collection’s internal structure. | Iterator, Concrete Iterator, Aggregate, Concrete Aggregate. | When collection traversal is trivial or fixed. |
|  | **Mediator** | Centralizes complex communications between objects. | Mediator, Concrete Mediator, Colleagues. | When communication is simple and minimal. |
|  | **Memento** | Captures and restores an object’s internal state without exposing it. | Originator, Memento, Caretaker. | When object state can be easily recalculated instead of stored. |
|  | **Observer** | Defines a one-to-many dependency so that when one object changes, all dependents are notified. | Subject, Concrete Subject, Observer, Concrete Observer. | When the number of observers is small or fixed. |
|  | **State** | Allows an object to change its behavior when its internal state changes. | Context, State, Concrete States. | When states don’t change often. |
|  | **Strategy** | Defines a family of algorithms, encapsulates each, and makes them interchangeable. | Strategy, Concrete Strategies, Context. | When only one algorithm is needed. |
|  | **Template Method** | Defines the skeleton of an algorithm, letting subclasses override certain steps. | Abstract Class, Concrete Class. | When the algorithm’s steps are unlikely to vary. |
|  | **Visitor** | Separates algorithms from the objects on which they operate. | Visitor, Concrete Visitor, Element, Concrete Element. | When object structure changes often. |
