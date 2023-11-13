using ExcelDna.Integration;

namespace mateaddin
{
    public static class Functions
    {
        [ExcelFunction(Description = "My first .NET function")]
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
    }
}