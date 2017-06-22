using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace SemanticAnalysis
{
    class Program
    {
        private const string code = @"using System;
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine(""Hello, Matilda!"");
                        }
                    }";

        static void Main(string[] args)
        {
            SemanticAnalysis();
        }

        private static void SemanticAnalysis()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            SyntaxTree[] sourceTrees = { tree };

            MetadataReference mscorlib =
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location);
            MetadataReference systemLinq =
                   MetadataReference.CreateFromFile(typeof(System.Linq.Enumerable).Assembly.Location);

            MetadataReference[] references = { mscorlib, systemLinq };

            CSharpCompilation compilation = CSharpCompilation.Create("RoslynCS",
                                            sourceTrees,
                                            references,
                                            new CSharpCompilationOptions(OutputKind.ConsoleApplication));


            var model = compilation.GetSemanticModel(tree);

            var methodMainSyntax = tree.GetRoot().DescendantNodes().OfType<MethodDeclarationSyntax>().First(m => m.Identifier.Text == "Main");
            var methodMainSymbol = model.GetDeclaredSymbol(methodMainSyntax);

            Console.WriteLine($"Informazioni semantiche su {methodMainSymbol.Name}");
            Console.WriteLine($"tipo contenitore: {methodMainSymbol.ContainingType}");
            Console.WriteLine($"tipo di ritorno: {methodMainSymbol.ReturnType}");
            Console.WriteLine($"static: {methodMainSymbol.IsStatic}");
            Console.WriteLine("parametri:");
            foreach(var par in methodMainSymbol.Parameters)
                Console.WriteLine($"{par.Type} {par.Name}");

            var helloMatildaString = tree.GetRoot().DescendantNodes()
                                       .OfType<LiteralExpressionSyntax>()
                                       .First();

            var typeInfo = model.GetTypeInfo(helloMatildaString);
            ITypeSymbol typeSymbol = typeInfo.Type;
            Console.WriteLine($"il tipo di {helloMatildaString} è {typeSymbol.Name}");

            var staticMethods=typeSymbol.GetMembers().Where(m => m.Kind == SymbolKind.Method && m.IsStatic).Select(m=>m.Name).Distinct();
            staticMethods.ToList().ForEach(name => Console.WriteLine(name));

        }
        
    }
}
