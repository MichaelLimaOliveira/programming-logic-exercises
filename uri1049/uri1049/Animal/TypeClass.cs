using System;
using System.Collections.Generic;
using System.Text;

namespace uri1049.Animal
{
    public abstract class TypeClass
    {
        public TypeClass(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
        public bool IsEqual(string type) => Type == type;
    }

    public class BodyType : TypeClass
    {
        public BodyType(string type) : base(type)
        {

        }
    }

    public class AlimentationType : TypeClass
    {
        public AlimentationType(string type) : base(type)
        {

        }
    }

    public class AnimalType : TypeClass
    {
        public AnimalType(string type) : base(type)
        {

        }
    }
}
