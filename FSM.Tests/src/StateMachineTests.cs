using System;
using FSM.Tests.SampleClasses;
using NUnit.Framework;
using Shouldly;

namespace FSM.Tests {
    [TestFixture]
    public class StateMachineTests {
        [Test]
        public void Does_Initialize_To_Proper_State() {
            var sampleFsm = new ConcreteFSM();
            
            sampleFsm.CurrentState.GetType().ShouldBe(typeof(ConcreteFS1));
        }
        
        [Test]
        public void Does_Transition_To_Proper_State() {
            var sampleFsm = new ConcreteFSM();
            
            sampleFsm.ChangeState(sampleFsm.States[typeof(ConcreteFS2)]);
            
            sampleFsm.CurrentState.GetType().ShouldBe(typeof(ConcreteFS2));
        }
    }
}