//int fattoriale(int numero)
//{
//    int risultato = 0;

//    if (numero > 1)
//    {
//        risultato = fattoriale(numero - 1) * numero ;
//    }
//    else
//    {
//        risultato = 1;
//    }
//    return risultato;
//}

//Console.WriteLine(fattoriale(3));



int[] giocoDel15 =
{
    1, 2, 3, 4,
    5, 6, 7, 8,
    9, 10, 11, 12,
    13, 14, 15, 0
};


void GameController(int[] array)
{
    bool isOver = false;

    while (!isOver)
    {
        PrintGrid(array);
        Console.WriteLine();
        Console.WriteLine("Quale numero vuoi muovere?");
        int input = Convert.ToInt32(Console.ReadLine());
        int[] move = ConsentedMove(input, array);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == input && move.Contains(GetEmptyCell(array)))
            {
                Move(input, array);
                Console.Clear();
            }
        }
       
    }
}


GameController(giocoDel15);




void PrintGrid(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 4 == 0)
        {
            Console.WriteLine();
        }
        if (array[i] != 0)
        {
            Console.Write(array[i] + " | ");
        }
        else { Console.Write("X |"); }   
    }

}


int GetEmptyCell(int[] array)
{
    int freeSlot;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            freeSlot = i;
            return freeSlot;
        }
    }
        return 0;
}

int[] Move(int n, int[] array)
{
    
    int empty = GetEmptyCell(array);

  
    for (int i = 0; i < array.Length; i++)
    {

        if (n == array[i])
        {
            int toMove = array[i];
            array[i] = 0;
            array[empty] = toMove;
        }
    }
    return array;
}

int[] ConsentedMove(int input , int[] array)
{
    int position = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if(input == array[i])
        {
            position = i;
        }
    }
    int[] move = new int[4];
    switch (position)
    {
        case 0:
            move[0] = 1;
            move[1] = 4;
            break;

        case 1:
            move[0] = 0;
            move[1] = 2;
            move[2] = 5;
            break;

        case 2:
            move[0] = 1;
            move[1] = 3;
            move[2] = 6;
            break;


        case 3:
            move[0] = 2;
            move[1] = 7;
            break;

        case 4:
            move[0] = 0;
            move[1] = 5;
            move[2] = 8;
            break;

        case 5:
            move[0] = 1;
            move[1] = 4;
            move[2] = 9;
            move[3] = 6;
            break;

        case 6:
            move[0] = 2;
            move[1] = 5;
            move[2] = 7;
            move[3] = 10;
            break;

        case 7:
            move[0] = 3;
            move[1] = 6;
            move[2] = 11;
            break;

        case 8:
            move[0] = 4;
            move[1] = 9;
            move[2] = 12;
            break;

        case 9:
            move[0] = 8;
            move[1] = 5;
            move[2] = 10;
            move[3] = 13;
            break;

        case 10:
            move[0] = 6;
            move[1] = 11;
            move[2] = 14;
            move[3] = 9;
            break;

        case 11:
            move[0] = 7;
            move[1] = 10;
            move[2] = 15;
            break;

        case 12:
            move[0] = 8;
            move[1] = 13;
            break;

        case 13:
            move[0] = 9;
            move[1] = 12;
            move[2] = 14;
            break;

        case 14:
            move[0] = 10;
            move[1] = 13;
            move[2] = 15;
            break;

        case 15:
            move[0] = 14;
            move[1] = 11;
            break;


    }
            return move;
}