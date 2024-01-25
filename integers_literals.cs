// Числовые (целые числа), символьные и строковые константы (литералы) с поддержкой всех видов констант и служебных последовательностей символов


int num1 = 10;
int num2 = -5;
int num3 = 0xFF; // Hexadecimal number
int num4 = 0b1010; // binary number
int num5 = 1_000_000; // using underlining to improve readability
long longConstant = 1234567890123456789L;// Long integer

char char1 = 'A';
char char2 = '\n'; // newline character
char char3 = '\u0058'; // character 'X' in hexadecimal format
char char4 = '\\'; // backslash character

string str1 = "Hello, World!";
string str2 = "This is a \"quoted\" string."; // use quote escaping
string str3 = @"C:\Program Files\"; // unescaped file path
string str4 = "First line\nSecond line"; // use newline character

string str5 = "This\tis\ta\ttab"; // tab
string str6 = "This\bis\ba\bbackspace"; // carriage return
string str7 = "This\ris\racarriage\rreturn"; // carriage return
string str8 = "This\fis\fa\fform\ffeed"; // page translation
string str9 = "This\vis\va\vvertical\vtab"; // vertical tab