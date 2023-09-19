namespace SubjectsByNameSpace
{
    namespace SetAndGetMethods
    {
        public class ClassForTest
        {
            private string? _privateField;
            public string? privateField
            {
                get { return _privateField; }
                set
                {
                    Console.Write("Making Some security cheking");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    Thread.Sleep(200);
                    Console.Write(".");
                    if (value is null)
                        throw new Exception($"Null values not allowed");
                    if (value.Length > 10)
                        throw new Exception($"Wrong string size");
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Well Done, the size of the string is right!");
                        Console.WriteLine($">>{nameof(_privateField)} = {value};");
                        _privateField = value;
                    }

                }
            }
        }
    }
    namespace sizeOfVariableTypes
    {
        public class exe
        {
            public static void VariableTypeSize()
            {
                WriteLine(new string('-', 100));
                WriteLine("{0,-10}{1,-25}{2,15}{3,30}", "Type", "Byte(s) in memory", "Min", "Max");
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "long",sizeof(long), long.MinValue, long.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "byte",sizeof(byte), byte.MinValue, byte.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "short", sizeof(short), short.MinValue, short.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "int", sizeof(int), int.MinValue, int.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "long", sizeof(long), long.MinValue, long.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "float", sizeof(float), float.MinValue, float.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "double", sizeof(double), double.MinValue, double.MaxValue);
                WriteLine("{0,-10}{1,1}{2,39}{3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
                WriteLine(new string('-', 100));
                WriteLine(System.Half.MaxValue);

            }
        }

    }
}
