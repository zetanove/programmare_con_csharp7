using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;

namespace CompilationSample
{
    class Program
    {
        private const string code = @"class Program
                    {
                        static void Main(string[] args)
                        {
                            System.Console.WriteLine(""Hello, Matilda!"");
                        }
                    }";

        static void Main(string[] args)
        {
            CompileCode();
        }

        private static void CompileCode()
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

            using (var ms = new MemoryStream())
            {
                EmitResult result = compilation.Emit(ms);

                if (!result.Success)
                {
                    IEnumerable<Diagnostic> failures = result.Diagnostics.Where(diagnostic =>
                        diagnostic.IsWarningAsError ||
                        diagnostic.Severity == DiagnosticSeverity.Error);

                    foreach (Diagnostic diagnostic in failures)
                    {
                        Console.Error.WriteLine("{0}: {1}", diagnostic.Id, diagnostic.GetMessage());
                    }
                }
                else
                {
                    using (var file = File.Create( $"{compilation.AssemblyName}.exe"))
                    {
                        ms.WriteTo(file);
                    }
                    //ms.Seek(0, SeekOrigin.Begin);
                    //Assembly assembly = Assembly.Load(ms.ToArray());
                }
            }
        }
    }
}
