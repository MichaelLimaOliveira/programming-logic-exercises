using Newtonsoft.Json;
using System;
using System.IO;

namespace AtividadeDadosTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma instância de Database - que contém as funções para manipular os dados salvos, tanto carregar quanto salvar
            Database database = new Database();

            //Criando uma instância de Character, classe que representa os atributos do jogador
            Character estrevim = new Character(0, 0, "Estrevim");

            //Chamando a função que adiciona gold pro Character
            estrevim.AddGold(1);

            //Chamando a função de salvar passando o estrevim que é um objeto da classe Character
            database.SaveData(estrevim);

            //Adicionando experience com a função AddExperience
            estrevim.AddExperience(500);
            
            //Repetindo o processo da linha 20
            database.SaveData(estrevim);

            //Carregando os dados do arquivo que está configurado na classe Database
            estrevim = database.LoadData();
            Console.WriteLine(estrevim.Name);
            Console.WriteLine(estrevim.Gold);
            Console.WriteLine(estrevim.Experience);
        }
    }

    public class Database
    {
        readonly string filePath = @"C:\Repositorio\Atividades\AtividadeDadosTexto\AtividadeDadosTexto\char.data";

        public void SaveData(Character charData)
        {
            //Transformando o objeto charData em texto no formato json para poder salvar no arquivo txt
            string characterDataJson = JsonConvert.SerializeObject(charData);

            //Função da biblioteca SystemIO que usa as funções do sistema operacional para construir um arquivo em texto
            //Aqui ele escreve no caminho configurado acima todos os dados passados pelo parâmetro
            File.WriteAllText(filePath, characterDataJson);
        }

        public Character LoadData()
        {
            //Checando se o arquivo existe, caso não exista lança um exceção!
            if (!File.Exists(filePath))
                throw new Exception("Save data not found!");

            //Aqui já está carregando e lendo o que está no arquivo da configuração. Lê todo o conteúdo e passa para a variável charData;
            string charData = File.ReadAllText(filePath);

            //Aqui é utilizado uma função da biblioteca Newtonsoft para transformar o texto, que está em formato json, no objeto da classe Character
            Character characterData = JsonConvert.DeserializeObject<Character>(charData);

            return characterData;
        }
    }

    public class Character
    {
        [JsonConstructor]
        public Character(decimal gold,
                         long experience,
                         string name)
        {
            Gold = gold;
            Experience = experience;
            Name = name;
        }

        public decimal Gold { get; protected set; }
        public long Experience { get; protected set; }
        public string Name { get; protected set; }

        public void AddGold(decimal gold)
        {
            if (gold < 0)
                throw new ArgumentException("Invalid gold value!");

            Gold += gold;
        }

        public void RemoveGold(decimal gold)
        {
            if (gold < 0)
                throw new ArgumentException("Invalid gold value!");

            if (Gold - gold < 0)
                throw new Exception("Insuficcient gold!");

            Gold -= gold;
        }

        public void AddExperience(long experience)
        {
            if (experience < 0)
                throw new ArgumentException("Invalid gold value!");

            Experience += experience;
        }

        public void ChangeNickName(string nickname)
        {
            if (string.IsNullOrEmpty(nickname))
                throw new ArgumentNullException("Invalid Nickname!");

            Name = nickname;
        }
    }
}
