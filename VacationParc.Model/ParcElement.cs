using System;
namespace VacationParc.Model
{
    public abstract class ParcElement
    {
        public string Name { get; private set; }

        public ParcElement(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"This parc is named '{Name}'";
        }
    }
}
