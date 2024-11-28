using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    Board board;
    public GameObject space;

    public float lenX = 1f, lenY = 1f;

    GameObject[,] goBoard; 

    void Awake()
    {
        board = new Board(); // 5x5
        board.randomBoard();

        goBoard = new GameObject[board.getSize(), board.getSize()];

        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                goBoard[i, j] = GameObject.Instantiate(space, transform);
            }
        }

        updateGuiSprite();
        updateGuiPosition();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            board.resetBoard();
            updateGuiSprite();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(board.ToString());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            board.randomBoard();
            updateGuiSprite();
        }

        
    }

    public void updateGuiPosition()
    {
        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                Vector2 pos = Vector2.zero;
                pos.x = i * lenX; pos.y = j * lenY;
                goBoard[i, j].transform.localPosition = pos;
            }
        }
    }

    public void updateGuiSprite()
    {
        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                if (board.getFromBoard(i, j) == 0)
                {
                    goBoard[i, j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else
                {
                    goBoard[i, j].GetComponent<SpriteRenderer>().color = Color.magenta;
                }
            }
        }
    }
}
