using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_VFace.Classes
{
    static class generatore
    {
        private static char[] tab = { 'A', '1', 'C', '4', '3', 'F', '6', '7', '8', 'B', '0', '9', '2', 'D', 'E', '5' };
        static String calcChecksum(String s)
        {
            int num = 86;
            int num1 = 175;
            for (int i = 0; i < s.Length; i++)
            {
                num1 += s[i] & 0xff;
                if (num1 > 255)
                    num1 -= 255;
                num += num1;
                if (num > 255)
                    num -= 255;

            }
            num = (num << 8) + num1;
            s = "" + tab[num & 15] + tab[(num >> 4) & 15];
            return s;
        }

        public static String createPwd(String name)
        {
            name = (name.ToUpper());
            return name + calcChecksum(name);
        }

        /*
        public static void main(String[] args)
        {
            Scanner reader = new Scanner(System.in);
            System.out.println("Inserisci 7 caratteri:");
            String codice = reader.nextLine();
            System.out.println("Seriale:");
            System.out.println(createPwd(codice));
        }
        */
    }
}
class Scanner : System.IO.StringReader
{
    string currentWord;

    public Scanner(string source) : base(source)
    {
        readNextWord();
    }

    private void readNextWord()
    {
        System.Text.StringBuilder sb = new StringBuilder();
        char nextChar;
        int next;
        do
        {
            next = this.Read();
            if (next < 0)
                break;
            nextChar = (char)next;
            if (char.IsWhiteSpace(nextChar))
                break;
            sb.Append(nextChar);
        } while (true);
        while ((this.Peek() >= 0) && (char.IsWhiteSpace((char)this.Peek())))
            this.Read();
        if (sb.Length > 0)
            currentWord = sb.ToString();
        else
            currentWord = null;
    }

    public bool hasNextInt()
    {
        if (currentWord == null)
            return false;
        int dummy;
        return int.TryParse(currentWord, out dummy);
    }

    public int nextInt()
    {
        try
        {
            return int.Parse(currentWord);
        }
        finally
        {
            readNextWord();
        }
    }

    public bool hasNextDouble()
    {
        if (currentWord == null)
            return false;
        double dummy;
        return double.TryParse(currentWord, out dummy);
    }

    public double nextDouble()
    {
        try
        {
            return double.Parse(currentWord);
        }
        finally
        {
            readNextWord();
        }
    }

    public bool hasNext()
    {
        return currentWord != null;
    }
}