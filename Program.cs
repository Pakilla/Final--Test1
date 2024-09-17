string [] Strings = {"hello", "2", "world", ":-)", "1234", "1567", "Denmark", "New York", "-2", "OMG", "Wow"};
System.Console.WriteLine(string.Join(" ", Strings));
string[] NewStrings = new string [Strings.Length];
int i = 0;
foreach(string a in Strings)
{
    
    if (a.Length <= 3)
    {
       NewStrings[i] = a;
       i = i + 1;
    }
}
System.Console.WriteLine(string.Join(" ", NewStrings));