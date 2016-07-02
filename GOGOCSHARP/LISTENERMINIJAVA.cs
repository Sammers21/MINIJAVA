using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOGOCSHARP
{
    class LISTENERMINIJAVA : MiniJavaGramBaseListener
    {
        string res = "";

        public override void EnterProg([NotNull] MiniJavaGramParser.ProgContext context)
        {
            res += "class " + context.ID().GetText() + " {\n";
            Console.WriteLine(res+"\n\n\n");
        }



    }
}
