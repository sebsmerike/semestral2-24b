using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    BoardPlayer board;
    public GameObject space;

    public float lenX = 1f, lenY = 1f;

    GameObject[,] goBoard;

    void Awake () {
        board = new BoardPlayer ();

        goBoard = new GameObject[board.getSize(), board.getSize()];

        for (int j = 0; j < board.getSize(); j++)
        {
            for (int i = 0; i < board.getSize(); i++)
            {
                goBoard[i, j] = GameObject.Instantiate(space, transform);
                goBoard[i, j].GetComponent<SpriteRenderer>().color = Color.black;
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(board);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            board.moveLeft();
            var (x, y) = board.getPos();
            Debug.Log(x + "," + y);

            Debug.Log(board);

            updateGuiSprite();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            board.moveRight();
            var (x, y) = board.getPos();
            Debug.Log(x + "," + y);

            Debug.Log(board);

            updateGuiSprite();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            board.moveUp();
            var (x, y) = board.getPos();
            Debug.Log(x + "," + y);

            Debug.Log(board);

            updateGuiSprite();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            board.moveDown();
            var (x, y) = board.getPos();
            Debug.Log(x + "," + y);

            Debug.Log(board);

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
                    goBoard[i, j].SetActive(false);
                }
                else
                {
                    goBoard[i, j].SetActive(true);
                }
            }
        }
    }
}
