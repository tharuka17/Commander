using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo // Implementing our Interface
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = " I love you", Line = "I like you", Platform = "Heaven" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "knife and chopping board" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place tea bag in cup", Platform = "Kettle and cup" }

        };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = " I love you", Line = "I like you", Platform = "Heaven" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
