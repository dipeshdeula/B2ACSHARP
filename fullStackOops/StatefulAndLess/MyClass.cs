/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.StatefulAndLess
{
    public class MyClass
    {
        private List<string> dataList = new List<string>();

        public void AddData(string data) // Stateful
        {
            dataList.Add(data);
        }

        public List<string> GetData() // Stateless
        {
            return dataList;
        }

        public static void Main(string[] args)
        { 
            MyClass myClass = new MyClass();
            myClass.AddData("Data1");
            myClass.AddData("Data2");
            myClass.AddData("Data3");

            List<string> dataList = myClass.GetData();
            foreach (string data in dataList)
            {
                Console.WriteLine(data);
            }
            
        }
    }
}
*/