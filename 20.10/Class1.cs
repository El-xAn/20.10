using System;
using System.Collections.Generic;
using System.Text;

namespace _20._10
{
    class client
    {
        public string Id { get; set; }
        public string Pass_num { get; set; }
        public string Payment { get; set; }
        public client() { }
        public void getInfo()
        {
            Console.WriteLine($"ID: {Id}, passport number: {Pass_num}, payment: {Payment}");
        }
    }
}