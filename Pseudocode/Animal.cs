using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pseudocode
{
    internal class Animal
    {
        //field
        string en;
        string ph;
        string vn;
        int loai;
        //properties
        public string En { get => en; set => en = value; }
        public string Ph { get => ph; set => ph = value; }
        public string Vn { get => vn; set => vn = value; }
        public int Loai { get => loai; set => loai = value; }
        //constructor
        public Animal()
        {
            en = "";
            ph = "";
            vn = "";
            loai = 0;
        }
        public Animal(string en, string ph, string vn, int loai)
        {
            this.en = en;
            this.ph = ph;
            this.vn = vn;
            this.loai = loai;
        }
        public Animal(Animal newAnimal)
        {
            this.en = newAnimal.en;
            this.ph = newAnimal.ph;
            this.vn = newAnimal.vn;
            this.loai = newAnimal.loai;
        }

    }
}
