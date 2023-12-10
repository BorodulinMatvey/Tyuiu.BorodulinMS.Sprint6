using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BorodulinMS.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        

        public string CollectTextFromFile(string path)
        {
            string str = "r";
            string resStr = "";
            using (StreamReader reader = new StreamReader (path))
            {
                string line;
                while ((line = reader.ReadLine ())!=null)
                {
                    if(line.Contains(str))
                    {
                        resStr = resStr + "" + line;
                    }
                }
            }
            return resStr;
        }
    }
}
