class Program
{
    static CircularLinkedList<char> l1 = new CircularLinkedList<char>();
    
    static void Main(string[] args)
    {
        Cheak();
    }

    static void Cheak()
    {
        while (true)
        {
            char input = char.Parse(Console.ReadLine());
            if (input == 'J' || input == 'G' || input == 'O' || input == 'R')
            {
                Program.l1.Add(input);
            }
            else
            {
                break;
            }
        }
        for (int i = 0; i < Program.l1.GetLength(); i++)
        {   if (Program.l1.Get(i) == 'J' || Program.l1.Get(i) == 'G' || Program.l1.Get(i) == 'O' || Program.l1.Get(i) == 'R'){
                if (Program.l1.Get(i) == 'G'){
                    CheakG(i);
                }
                CheakR(i);
            }
        }
        for (int i = 0; i < Program.l1.GetLength(); i++){
            Console.Write("{0}",Program.l1.Get(i));
        }
    }
    static void CheakG(int GIndex)
    {
        if (GIndex >= 3)
        {
            CircularLinkedList<char> MockList = new CircularLinkedList<char>();
            int count = 0;
            for (int i = 0; i < Program.l1.GetLength(); i++)
            {
                MockList = Program.l1;
            }
            for (int i = GIndex; i >= 0; i--)
            {
                if (MockList.Get(i-1) == 'G')
                {
                    count++;
                    if (MockList.Get(i-2) == 'G'){
                        count++;
                        if (MockList.Get(i-3) == 'G'){
                            count++;
                        }
                    }
                    if (count >= 3)
                    {
                        Console.WriteLine("gInvalid pattern.");
                        Program.l1.Remove(GIndex);
                        return;
                    }
                }
                if (MockList.Get(i+1) == 'G')
                {
                    count++;
                    if (MockList.Get(i+2) == 'G'){
                        count++;
                        if (MockList.Get(i+3) == 'G'){
                            count++;
                        }
                    }
                    if (count >= 3)
                    {
                        Console.WriteLine("gInvalid pattern.");
                        Program.l1.Remove(GIndex);
                        return;
                    }
                }

            }
            
        }
        
        Console.WriteLine("");
        
    }

    static void CheakR(int RIndex)
    {   
        if (Program.l1.Get(RIndex) == 'R'){
            if(RIndex<2){
                Console.WriteLine("gInvalid pattern.");
                Program.l1.Remove(RIndex );
                return;
            }
        }
        if(Program.l1.Get(RIndex-1) == 'R')
        {
            if(RIndex>3)
            {
                if (Program.l1.Get(RIndex - 2) == Program.l1.Get(RIndex))
                {
                    Console.WriteLine("gInvalid pattern.");
                    Program.l1.Remove(RIndex );
                    return;
                }
            }
        }
        
                
        Console.WriteLine("");
    }
}