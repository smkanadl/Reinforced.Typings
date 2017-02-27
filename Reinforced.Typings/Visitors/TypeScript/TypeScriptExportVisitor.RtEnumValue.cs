using Reinforced.Typings.Ast;

namespace Reinforced.Typings.Visitors.TypeScript
{
    partial class TypeScriptExportVisitor
    {
        public override void Visit(RtEnumValue node)
        {
            if (node == null) return;
            Visit(node.Documentation);
            AppendTabs();
            Write(node.EnumValueName);
            if (!string.IsNullOrEmpty(node.EnumValue))
            {
                Write(" = ");
                Write(node.EnumValue);
            }
            WriteLine(", ");
        }
    }
}