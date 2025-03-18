//esercizio A
using System.Security.Cryptography.X509Certificates;

Random rnd = new Random();

int[,] inserimento_temperature(int[,] temp)
{
    
    for (int i = 0; i <temp.GetLength(0); i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp[i, j] = rnd.Next(-10, 36);
            }           
        }
    }
    return temp;
}
void stampaMatrice(int[,] temp)
{
    for (int i = 0;i < temp.GetLength(0); i++)
    {
        for (int j = 0;j <temp.GetLength(1); j++)
        {
            Console.Write( "{ " + temp[i, j]  + " }");
        }
        Console.WriteLine();
    }
}
int[,] temp = new int[2, 12];
inserimento_temperature(temp);
stampaMatrice(temp);
//esercizio B
int[,] media_progressiva(int[,] temp)
{
    float somma = 0, media = 0;
    int  k=-1;

    for (int i = 0; i<temp.GetLength(0) ; i++) 
    {
        for (int j = 0; j<temp.GetLength(1) ; j++)
        {
            if (k<j)
            {
                somma += temp[i, j];
                
                media = somma / (j+1);
                if(somma%k != 0)
                {
                    temp[i, j] = (int) media;
                }
                else
                {
                    temp[i, j] = (int) media + 1;
                }
                
            }
            k++;
        }
    }
    return temp;
}
int temperatura_massima(int[,] temp)
{
    int max = -11;
    for (int i = 0; i < temp.GetLength(0) ; i++)
    {
        for (int j = 0;j<temp.GetLength(1); j++)
        {
            if (temp[i, j] > max) { max = temp[i, j]; }
        }
    }
    return max;
}
media_progressiva(temp);
stampaMatrice(temp);

Console.WriteLine("la temperatura massima è: " + temperatura_massima(temp));
//esercizio C
string s = "ILMATNOHRBC";
string completamento(string s)
{
    s = s.Trim();
    char[] alfabeto = { 'A', 'B' , 'C' , 'D'  ,'E', 'F',  'G' , 'H' , 'I',  'J' , 'K',  'L',  'M',  'N',  'O',  'P',  'Q',  'R',  'S' ,'T', 'U', 'V',  'W' , 'X',  'Y',  'Z' 
    };
    string mancanti = " ";
    for (int i = 0; i < alfabeto.Length; i++)
    {
        if(alfabeto[i] != s[i])
        {
            mancanti += alfabeto[i];
            s += mancanti;

        }
    }
    return s;
}
Console.WriteLine(completamento(s));
//esercizio D
bool tutte_uguali(char[] cifrario)
{
    for (int i = 0;i < cifrario.Length; i++)
    {
        cifrario[i] = (char) rnd.Next(0, 10);
        
        
    }
    for (int i = 0; i< cifrario.Length; i++)
    {
        if (i != 0)
        {
            if (cifrario[i] == cifrario[i - 1])
            {
                return false;
            }
        }
        
    }
    return true;
}
char[] cifrario = new char[9];
Console.WriteLine(tutte_uguali(cifrario));