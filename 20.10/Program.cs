using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace _20._10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\works\20.10\info.txt";

            ArrayList list = new ArrayList();
            List<string> list1 = new List<string>();
            List<client> clients = new List<client>();

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string text;
                while ((text = sr.ReadLine()) != null)
                {
                    list.Add(text);
                }
            }
            foreach (string s in list)
            {
                string[] spl = s.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < spl.Length; i++)
                {
                    list1.Add(spl[i]);
                }
            }
            int count = 0;
            for (int j = 0; j < list1.Count / 3; j++)
            {
                clients.Add(new client());
            }
            for (int c = 0; c < clients.Count; c++)
            {
                clients[c].Id = list1[count];
                clients[c].Pass_num = list1[count + 1];
                clients[c].Payment = list1[count + 2];
                count += 3;
            }
            for (int l = 0; l < clients.Count; l++)
            {
                clients[l].getInfo();
            }
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                Console.WriteLine("Nomer kotoroqo Xotite perezapisat dannie:");
                int n = int.Parse(Console.ReadLine());

                sw.Write(clients[n - 1].Id = Console.ReadLine());
                sw.Write(clients[n - 1].Pass_num = Console.ReadLine());
                sw.Write(clients[n - 1].Payment = Console.ReadLine());
                for (int k = 0; k < clients.Count; k++)
                {
                    clients[k].getInfo();
                }
            }
            Console.ReadKey();
        }
    }
}