
float operandoUno = 1;
float operandoDue = 1;
float risultato = 0;
char operatore = ' ';

Console.Write("Inserisci operando uno: ");
operandoUno = Convert.ToSingle(Console.ReadLine());
Console.Write("Inserisci operando due: ");
operandoDue = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Scegli operatore tra +; -; *; /");
operatore = Convert.ToChar(Console.ReadLine());

if (operandoDue == 0 && operatore == '/')
{
    Console.WriteLine("Non si può dividere per 0");
    return;
}

switch (operatore)
{
    case '+':
        risultato = operandoUno + operandoDue;
        break;
    case '-':
        risultato = operandoUno - operandoDue;
        break;
    case '*':
        risultato = operandoUno * operandoDue;
        break;
    case '/':
        risultato = operandoUno / operandoDue;
        break;
}

Console.WriteLine($"Risultato dell'operazione: {risultato}");
