/*using SubjectsByNameSpace.SetAndGetMethods;

var x = new ClassForTest();
x.privateField = "12345678-1";
//x.privateField = null;
*/

/*string aux = new('_', count: 74);
Console.WriteLine(aux);*/

//Console.WriteLine("\television/Name");
//Console.WriteLine(@"\television/Name");

//funciona desde CSharp 11 en adelante
//string aux = """
//     <PropertyGroup>
//      <OutputType>Exe</OutputType>
//      <TargetFramework>net6.0</TargetFramework>
//      <ImplicitUsings>enable</ImplicitUsings>
//      <Nullable>enable</Nullable>
//    </PropertyGroup>
//    """;


//formating float numbers
//float f = 1.123123f;
//Console.WriteLine("{0:N4}{1}",f," Float type");

//int integer = 10;
//int binary = 0b_1010;
//Console.WriteLine($"{integer} |==?| {binary} =>{integer==binary}");

/*
using SubjectsByNameSpace.SetAndGetMethods;
//target-formated new
List<ClassForTest> list = new()
{
    new() { privateField = "1234567890"},
    new() { privateField = "1234567890" },
    new() { privateField = "1234567890" },
    new() { privateField = "1234567890-x" },
};*/

//Console.WriteLine("String default value: {0}", default(string));
//Console.WriteLine("Int default value: {0}", default(int));
//Console.WriteLine("Float default value: {0}", default(float));
//Console.WriteLine("Double default value: {0}", default(double));
//Console.WriteLine("DateTime default value: {0}", default(DateTime));

/*decimal price = 10.22M;
int numbersOf = 10;
Console.WriteLine($"{price*numbersOf:C}");*/

//currency
/*decimal price = 10.22M;
Console.WriteLine($"{price:C}");*/

/*
//string format
string apple = "apple";
int quantity = 1012312312;

Console.WriteLine("{0,-10}{1,-6}{2,6}", "Friut","<>","Count");
Console.WriteLine("1234567890------******");
//Console.WriteLine("{0,-10}{1,6:N0}", apple, quantity);*/

//using static System.Console;//importa un metodo estatico, si omitimos la palabra static estariamos
//tratando de importar un namespace
/*string aux;
aux = ReadLine()!;
WriteLine(aux);*/

//Geting key inpúts from the user
/*Write("Press any key convination\n");
ConsoleKeyInfo x = ReadKey();
WriteLine("\nKey: {0} Modifiers: {1}  keyChar: {2}",x.Key,x.Modifiers,x.KeyChar);*/

//asyng and await
/*HttpClient httpClient = new();
HttpResponseMessage response = await httpClient.GetAsync("https://www.google.com");
WriteLine("Google has {0:N0} bytes",response.Content.Headers.ContentLength);*/

//Subject: Raw string literal
//https://stackoverflow.com/questions/75256018/c-sharp-triple-double-quotes-three-double-quotes
//we have got to change the C# version in our .csproj file (double-click on project (beneath solution)
//WriteLine(""" This \nis \tfor scape "this" without no issue """);


//practicing part page 96
//1.- show compiler and language version
//WriteLine(Environment.Version);
//framework version but CSharp version?
//2.- two types of comments // and /**/
//3.- differences between verbatim and interpolated
//var @var = "hola mundo";
//WriteLine(@var);

//4.-Careful when you use float and double values
//WriteLine("\n");
//WriteLine(@"//4 Careful when you use float and double values");
//double d1 = 0.1;
//double d2 = 0.2;
//WriteLine(@"double d1 = 0.1;
//double d2 = 0.2;");
//WriteLine(@"WriteLine(d1 + d2 == 0.3);");
//WriteLine(d1 + d2 == 0.3);
//decimal dc1 = 0.1M;
//decimal dc2 = 0.2M;
//WriteLine(@"decimal dc1 = 0.1M;
//decimal dc2 = 0.2M;
//WriteLine(dc1 + dc2 == 0.3M);");
//WriteLine(dc1 + dc2 == 0.3M);
//WriteLine("\n");

////5.- determinig size of types
//WriteLine("Decimal format size: {0}", sizeof(decimal));
//WriteLine(@"//5 determinig size of types
//WriteLine(""Decimal variable type size: {0}"", sizeof(decimal));");

////6.- How do you right-align a format string?
//WriteLine("\n");
//WriteLine(@"//6.- How do you right-align a format string?
//WriteLine(""{0,-9}{1,9}"",Environment.CurrentDirectory,Environment.Version);");
//WriteLine("{0,-9}{1,9}", "Hello","World");
//WriteLine("12345...91...56789");
////Console.WriteLine("{0,-10}{1,-6}{2,6}", "Friut", "<>", "Count");

/*
 * to see charp version, just hover pointer over the expression
#error version
*/

//extra bonus excercice
SubjectsByNameSpace.sizeOfVariableTypes.exe.VariableTypeSize();
