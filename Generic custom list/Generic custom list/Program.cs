using System.Collections.Generic;
using Generic_custom_list;
CustomList<int> list = new(3);
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

Console.WriteLine(list.FindAll(item => item > 2));
//list.Find();
//Console.WriteLine(list.Contains(0));

//Console.WriteLine(list.Exists(item => item >= 6));

//Console.WriteLine(list.Remove(1));

//Console.WriteLine(list.Remove(0));

//Console.WriteLine(list.Find(item => item == 0));

List<int> listt = new();
listt.Add(1);
listt.Add(2);
list.Add(3);

//Console.WriteLine(listt.FindAll(item => item > 1));