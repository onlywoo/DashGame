using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashcan : MonoBehaviour
{
    GameObject Player;
    Picking Picking;

    // Start is called before the first frame update
    void Start()
    {
                Player = GameObject.FindGameObjectWithTag("Player");
        Picking = Player.GetComponent<Picking>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other){
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "EmptyPlates1"){
            if(Input.GetKeyDown(KeyCode.Return))
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}
