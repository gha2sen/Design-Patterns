# Behavioral patterns:

Behavioral patterns focus on how objects **interact** and **communicate** with each others.


## State:
The State Pattern lets an object (context) changes its behavior when its internal state(concrete state) changes.

### Key concepts:
- Context: the main object with **diffrent states**. Each state makes a context instance **behave in diffrently**.
- State Interface: Defines behaviors that all states must implement.
- Concrete states: containing the actual implementation of the behavior.

### How to implement it:
- Identify the context.
- Identify the states.
- Define a state interface(identify behaviors for each state).
- Implement Concrete States.
- Implement Context and link the state.



## Command:
// TODO: write definition 
### Key concepts:
// TODO: write key concepts 




## Memento
The memento Pattern it used to **capture and restore state** of an object **without exposing internal implementation** preserving **encapsulation**

### key concepts:
- Originator: the main object whose state we want to save/restore. it is responsible for defining the method to create a memento and the method to restore the state based on it.
- Memento: stores the internal state for the originator (in csharp can be a record).
- Caretaker: stores memento objects.