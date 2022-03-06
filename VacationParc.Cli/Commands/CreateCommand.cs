using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CliFx;
using CliFx.Attributes;
using CliFx.Exceptions;
using CliFx.Infrastructure;
using VacationParc.Model;

namespace VacationParc.Cli.Commands
{
    [Command("create", Description = "Creates a parc element")]
    public class CreateCommand : ICommand
    {
        private List<string> knownTypes = new List<string> { "parc" };

        [CommandParameter(0, IsRequired = true)]
        public string Type { get; set; }

        [CommandOption("name", 'n', Description = "Name of the item you want to create", IsRequired = true)]
        public string Name { get; set; }

        public async ValueTask ExecuteAsync(IConsole console)
        {
            if (!knownTypes.Contains(Type))
                throw new CommandException("A unknown type was provided");

            ParcElement element;
            switch (Type)
            {
                case "parc":
                    element = new Parc(Name);
                    await console.Output.WriteLineAsync(element.ToString());
                    break;
            }

        }
    }
}
