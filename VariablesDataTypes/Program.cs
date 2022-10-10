Console.WriteLine("");

/*
 * # TAMSAYI VERİ TİPLERİ
 * byte: 0 / 255                                                    > (1 Byte)
 * sbyte: -128 / 127                                                > (1 Byte)
 * 
 * short: -32.768 / 32.767                                          > (2 Byte)
 * ushort: 0 / 65.535                                               > (2 Byte)
 * 
 * int: -2.147.483.648 / 2.147.483.647                              > (4 Byte)
 * uint: 0 / 4.294.967.295                                          > (4 Byte)
 * 
 * long: 9.223.372.036.854.775.808 / 9.223.372.036.854.775.807      > (8 Byte)
 * ulong: 0 / 18.446.744.073.709.551.615                            > (8 Byte)
 * 
 * # ONDALIKLI SAYI VERİ TİPLERİ
 * float: 1.5E-45 / 3.4E+38                                         > (4 Byte)
 * double: 5E-324 / 1.7E+308                                        > (8 Byte)
 * decimal: 1E-28 / 7.9E+28                                         > (12 Byte)
 * 
 * # METİNSEL VERİ TİPLERİ
 * string: Tek bir karakter, sözcük veya cümle gibi değerlerin saklanmasında kullanılır.
 * char : Bütün unicode karakterleri kapsar.                        > (2 Byte)
 * 
 * # MANTIKSAL VERİ TİPİ
 * bool: true / false                                               > (1 Bit)
 * */

byte m_byte = 5;
sbyte m_sbyte = 5;

short m_short = 5;
ushort m_ushort = 5;

int m_int = 5;
uint m_uint = 5;

long m_long = 5;
ulong m_ulong = 5;

float m_float = 5f;
double m_double = 5;
decimal m_decimal = 5m;

string m_string = "Gökhan";
char m_char = 'G';
bool m_bool = true;

// DateTime blablabla..
DateTime m_dateTime = DateTime.Now;
string m_dateTimeCustom = DateTime.Now.ToString("dd MMMM yyyy - hh:mm:ss");
Console.WriteLine(m_dateTime);
Console.WriteLine(m_dateTimeCustom);

// Object blablabla..
object o1 = "x";
object o2 = 5;
object o3 = 2.5;

// String blablabla..
string nickName = String.Empty;
nickName = "c0deMach1ne";
string firstName = "Gökhan";
string lastName = "Zengin";
string firstLastName = $"{firstName} {lastName}";
Console.WriteLine(firstLastName);

// Int blablabla..
int number1 = 10;
int number2 = 5;
int sum = number1 + number2;
Console.WriteLine(sum);

// Bool blablabla..
bool m_isTrue = 10 < 5;
Console.WriteLine(m_isTrue ? "Küçüktür" : "Küçük Değildir");

// Convert & Parse blablabla..
string m_year = "2022";
int m_age = 30;
int m_convertValue = Convert.ToInt32(m_year) - m_age;
Console.WriteLine(m_convertValue);

string m_birthDate = "1992";
int m_parseInt = int.Parse(m_birthDate);
int m_parseValue = m_parseInt + 30;
Console.WriteLine(m_parseValue);

Console.ReadLine();