using System;
namespace Pseudocode;
class Program
{
    public static string[] Species = { "1. Vật nuôi", "2. Động vật hoang dã", "3. côn trùng", "4. Lưỡng cư", "5. Động vật dưới nước", "6. Loài chim" };
    public static AnimalDictionary<Animal> list = new AnimalDictionary<Animal>();
    public static void CreateListAnimal()
    {
        list.AddAnimal(new Animal("Cat", "/kæt/", "Mèo", 1));
        list.AddAnimal(new Animal("Kitten", "/ˈkɪt.ən/", "Mèo con", 1));
        list.AddAnimal(new Animal("Dog", "/dɒg/", "Chó", 1));
        list.AddAnimal(new Animal("Parrot", "/’pærət/", "Vẹt", 1));
        list.AddAnimal(new Animal("Rabbit", "/’ræbit/", "Thỏ", 1));
        list.AddAnimal(new Animal("Owl", "/aul/", "Chim cú", 6));
        list.AddAnimal(new Animal("Raven", "/ˈreɪvn/", "Quạ", 6));
        list.AddAnimal(new Animal("Swan", "/swɒn/", "Thiên nga", 6));
        list.AddAnimal(new Animal("Tiger", "/ˈtaɪɡər/", "Hổ", 2));
        list.AddAnimal(new Animal("Bear", "/ber/", "Gấu", 2));
        list.AddAnimal(new Animal("Eagle", "/ˈiːɡəl/", "Đại bàng", 6));
        list.AddAnimal(new Animal("Penguin", "/ˈpɛŋɡwɪn/", "Chim cánh cụt", 6));
        list.AddAnimal(new Animal("Ant", "/ænt/", "Kiến", 3));
        list.AddAnimal(new Animal("Salamander", "/ˌsæləˈmændər/", "Thằn lằn", 4));
        list.AddAnimal(new Animal("Dolphin", "/ˈdɒlfɪn/", "Cá heo", 5));
        list.AddAnimal(new Animal("Seahorse", "/ˈsiːhɔːrs/", "Ngựa biển", 5));
        list.AddAnimal(new Animal("Zebra", "/ˈziːbrə/", "Ngựa vằn", 2));
        list.AddAnimal(new Animal("Ladybug", "/ˈleɪdiˌbʌɡ/", "Bọ cánh cứng", 3));
        list.AddAnimal(new Animal("Toad", "/toʊd/", "Ếch", 4));
        list.AddAnimal(new Animal("Octopus", "/ˈɑːktəpəs/", "Bạch tuộc", 5));
        list.AddAnimal(new Animal("Hamster", "/ˈhæmstər/", "Chuột nhảy", 1));
        list.AddAnimal(new Animal("Goldfish", "/ˈɡoʊldˌfɪʃ/", "Cá vàng", 1));
        list.AddAnimal(new Animal("Canary", "/ˈkænəri/", "Chim sơn ca", 1));
        list.AddAnimal(new Animal("Guinea Pig", "/ˈɡɪni pɪɡ/", "Mèo Mỹ", 1));
        list.AddAnimal(new Animal("Lion", "/ˈlaɪən/", "Sư tử", 2));
        list.AddAnimal(new Animal("Elephant", "/ˈɛlɪfənt/", "Voi", 2));
        list.AddAnimal(new Animal("Giraffe", "/dʒɪˈræf/", "Hươu cao cổ", 2));
        list.AddAnimal(new Animal("Kangaroo", "/ˌkæŋɡəˈru/", "Kangaroo", 2));
        list.AddAnimal(new Animal("Butterfly", "/ˈbʌtərflaɪ/", "Bướm", 3));
        list.AddAnimal(new Animal("Grasshopper", "/ˈɡræsˌhɒpər/", "Châu chấu", 3));
        list.AddAnimal(new Animal("Mosquito", "/məˈskiːtoʊ/", "Muỗi", 3));
        list.AddAnimal(new Animal("Bee", "/bi/", "Ong", 3));
        list.AddAnimal(new Animal("Frog", "/frɒɡ/", "Ếch", 4));
        list.AddAnimal(new Animal("Salamander", "/ˌsæləˈmændər/", "Thằn lằn", 4));
        list.AddAnimal(new Animal("Newt", "/njuːt/", "ễn", 4));
        list.AddAnimal(new Animal("Toad", "/toʊd/", "Ếch", 4));
        list.AddAnimal(new Animal("Shark", "/ʃɑrk/", "Cá mập", 5));
        list.AddAnimal(new Animal("Whale", "/weɪl/", "Cá voi", 5));
        list.AddAnimal(new Animal("Seahorse", "/ˈsiːhɔːrs/", "Ngựa biển", 5));
        list.AddAnimal(new Animal("Eagle", "/ˈiːɡəl/", "Đại bàng", 6));
        list.AddAnimal(new Animal("Penguin", "/ˈpɛŋɡwɪn/", "Chim cánh cụt", 6));
        list.AddAnimal(new Animal("Hawk", "/hɔk/", "Diều hâu", 6));
        list.AddAnimal(new Animal("Sparrow", "/ˈspæroʊ/", "Chim sẻ", 6));
    }
    public static void Main() 
    {
        Menu();
    }
    public static void Menu()
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            CreateListAnimal();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Từ điển Anh – Việt về thú vật");
            Console.WriteLine("-------------------------------");
            do
            {
                Console.WriteLine("1: Tìm với chữ cái");
                Console.WriteLine("2: Tìm với loài");
                Console.WriteLine("3: Tìm tất cả loài chữa chữ cái ban đầu");
                Console.WriteLine("4: Show full từ điển");
                Console.WriteLine("0: Thoát");
                Console.WriteLine("-------------------------------");
                int.TryParse(Console.ReadLine(), out int x);
                if (x == 1)
                {
                    Console.Write("Nhập chữ cái bạn muốn tìm: ");
                    char.TryParse(Console.ReadLine(), out char word);
                    var findWord = list.FindWord(word);
                    foreach (var item in findWord)
                    {
                        var species = Species[item.Loai - 1];
                        Console.WriteLine(item.En + " - " + item.Ph + " - " + item.Vn + " - " + species);
                    }
                }
                else if (x == 2)
                {
                    Console.Write("Nhập loài bạn muốn tìm: ");
                    int.TryParse(Console.ReadLine(), out int word);
                    var findWord = list.FindAnimalBySpecies(word);
                    foreach (var item in findWord)
                    {
                        var species = Species[item.Loai - 1];
                        Console.WriteLine(item.En + " - " + item.Ph + " - " + item.Vn + " - " + species);
                    }
                }
                else if (x == 3)
                {
                    Console.Write("Nhập chữ cái ban đầu: ");
                    char.TryParse(Console.ReadLine(), out char word);
                    var findWord = list.FindAnimalByFirstWord(word);
                    foreach (var item in findWord)
                    {
                        var species = Species[item.Loai - 1];
                        Console.WriteLine(item.En + " - " + item.Ph + " - " + item.Vn + " - " + species);
                    }
                }
                else if (x == 4)
                {
                    list.ShowList();
                }
                else if (x == null || x == 0) return;
            } while (true);
        }
        catch(Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
    public void Show()
    {
        
    }
}