namespace PascalCompiler.Enums
{
    public enum TokenType
    {
        EOF,
        Integer,
        Double,
        Char,
        String,
        Identifier,
        Keyword,
        Operator,
        Separator,
        Comment,
    }

    public enum Token
    {
        EOF = 1,

        COMMENT,
        IDENTIFIER,
        WRITE,
        WRITELN,
        L_CHAR,             // literal char
        L_STRING,           // literal string
        L_INTEGER,          // literal integer
        L_DOUBLE,           // literal double

        operator_begin,
        ASSIGN,
        ADD,
        SUB,
        MUL,
        O_DIV,              // operator DIV - /
        ADD_ASSIGN,
        SUB_ASSIGN,
        MUL_ASSIGN,
        DIV_ASSIGN,
        MOD_ASSIGN,

        EQUAL,
        LESS,
        MORE,
        NOT_EQUAL,
        LESS_EQUAL,
        MORE_EQUAL,

        O_SHL,              // operator SHL - <<
        O_SHR,              // operator SHR - >>
        operator_end,

        separator_begin,
        LPAREN,
        RPAREN,
        LBRACK,
        RBRACK,

        COMMA,
        DOT,
        ELLIPSIS,
        SEMICOLOM,
        COLON,
        separator_end,

        keyword_begin,
        AND,
        ARRAY,
        AS,
        ASM,
        BEGIN,
        BREAK,
        CASE,
        CLASS,
        CONST,
        CONSTRUCTOR,
        CONTINUE,
        DESTRUCTOR,
        DEC,
        DIV,
        DISPOSE,
        DO,
        DOWNTO,
        ELSE,
        END,
        EXCEPT,
        EXIT,
        EXPORTS,
        FALSE,
        FILE,
        FINALIZATION,
        FINALLY,
        FLOAT,
        FOR,
        FUNCTION,
        GOTO,
        IF,
        IMPLEMENTATION,
        IN,
        INC,
        INLINE,
        INHERITED,
        INITIALIZATION,
        INTERFACE,
        IS,
        LABEL,
        LIBRARY,
        MOD,
        NEW,
        NIL,
        NOT,
        OBJECT,
        OF,
        ON,
        OPERATOR,
        OR,
        OUT,
        PACKED,
        PROCEDURE,
        PROGRAM,
        PROPERTY,
        RAISE,
        REAL,
        RECORD,
        REPEAT,
        SELF,
        SET,
        SHL,
        SHR,
        STRING,
        THEN,
        THREADVAR,
        TO,
        TRUE,
        TRY,
        TYPE,
        UNIT,
        UNTIL,
        USES,
        VAR,
        WHILE,
        WITH,
        XOR,
        keyword_end,
    }
}