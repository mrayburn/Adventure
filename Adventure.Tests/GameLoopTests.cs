using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Adventure.Tests
{
    [TestClass]
    public class GameLoopTests
    {
        GameLoop game;
        [TestMethod]
        public void Should_Call_Execute_On_Command()
        {
            //Arrange
            var cmdList = new List<ICommand>();
            ICommand mockCmd = MockRepository.GenerateMock<ICommand>();
            mockCmd.Stub(m => m.IsValid(Arg<string>.Is.Anything)).Return(true);
            cmdList.Add(mockCmd);
            IConsoleFacade console = MockRepository.GenerateMock<IConsoleFacade>();
            console.Stub(m => m.ReadLine()).Return("exit");
            game = new GameLoop(console, cmdList);

            //Act
            game.RunLoop();

            //Assert
            mockCmd.AssertWasCalled(m => m.Execute(Arg<string>.Is.Anything));
        }
    }
}
