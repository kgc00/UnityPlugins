﻿using System;
using System.Collections.Generic;
using FSM.States;

namespace FSM.StateMachines {
    public interface IFiniteStateMachine<T> where T : IEntityState<T> {
        Dictionary<Type, IEntityState<T>> States { get; }
        IEntityState<T> CurrentState { get; }

        void InitializeStates();

        void ChangeState(IEntityState<T> newState);
    }
}