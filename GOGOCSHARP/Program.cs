using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Threading.Tasks;

namespace GOGOCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("test.txt");
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(input));
            var lexer = new MiniJavaGramLexer(new AntlrInputStream(ms));
            var tokens = new CommonTokenStream(lexer);

          //  tokens.Fill();

          /*  foreach(var tok in tokens.GetTokens())
            {
                Console.WriteLine(tok);
            }*/
            var parser = new MiniJavaGramParser(tokens);
            var tree = parser.prog();
            var pastwk = new ParseTreeWalker();
            pastwk.Walk(new MiniJavaGramBaseListener(), tree);
            Console.ReadLine();
        }
    }
}
