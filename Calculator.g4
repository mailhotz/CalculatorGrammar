grammar Calculator;
equation : (NUMBERS OPERATOR NUMBERS);
OPERATOR : '+'|'-'|'*'|'/';
NUMBERS : [0-9]+;
WS : [ \t\r\n]+ -> skip ;