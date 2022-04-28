using System;
using System.Collections.Generic;
using System.Text;

namespace uri1049.Animal
{
    public class Animal
    {
        public Animal(string nome,
                      BodyType bodyType,
                      AlimentationType alimentationType,
                      AnimalType animalType)
        {
            Nome = nome;
            BodyType = bodyType;
            AlimentationType = alimentationType;
            AnimalType = animalType;
        }

        public string Nome { get; set; }
        public BodyType BodyType { get; set; }
        public AlimentationType AlimentationType { get; set; }
        public AnimalType AnimalType { get; set; }
    }
}
