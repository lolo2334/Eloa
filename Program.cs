bool t, p, r, w;

Console.WriteLine("--- Simulador de luz de Advergência...: ");

Console.Write("sensor de températura...: ");

string sensorT = Console.ReadLine()!.ToUpper();
t = (sensorT == "A");

Console.Write("sensor de pressão...: ");
string sensorP = Console.ReadLine()!.ToUpper();
p = (sensorT == "A");

Console.Write("sensor de rotação...: ");
string sensorR = Console.ReadLine()!.ToUpper();
r = (sensorT == "A");

w = t && (p || !r);

string resultado;

if (w)
{
    resultado = "ATIVADA";
}
resultado = w ? "ATIVADA" : "DESATIVADA";

Console.WriteLine($"\nA luz de advertência estará {resultado}.");

