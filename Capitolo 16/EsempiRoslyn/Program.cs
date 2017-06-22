using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Immutable;

namespace EsempiRoslyn
{
    class Program
    {
        static CSharpParseOptions options;
        static void Main(string[] args)
        {
            EvaluateExpr();
            Console.ReadLine();
            RunScript();
            Console.ReadLine();
            CreateSCript();
            Console.ReadLine();
            ChainScript();
            Console.ReadLine();
            UseScriptOptions();
            Console.ReadLine();
            ReplAsync();
            Console.ReadLine();
        }

        public static async void EvaluateExpr()
        {
            var result = await CSharpScript.EvaluateAsync("1+2");
            Console.WriteLine(result);

            double d = await CSharpScript.EvaluateAsync<double>("5/(3-1)*3.5");
            Console.WriteLine(d);

            var str = await CSharpScript.EvaluateAsync(@"""risultato: ""+5/2");
            Console.WriteLine(str);

            var sum = await CSharpScript.EvaluateAsync("int x=1; int y=2; int z=x+y; z");
            Console.WriteLine(sum);

            try
            {
                await CSharpScript.EvaluateAsync("1+a");
            }
            catch (CompilationErrorException e)
            {
                Console.WriteLine(string.Join(Environment.NewLine, e.Diagnostics));
            }
        }

        public static async void RunScript()
        {
            var state = await CSharpScript.RunAsync("int x=0;int y=x+1; y");
            ScriptVariable y = state.Variables.First(sv => sv.Name == "y");
            var returnVal = state.ReturnValue;



        }

        private static async void CreateSCript()
        {
            var script = CSharpScript.Create("int x=2;int y=x*x; y");
            Console.WriteLine(script.Code);
            var errors = script.Build();
            Compilation compilation = script.GetCompilation();
            var result = await script.RunAsync();
        }

        public async static void ChainScript()
        {
            var script = CSharpScript.Create("int x=1;")
                .ContinueWith("int y=2;")
                .ContinueWith("int z=x+y;")
                .ContinueWith("z");

            var result = await script.RunAsync();
            Console.WriteLine(result.ReturnValue);

            var state = await CSharpScript.RunAsync("int x=1;");
            Console.WriteLine(state.Variables[0]);
            state = await state.ContinueWithAsync("int y=2;");
            state = await state.ContinueWithAsync("int z=x+y;");
            state = await state.ContinueWithAsync("z");
            var z = state.ReturnValue;

            Console.WriteLine(z);


        }

        public static async void UseScriptOptions()
        {
            ScriptOptions scriptOptions = ScriptOptions.Default;

            var systemCore = typeof(System.Linq.Enumerable).Assembly;
            //Aggiunge riferimento
            scriptOptions = scriptOptions.AddReferences(systemCore);
            //Aggiunge namespaces
            scriptOptions = scriptOptions.AddImports("System");
            scriptOptions = scriptOptions.AddImports("System.Linq");
            scriptOptions = scriptOptions.AddImports("System.Collections.Generic");

            var state = await CSharpScript.RunAsync(@"var list = new List<int>(){1,2,3,4,5};", scriptOptions);
            state = await state.ContinueWithAsync("var sum = list.Sum();");
            var sum = state.Variables.FirstOrDefault(v => v.Name == "sum");
            Console.WriteLine(sum.Value);
        }


        private static async void ReplAsync()
        {
            options = new CSharpParseOptions(LanguageVersion.CSharp6,
                            DocumentationMode.Parse,
                            SourceCodeKind.Script,
                            null);

            Script<object> script = CSharpScript.Create(string.Empty);
            Console.Write("C# 6 REPL (inserisci :q per uscire)");
            while (true)
            {
                Console.Write("> ");
                var code = Console.ReadLine();

                var newScript = script.ContinueWith(code);

                ScriptState<object> result = null;
                try
                {
                    bool isComplete = IsCompleteSubmission(code);

                    if (code == ":q")
                    {
                        break;
                    }
                    else if (!isComplete)
                    {
                        Console.WriteLine("Istruzione incompleta");
                    }
                    else
                    {
                        result = await newScript.RunAsync();
                        script = newScript;
                    }
                }
                catch (Exception ex)
                {
                    var error = ex.ToString();
                    WriteError(error);
                }

                if (result != null && result.ReturnValue != null)
                    Console.WriteLine(result.ReturnValue);
            }
        }

        private static void WriteError(string error)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = color;
        }

        private static bool IsCompleteSubmission(string code)
        {
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(code, options: options);
            return SyntaxFactory.IsCompleteSubmission(syntaxTree);
        }
    }
}
