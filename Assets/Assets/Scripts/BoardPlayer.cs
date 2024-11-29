using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlayer : Board
{
    public int posX, posY;

    // Constructor
    public BoardPlayer(int maxSize=8) : base(maxSize)
    {
        // Primero ejecuta el Constructor de Board
        
        // calcular center
        posX = Mathf.FloorToInt(size / 2f);
        posY = 0;

        tablero[posX, posY] = 2;

    }

    // Verifica si hay más espacio del lado izquierdo
    public bool canMoveLeft()
    {
        if (posX == 0)
            return false;
        else
            return true;
    }

    // Mueve la posición actual 
    public void moveLeft()
    {
        if (canMoveLeft())
        {
            tablero[posX, posY] = 0;
            --posX;
            tablero[posX, posY] = 1;
        }
    }

    // Verifica si hay más espacio del lado derecho
    public bool canMoveRight()
    {
        if (posX == getSize() - 1)
            return false;
        else
            return true;
    }

    public void moveRight()
    {
        if (canMoveRight())
        {
            tablero[posX, posY] = 0;
            ++posX;
            tablero[posX, posY] = 1;
        }
    }

    // Verifica si hay más espacio del lado derecho
    public bool canMoveUp()
    {
        if (posY == getSize() - 1)
            return false;
        else
            return true;
    }

    public void moveUp()
    {
        if (canMoveUp())
        {
            tablero[posX, posY] = 0;
            ++posY;
            tablero[posX, posY] = 1;
        }
    }

    // Verifica si hay más espacio del lado derecho
    public bool canMoveDown()
    {
        if (posY == 0)
            return false;
        else
            return true;
    }

    public void moveDown()
    {
        if (canMoveDown())
        {
            tablero[posX, posY] = 0;
            --posY;
            tablero[posX, posY] = 1;
        }
    }

    // Regresa la posición actual del personaje
    public Vector2Int getPos()
    {
        return new Vector2Int(posX, posY);
    }

}
