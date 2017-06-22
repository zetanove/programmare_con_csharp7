using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeAnalysisTool
{
    class MethodCollector: CSharpSyntaxWalker
    {
        public readonly List<MethodDeclarationSyntax> methods = new List<MethodDeclarationSyntax>();
        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Modifiers.Any(m => m.Kind() == SyntaxKind.PublicKeyword))
                methods.Add(node);
        }
    }
}
