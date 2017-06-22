using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.Formatting;
using System.IO;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;

namespace CodeAnalysisTool
{
    class Program
    {
        private const string code = @"using System;
                using System.Collections;
                using System.IO;
                using System.Text;

                namespace HelloWorld
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Console.WriteLine(""Hello, World!"");
                        }
                        
                        public int Method1(string str)
                        {
                            return 0;
                        }
                    }
                }";

        private const string codeTryCatch = @"using System;

                namespace HelloWorld
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            try
                            {
                                Console.WriteLine(""Hello, World!"");
                            }
                            catch
                            {
                            }
                        }
                    }
                }";

        public void test()
        {
            Console.Write("Hello Matilda");
        }

        static void Main(string[] args)
        {
            TreeAnalysis();

            SearchInTree();

            SyntaxWalk();

            SyntaxCreation();

            SyntaxTransform();

            SyntaxReplacer();
            
        }

        

        private static void SyntaxWalk()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText( code);
            MethodCollector collector = new MethodCollector();
            collector.Visit(tree.GetRoot());
            collector.methods.ForEach(m => Console.WriteLine(m));
        }

        private static void SyntaxReplacer()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(codeTryCatch);
            CatchSyntaxRewriter rewriter = new CatchSyntaxRewriter();
            var newRoot=rewriter.Visit(tree.GetRoot());
            Console.WriteLine(newRoot.ToFullString());
        }

        private static void SyntaxCreation()
        {
           
            var console = SyntaxFactory.IdentifierName("Console");
            var writeline = SyntaxFactory.IdentifierName("WriteLine");
            var memberaccess = SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, console, writeline);

            var argument = SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("Hello Matilda")));
            var argumentList = SyntaxFactory.SeparatedList(new[] { argument });

            var writeLineCall = SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(memberaccess,
                SyntaxFactory.ArgumentList(argumentList))
            );


            Console.WriteLine(writeLineCall.ToString());
        }

        private static void TreeAnalysis()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(
                            code);

            var root = (CompilationUnitSyntax)tree.GetRoot();

            foreach (var us in root.Usings)
            {
                Console.WriteLine(us.ToString());
            }

            var firstMember = root.Members[0];
            SyntaxKind kind = firstMember.Kind();

            var helloWorldDeclaration = (NamespaceDeclarationSyntax)firstMember;

            var programDeclaration = (ClassDeclarationSyntax)helloWorldDeclaration.Members[0];

            var mainDeclaration = (MethodDeclarationSyntax)programDeclaration.Members[0];

            var argsParameter = mainDeclaration.ParameterList.Parameters[0];


            Console.WriteLine($@"Il metodo {mainDeclaration.Identifier} ha il parametro {argsParameter.Identifier} di tipo {argsParameter.Type} e restituisce {mainDeclaration.ReturnType}");

        }

        private static void SearchInTree()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(
                            code);

            var root = (CompilationUnitSyntax)tree.GetRoot();

            var methods=root.DescendantNodes().OfType<MethodDeclarationSyntax>().Where(m => m.Identifier.Text.StartsWith("Method"));
            
            foreach(var method in methods)
                Console.WriteLine($"metodo {method.ToString()}");

        }

        private static void SyntaxTransform()
        {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
            CompilationUnitSyntax root = tree.GetRoot() as CompilationUnitSyntax;

            var classDeclaration = root.DescendantNodes().OfType<ClassDeclarationSyntax>().Single();
            var identifier = SyntaxFactory.Identifier("ProgramNew");
            var newClassDeclaration = classDeclaration.WithIdentifier(identifier);

            root = root.ReplaceNode(classDeclaration, newClassDeclaration);


            var console = SyntaxFactory.IdentifierName("Console");
            var writeline = SyntaxFactory.IdentifierName("WriteLine");
            var memberaccess = SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, console, writeline);

            var argument = SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal("Hello Matilda")));
            var argumentList = SyntaxFactory.SeparatedList(new[] { argument });

            var writeLineCall = SyntaxFactory.ExpressionStatement(
                SyntaxFactory.InvocationExpression(memberaccess,
                SyntaxFactory.ArgumentList(argumentList))
            );

           
            classDeclaration = root.DescendantNodes().OfType<ClassDeclarationSyntax>().Single();
            var last = classDeclaration.ChildNodes().Last();
            newClassDeclaration = classDeclaration.RemoveNode(last, SyntaxRemoveOptions.KeepEndOfLine);
            root = root.ReplaceNode(classDeclaration, newClassDeclaration);

            var lastStatement= root.DescendantNodes().OfType<StatementSyntax>().Last();            
            root = root.InsertNodesAfter(lastStatement, new SyntaxNode[] { writeLineCall });
            
            Console.WriteLine(root.GetText());
        }
    }
}
