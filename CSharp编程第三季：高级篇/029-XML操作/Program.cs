using System.Xml;

namespace _029_XML操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Skill> list = new List<Skill>();
            XmlDocument xmlDoc = new XmlDocument();

            //xmlDoc.Load("Skills.xml");  //加载 xml 文件 通过路径
            xmlDoc.LoadXml(File.ReadAllText("Skills.xml")); //通过字符串

            XmlNode root = xmlDoc.ChildNodes[1];   //获取根节点  第一个子节点
            XmlNodeList skillList = root.ChildNodes;    //获取子节点
            foreach (XmlNode skill in skillList)
            {
                Skill skillObj = new Skill();
                //foreach (XmlNode node in skill.ChildNodes)
                //{
                //    if (node.Name == "id")
                //    {
                //        skillObj.ID = Int32.Parse(node.InnerText);  //类型转换
                //    }
                //    else if (node.Name == "name")
                //    {
                //        skillObj.Name = node.InnerText;
                //        skillObj.Lang = node.Attributes[0].Value;   //属性
                //    }
                //    else if (node.Name == "damage")
                //    {
                //        skillObj.Damage = Int32.Parse(node.InnerText);
                //    }
                //}

                XmlElement idEle = skill["id"];
                skillObj.ID = Int32.Parse(idEle.InnerText);

                XmlElement nameEle = skill["name"];
                skillObj.Name = nameEle.InnerText;

                XmlAttributeCollection attriCol = nameEle.Attributes;
                XmlAttribute attri = attriCol["lang"];
                skillObj.Lang = attri.Value;

                XmlElement damageEle = skill["damage"];
                skillObj.Damage = Int32.Parse(damageEle.InnerText);

                list.Add(skillObj);
            }
            foreach (Skill s in list)
            {
                Console.WriteLine(s.ID + "," + s.Name + "," + s.Lang + "," + s.Damage);
            }
        }
    }
}