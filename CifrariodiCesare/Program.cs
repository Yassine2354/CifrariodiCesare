int k, ascii;
string p;
char c;
string pC = "";

Console.WriteLine("Inserisci la frase");
p = Console.ReadLine();

Console.WriteLine("Inserisci la Chiave del Cifrario");
k = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < p.Length; i++)
{
    c = p[i];
    ascii = (int)c;
    if (ascii != 44 && ascii != 46 && ascii != 32)
    {
        if ((ascii + k) > 122)
        {
            ascii = (ascii + k) - 28;
        }
        ascii += k;

        c = (char)ascii;
    }
    pC = pC + c;
}

Console.WriteLine(pC);