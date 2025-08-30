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