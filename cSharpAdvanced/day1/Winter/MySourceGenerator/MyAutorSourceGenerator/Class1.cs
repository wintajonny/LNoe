using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyAutorSourceGenerator
{


    [Generator]
    public class Author : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            StringBuilder sourceBuilder = new(@"
using System;
namespace CodeGenerator
{
    public static class PrintAuthor
    {
        public static void Print()
        {
            Console.WriteLine(""Hello from generated Code!"");
            Console.WriteLine(""Author: Thomas Winter"");
            Console.WriteLine(""Last Updated: 2021/05/31"");
            Console.WriteLine(""Repo: https://github.com/wintajonny"");
");

            IEnumerable<SyntaxTree> syntaxTrees = context.Compilation.SyntaxTrees;

            foreach(SyntaxTree tree in syntaxTrees)
            {
                sourceBuilder.AppendLine($@"Console.WriteLine(@""source file: {tree.FilePath}"");");
            }

            sourceBuilder.Append(@"
        }
    }
}");
            context.AddSource("Author:", SourceText.From(sourceBuilder.ToString(), Encoding.UTF8));

        }

        public void Initialize(GeneratorInitializationContext context)
        {

        }
    }
}
