using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uri1049.Animal
{
    public class AnimalService
    {
        List<Animal> Animals { get; set; }
        public AnimalService()
        {
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
            var animal = Animals.Where(animal => animal.BodyType.IsEqual(bodyType) &&
                                           animal.AnimalType.IsEqual(animalType) &&
                                           animal.AlimentationType.IsEqual(alimentationType)).FirstOrDefault();

            if (animal is null)
            {
                throw new Exception("Animal não encontrado ou não cadastrado no sistema!");
            }

            return animal;
        }
    }
}
