using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Level level;
    public Player player;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void checkColl ()
    {
        if (level.checkPos(player.getPosPlayer()))
        {
            Debug.Log("ENDGAME");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.moveLeft();
            player.updateGuiSprite();

            checkColl();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.moveRight();
            player.updateGuiSprite();

            checkColl();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.moveUp();
            player.updateGuiSprite();

            checkColl();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.moveDown();
            player.updateGuiSprite();

            checkColl();
        }
    }
}
