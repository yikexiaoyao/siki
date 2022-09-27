using Newtonsoft.Json;

namespace _030_Json操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ////Deserialize 反序列化
            //Skill[] skillArray = JsonConvert.DeserializeObject<Skill[]>(File.ReadAllText("Skills.txt"));
            //foreach (Skill s in skillArray)
            //{
            //    Console.WriteLine(s.id + "," + s.name + "," + s.damage);
            //}

            ////Serialize 序列化
            //Skill skill = new Skill();
            //skill.id = 100;
            //skill.name = "siki";
            //skill.damage = 999;

            //string str = JsonConvert.SerializeObject(skill);
            //Console.WriteLine(str);

            //string[] names = { "Micheal", "张三", "李四" };
            //string str = JsonConvert.SerializeObject(names);
            //Console.WriteLine(str);

            //List<Skill> skillArray = JsonConvert.DeserializeObject<List<Skill>>(File.ReadAllText("Skills.txt"));
            //foreach (Skill s in skillArray)
            //{
            //    Console.WriteLine(s.id + "," + s.name + "," + s.damage);
            //}

            Hero hero = JsonConvert.DeserializeObject<Hero>(File.ReadAllText("Hero.txt"));
            Console.WriteLine(hero.name);
            Console.WriteLine(hero.maxHP);
            Console.WriteLine(hero.type);
            foreach (Skill s in hero.skillList)
            {
                Console.WriteLine(s.id + "," + s.name + "," + s.damage);
            }
        }
    }
}