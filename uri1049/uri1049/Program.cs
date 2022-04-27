using System;
using System.Collections.Generic;
using System.Linq;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string bodyType, animalType, alimentationType;
            bodyType = Console.ReadLine();
            animalType = Console.ReadLine();
            alimentationType = Console.ReadLine();

            var animalService = new AnimalService();
            var animal = animalService.GetAnimal(bodyType, animalType, alimentationType);
            Console.WriteLine(animal.Nome);
        }

        public class AnimalService
        {
            List<Animal> Animals { get; set; }
            public AnimalService()
            {
                Animals = new List<Animal>();

                var animalService = new AnimalTypeService();
                var aguiaTypes = animalService.GetTypes("vertebrado", "ave", "carnivoro");
                Animals.Add(new Animal("aguia",
                                        aguiaTypes.bodyType,
                                        aguiaTypes.alimentationType,
                                        aguiaTypes.animalType));

                var pombaTypes = animalService.GetTypes("vertebrado", "ave", "onivoro");
                Animals.Add(new Animal("pomba",
                                        pombaTypes.bodyType,
                                        pombaTypes.alimentationType,
                                        pombaTypes.animalType));

                var homemTypes = animalService.GetTypes("vertebrado", "mamifero", "onivoro");
                Animals.Add(new Animal("homem",
                                        homemTypes.bodyType,
                                        homemTypes.alimentationType,
                                        homemTypes.animalType));

                var vacaTypes = animalService.GetTypes("vertebrado", "mamifero", "herbivoro");
                Animals.Add(new Animal("vaca",
                                       vacaTypes.bodyType,
                                       vacaTypes.alimentationType,
                                       vacaTypes.animalType));

                var pulgaTypes = animalService.GetTypes("invertebrado", "inseto", "hematofago");
                Animals.Add(new Animal("pulga",
                                       pulgaTypes.bodyType,
                                       pulgaTypes.alimentationType,
                                       pulgaTypes.animalType));

                var lagartaTypes = animalService.GetTypes("invertebrado", "inseto", "herbivoro");
                Animals.Add(new Animal("lagarta",
                                         lagartaTypes.bodyType,
                                         lagartaTypes.alimentationType,
                                         lagartaTypes.animalType));

                var sanguessugaTypes = animalService.GetTypes("invertebrado", "anelideo", "hematofago");
                Animals.Add(new Animal("sanguessuga",
                                              sanguessugaTypes.bodyType,
                                              sanguessugaTypes.alimentationType,
                                              sanguessugaTypes.animalType));

                var minhocaTypes = animalService.GetTypes("invertebrado", "anelideo", "onivoro");
                Animals.Add(new Animal("minhoca",
                                              minhocaTypes.bodyType,
                                              minhocaTypes.alimentationType,
                                              minhocaTypes.animalType));
            }

            public Animal GetAnimal(string bodyType, string animalType, string alimentationType)
            {
                var ani = Animals.Where(animal => animal.BodyType.IsEqual(bodyType) &&
                                               animal.AnimalType.IsEqual(animalType) &&
                                               animal.AlimentationType.IsEqual(alimentationType)).FirstOrDefault(); 
                return ani;
            }
        }

        public class AnimalTypeService
        {
            List<BodyType> BodyTypes { get; set; }
            List<AnimalType> AnimalTypes { get; set; }
            List<AlimentationType> AlimentationTypes { get; set; }

            public AnimalTypeService()
            {
                BodyTypes = new List<BodyType>()
                {
                    new BodyType("vertebrado"),
                    new BodyType("invertebrado")
                };

                AnimalTypes = new List<AnimalType>()
                {
                    new AnimalType("ave"),
                    new AnimalType("mamifero"),
                    new AnimalType("inseto"),
                    new AnimalType("anelideo")
                };

                AlimentationTypes = new List<AlimentationType>()
                {
                    new AlimentationType("carnivoro"),
                    new AlimentationType("herbivoro"),
                    new AlimentationType("onivoro"),
                    new AlimentationType("hematofago")
                };
            }

            public (BodyType bodyType, AnimalType animalType, AlimentationType alimentationType) GetTypes(string body, string animal, string alimentation)
            {
                var bodyType = BodyTypes.Where(e => e.IsEqual(body)).FirstOrDefault();
                var animalType = AnimalTypes.Where(e => e.IsEqual(animal)).FirstOrDefault();
                var alimentationType = AlimentationTypes.Where(e => e.IsEqual(alimentation)).FirstOrDefault();

                return (bodyType, animalType, alimentationType);
            }
        }

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
            public BodyType(string type):base(type)
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
}
