using System;
using System.Collections.Generic;
using System.Linq;
using uri1049.Animal;

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
                    new AnimalType("anelidio")
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
        var animalType = AnimalTypes.Where(e => e.IsEqual(alimentation)).FirstOrDefault();
        var alimentationType = AlimentationTypes.Where(e => e.IsEqual(animal)).FirstOrDefault();

        if (bodyType is null || animalType is null || alimentationType is null)
            throw new Exception("Não foi encontrado as especificações pedidas no banco de dados!");

        return (bodyType, animalType, alimentationType);
    }
}