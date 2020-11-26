using KGC.FSM.StateMachines;

namespace KGC.FSM.States {
    public interface IState<TStateMachine, TState>
    where TStateMachine : IFiniteStateMachine<TState>
    where TState : IState<TStateMachine, TState> {
        TStateMachine StateMachine { get; }
        void Enter();
        void Update();
        void LateUpdate();
        void FixedUpdate();
        void Exit();
    }
}