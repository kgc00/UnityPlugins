using System;
using System.Collections.Generic;

namespace KGC.FSM.StateMachines {
    public interface IFiniteStateMachine<TState> {
        Dictionary<Type, TState> States { get; }
        TState CurrentState { get; }
        void InitializeStates();
        void ChangeState(TState newState);
    }
}