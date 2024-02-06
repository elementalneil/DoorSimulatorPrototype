using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeiss.DoorSimulatorPrototype;
using System;

namespace DoorSimulatorPrototype.Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void CreatingSimpleDoorShouldSetModel() {
            SimpleDoor door = new SimpleDoor();
            string model = door.Model;
            Assert.IsNotNull(model);

            SmartDoor smartDoor = new SmartDoor();
            model = smartDoor.Model;
            Assert.IsNotNull(model);
        }

        [TestMethod]
        public void CheckStateOnOpeningAndClosing() {
            SmartDoor smartDoor = new SmartDoor();

            // It should be closed initially
            Assert.AreEqual(smartDoor.State, DoorState.CLOSED);

            // Opening the door should set the state to open
            smartDoor.OpenDoor();
            Assert.AreEqual(smartDoor.State, DoorState.OPEN);

            // Calling OpenDoor() when the door is already open should not change the state.
            smartDoor.OpenDoor();
            Assert.AreEqual(smartDoor.State, DoorState.OPEN);

            // Now calling CloseDoor() should set the state to closed
            smartDoor.CloseDoor();
            Assert.AreEqual(smartDoor.State, DoorState.CLOSED);

            // Caling CloseDoor() when the door is already closed should not change the state
            smartDoor.CloseDoor();
            Assert.AreEqual(smartDoor.State, DoorState.CLOSED);
        }
    }
}
