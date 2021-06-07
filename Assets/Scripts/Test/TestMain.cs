using System;
using System.Collections.Generic;

namespace Game.Test {
    public class TestMain {
        public static void Main() {
            string description = "11\n22";
            Console.WriteLine(description);
            List<string> list = new List<string>(description?.Split('\n'));
            Console.WriteLine(list);
            // foreach (string s in description?.Split('\n')) {
            //     Console.WriteLine(s);
            // }
        }
    }
}