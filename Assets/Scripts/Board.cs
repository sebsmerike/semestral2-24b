using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    protected int size = 5;
    public const int enemyProb = 2;
    protected int[,] tablero;
    
    // Contructor
    public Board(int maxSize = 5)
    {
        size = maxSize;
        tablero = new int[size, size];
        resetBoard();
    }

    public void resetBoard()
    {
        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                tablero[i, j] = 0;
            }
        }
    }

    // Aleatoriza los obstáculos en el tablero
    public void randomBoard()
    {
        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                int x = Random.Range(0, 10);
                tablero[i, j] = x <= enemyProb ? 1 : 0;
            }
        }
    }

    override public string ToString()
    {
        string data = "";

        for (int j = 0; j < size; j++)
        {
            data += "\n";
            for (int i = 0; i < size; i++)
            {
                data += tablero[i, j] == 0 ? "_" : "x";
            }
        }

        return data;
    }

    public int getFromBoard(int x, int y)
    {
        return tablero[x, y];
    }

    public int getSize () { return size;}

}