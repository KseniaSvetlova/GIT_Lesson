Console.WriteLine("Исходный массив:");
string[] people ={ "Tom", "Sammy", "Bob"};
Console.WriteLine(string.Join("; ", people));
string[] resultArr = people.Where(x=>x.Length < 4).ToArray();
Console.WriteLine(string.Join("; ", resultArr));
