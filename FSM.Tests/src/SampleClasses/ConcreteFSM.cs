using System;
using System.Collections.Generic;
using KGC.FSM.StateMachines;

namespace FSM.Tests.SampleClasses {
    public class ConcreteFSM : IFiniteStateMachine<StateBase> {
        public Dictionary<Type, StateBase> States { get; set; }
        public StateBase CurrentState { get; set; }

        public void InitializeStates() {
            States = new Dictionary<Type, StateBase> {
                {typeof(ConcreteFS1), new ConcreteFS1(this)},
                {typeof(ConcreteFS2), new ConcreteFS2(this)}
            };
            ChangeState(States[typeof(ConcreteFS1)]);
        }

        public virtual void ChangeState(StateBase newState) {
            CurrentState?.Exit();
            CurrentState = newState;
            CurrentState?.Enter();
        }

        public ConcreteFSM() {
            InitializeStates();
        }
    }
}