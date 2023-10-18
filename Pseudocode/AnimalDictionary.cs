using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocode
{
    internal class AnimalDictionary <T>
    {
        //field
        string[] Species = { "1. Vật nuôi", "2. Động vật hoang dã", "3. côn trùng", "4. Lưỡng cư", "5. Động vật dưới nước", "6. Loài chim" };
        LinkedList<Animal> [] AddByFirstLetter = new LinkedList<Animal>[26];
        //properties
        //constructor
        public AnimalDictionary()
        {
            for (int i = 0; i < 26; i++)
            {
                AddByFirstLetter[i] = new LinkedList<Animal>();
            }
        }
        //method
        public void AddAnimal(Animal element)
        {
            int index = Char.ToUpper(element.En[0]) - 65;
            AddByFirstLetter[index].AddLast(element);
        }
        public LinkedList<Animal> FindWord(char firstLetter)
        {
            int index = Char.ToUpper(firstLetter) - 65;
            return AddByFirstLetter[index];
        }
        public LinkedList<Animal> FindAnimalBySpecies(int loai)
        {
            List<Animal> result = AddByFirstLetter.SelectMany(list => list.Where(animal => animal.Loai == loai)).ToList();
            return new LinkedList<Animal>(result);
        }
        public LinkedList<Animal> FindAnimalByFirstWord(char x)
        {
            List<Animal> result = AddByFirstLetter.SelectMany(list => list.Where(animal => animal.En[0] == Char.ToUpper(x))).ToList();
            return new LinkedList<Animal>(result);
        }
        public void ShowList()
        {
            foreach(var item in AddByFirstLetter)
            {
                foreach(var info in item)
                {
                    var species = Species[info.Loai - 1];
                    Console.WriteLine(info.En + " - " + info.Ph + " - " + info.Vn + " - " + species);
                }
            }
        }
    }
}
