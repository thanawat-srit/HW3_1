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
                bool tf = true;
                if (Program.l1.Get(i) == 'G'){
                    tf = CheakG(i);
                }
                CheakR(i);
                if(tf){
                    Console.WriteLine("");
                }
            }
        }
            Console.WriteLine("");
        for (int i = 0; i < Program.l1.GetLength(); i++){
            Console.Write("{0}",Program.l1.Get(i));
        }
    }
    static bool CheakG(int GIndex)
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
                        Console.WriteLine("Invalid pattern.");
                        Program.l1.Remove(GIndex);
                        return false;
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
                        Console.WriteLine("Invalid pattern.");
                        Program.l1.Remove(GIndex);
                        return false;
                    }
                }

            }
            
        }
        
        return true;
        
    }

    static void CheakR(int RIndex)
    {   
        if (Program.l1.Get(RIndex) == 'R'){
            if(RIndex<2){
                Console.WriteLine("Invalid pattern.");
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
                    Console.WriteLine("Invalid pattern.");
                    Program.l1.Remove(RIndex );
                    return;
                }
            }
        }
        
                
        
    }
}