// Signature file for parser generated by fsyacc
module Parser
type token = 
  | LPAREN
  | RPAREN
  | LBRACKET
  | RBRACKET
  | EOF
  | ASC
  | DESC
  | NOT
  | NULL
  | CAST
  | AS
  | BETWEEN
  | SET
  | WITH
  | SELECT
  | FROM
  | WHERE
  | ORDER
  | BY
  | TOP
  | COUNT
  | DISTINCT
  | JOIN
  | INNER
  | LEFT
  | RIGHT
  | ON
  | CROSS
  | APPLY
  | OUTER
  | EQ
  | LT
  | LE
  | GT
  | GE
  | MUL
  | SUB
  | DIV
  | MOD
  | STAR
  | ADD
  | POW
  | LIKE
  | ESCAPE
  | COMMA
  | DOT
  | AND
  | OR
  | FLOAT of (float)
  | INT of (int)
  | ID of (string)
type tokenId = 
    | TOKEN_LPAREN
    | TOKEN_RPAREN
    | TOKEN_LBRACKET
    | TOKEN_RBRACKET
    | TOKEN_EOF
    | TOKEN_ASC
    | TOKEN_DESC
    | TOKEN_NOT
    | TOKEN_NULL
    | TOKEN_CAST
    | TOKEN_AS
    | TOKEN_BETWEEN
    | TOKEN_SET
    | TOKEN_WITH
    | TOKEN_SELECT
    | TOKEN_FROM
    | TOKEN_WHERE
    | TOKEN_ORDER
    | TOKEN_BY
    | TOKEN_TOP
    | TOKEN_COUNT
    | TOKEN_DISTINCT
    | TOKEN_JOIN
    | TOKEN_INNER
    | TOKEN_LEFT
    | TOKEN_RIGHT
    | TOKEN_ON
    | TOKEN_CROSS
    | TOKEN_APPLY
    | TOKEN_OUTER
    | TOKEN_EQ
    | TOKEN_LT
    | TOKEN_LE
    | TOKEN_GT
    | TOKEN_GE
    | TOKEN_MUL
    | TOKEN_SUB
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_STAR
    | TOKEN_ADD
    | TOKEN_POW
    | TOKEN_LIKE
    | TOKEN_ESCAPE
    | TOKEN_COMMA
    | TOKEN_DOT
    | TOKEN_AND
    | TOKEN_OR
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_ID
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_query
    | NONTERM_subquery
    | NONTERM_optTopDistinct
    | NONTERM_columnList
    | NONTERM_column
    | NONTERM_expressionChain
    | NONTERM_expression
    | NONTERM_joinList
    | NONTERM_joinClause
    | NONTERM_joinTable
    | NONTERM_joinOnClause
    | NONTERM_whereClause
    | NONTERM_op
    | NONTERM_value
    | NONTERM_orderByClause
    | NONTERM_orderByList
    | NONTERM_orderBy
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (HumaneOrm.Sql.SqlStatement) 
