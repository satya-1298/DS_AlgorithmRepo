using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm
{
    public class InsertionSort
    {
        public void Display()
         
        {
            string[] str = {"avi","aa","as"};
            int s=str.Length;
            //string[] ch1 = str.ToLower().ToStringArray();

            for (int i = 0; i < s; i++)
            {
                
                var flag = 0;
                string temp="";
                for(int j=i+1; j<s; j++)
                {

                    if (str[i].CompareTo(str[j])>0)
                    {
                       temp = str[i];
                        str[i] = str[j];
                        str[j] =temp;
                        

                    }
                      

                }
               
                
            }
            foreach (string d in str)
            {
                Console.WriteLine(d);
            }



        }
    }
}
