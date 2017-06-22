using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;

namespace CodeAnalysisTool
{
    class CatchSyntaxRewriter: CSharpSyntaxRewriter
    {

        public override SyntaxNode VisitCatchClause(CatchClauseSyntax node)
        {
            if(!node.DescendantNodes().OfType<ThrowStatementSyntax>().Any())
            {
                BlockSyntax block = node.DescendantNodes().OfType<BlockSyntax>().Single();
                if (!block.Statements.Any())
                {
                    block = SyntaxFactory.Block(new StatementSyntax[] { SyntaxFactory.ThrowStatement() });             
                    
                    node = node.WithBlock(block);
                    return node;
                }
            }
            return base.VisitCatchClause(node);
        }  
    }
}
