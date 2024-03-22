// 1. Kalkulyator:
Console.Write("Birinchi son: ");
decimal binichiSon = Convert.ToDecimal(Console.ReadLine());
Console.Write("Amal(+,-,*,/): ");
char amal = Convert.ToChar(Console.ReadLine());
Console.Write("Ikkinchi son: ");
decimal ikkinchiSon = Convert.ToDecimal(Console.ReadLine());
decimal result = 0;
if(amal == '+')
{
    result = binichiSon + ikkinchiSon;
}else if(amal == '-')
{
    result = binichiSon - ikkinchiSon;
}else if(amal == '*')
{
    result = binichiSon * ikkinchiSon;
}else if(amal == '/')
{
    result = binichiSon / ikkinchiSon;
}
Console.WriteLine("Natija: " + result);
//---------------------------------------------------------------
// 2. Raqamlar qatorining yig‘indisini hisoblash:
Console.Write("N: ");
int N = Convert.ToInt32(Console.ReadLine());
int son = 0;
if(N > 0)
{
    for(int i=1; i<=N; i++)
    {
        son += i;
    }
}
System.Console.WriteLine(son);
//--------------------------------------------------------
// 3.  Paritet tekshiruvi:
Console.Write("Son: ");
int son1 = Convert.ToInt32(Console.ReadLine());
if((son1 % 2) == 0)
{    
    System.Console.WriteLine("Juft");
}else
{
    System.Console.WriteLine("Toq");
}

