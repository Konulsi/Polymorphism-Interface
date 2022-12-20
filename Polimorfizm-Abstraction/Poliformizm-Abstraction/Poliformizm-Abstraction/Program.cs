

#region Calculation
using Poliformizm_Abstraction.Services;
using Poliformizm_Abstraction.Services.Interfaces;

//1) Calculator proqrami duzeltmek ( ancaq toplama, vurma, bolme, cixma emelleri olacaq).
//Service folderi olacaq. Qeyd : Calculation classi, ICalculation interface,  Calculate methodunuz olacaq.
//Bunlardan istifade edib projecti yazin.

//Calculate();
static void Calculate()
{
    ICalculation calculation = new Calculation();

    Console.WriteLine("Birinci reqemi daxil edin");

Number1: string strNum1 = Console.ReadLine();
    double checkedNum1;
    bool isParseNum1 = double.TryParse(strNum1, out checkedNum1);

    if (!isParseNum1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        Console.ResetColor();
        goto Number1;
    }


    Console.WriteLine("Operator daxil edin");
    string operation = Console.ReadLine();


    Console.WriteLine("ikinci reqemi daxil edin");
Number2: string strNum2 = Console.ReadLine();
    double checkedNum2;
    bool isParseNum2 = double.TryParse(strNum2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        Console.ResetColor();
        goto Number2;
    }

    if (checkedNum2 == 0 && operation == "/")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sifira bolmek olmur");
        Console.ResetColor();
        goto Number2;

    }

    var result = calculation.Calculate(checkedNum1, checkedNum2, operation);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Result =" + result);
    Console.ResetColor();
}

#endregion


#region Login
//2) Login mentiqini service ve interface ile yazmaq. 
//  (IAccountService, AccountService isdifade etmekle).


IAccountService accountService = new AccountService();

accountService.Login("Konul123", "Konul1996");



#endregion
