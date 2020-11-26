using KGC.FSM.States;

namespace FSM.Tests.SampleClasses {
    public abstract class StateBase : IState<ConcreteFSM, StateBase> {
        public ConcreteFSM StateMachine { get; }
        public void Enter() { }

        public void Update() { }

        public void LateUpdate() { }

        public void FixedUpdate() { }
        public void Exit() { }

        protected StateBase(ConcreteFSM stateMachine) {
            StateMachine = stateMachine;
        }
    }
}