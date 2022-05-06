using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyPlate : MonoBehaviour
{
    Picking Picking;
    bool followPlayer1;
    bool followPlayer2;
    bool followPlayer3;
    bool followPlayer4;
    bool followPlayer5;
    bool followPlayer6;
    bool followPlayer7;

    GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Picking = Player.GetComponent<Picking>();
    }

    void Update()
    {
        if(followPlayer1)
        {
            Picking.EmptyPlates1.transform.position = new Vector2(Player.transform.position.x + 500, Player.transform.position.y + 50);
        }
           else if(followPlayer2)
        {
            Picking.EmptyPlates2.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
            else if(followPlayer3)
        {
            Picking.EmptyPlates3.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
            else if(followPlayer4)
        {
            Picking.EmptyPlates4.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
            else if(followPlayer5)
        {
            Picking.EmptyPlates5.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
            else if(followPlayer6)
        {
            Picking.EmptyPlates6.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
            else if(followPlayer7)
        {
            Picking.EmptyPlates7.transform.position = new Vector2(Player.transform.position.x, Player.transform.position.y);
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player");
        {
             if(Input.GetKeyDown(KeyCode.Return)){

                    if(gameObject.name == "Table1")
                {
                    followPlayer1 = true;
                }
                else if(gameObject.name == "Table2")
                {
                    followPlayer2 = true;
                }
                    else if(gameObject.name == "Table3")
                {
                    followPlayer3 = true;
                }
                    else if(gameObject.name == "Table4")
                {
                    followPlayer4 = true;
                }
                    else if(gameObject.name == "Table5")
                {
                    followPlayer5 = true;
                }
                    else if(gameObject.name == "Table6")
                {
                    followPlayer6 = true;
                }
                    else if(gameObject.name == "Table7")
                {
                    followPlayer7 = true;
                }
            
             }
           
        }
    }
}
