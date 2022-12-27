using PascalCompiler.SyntaxAnalyzer.Nodes;

namespace PascalCompiler.Semantics
{
    public class SymVar : Symbol
    {
        public SymVar(string ident, SymType type) : base(ident)
        {
            Type = type;
        }

        public SymType Type { get; set; }

        public override string ToString()
        {
            return $"name: {Name}\ttype: {Type}";
        }
    }

    public class SymConstant : SymVar
    {
        public SymConstant(string ident, SymType type) : base(ident, type)
        {
        }
    }

    public class SymParameter : SymVar
    {
        public SymParameter(string ident, SymType type, string modifier = "") : base(ident, type)
        {
            Modifier = modifier;
        }

        public string Modifier { get; }
    }

    public class SymProc : Symbol
    {
        public SymProc(string ident, SymTable @params, SymTable locals) : base(ident)
        {
            Params = @params;
            Locals = locals;
        }

        public SymTable Params { get; }
        public SymTable Locals { get; }
        public StmtNode? Block { get; set; }
        public bool IsForward { get; set; }
    }

    public class SymFunc : SymProc
    {
        public SymFunc(string ident, SymTable @params, SymTable locals, SymType type)
        : base(ident, @params, locals)
        {
            ReturnType = type;
        }

        public SymType ReturnType { get; set; }
    }
}