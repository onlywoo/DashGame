using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingTray : MonoBehaviour
{
    [SerializeField]
    private static int numPlates; //the number of food plates on the serving tray at any point in time

    [SerializeField] private GameObject plate1;
    [SerializeField] private GameObject plate2;
    [SerializeField] private GameObject plate3;

    [SerializeField]
    GameObject pizzaDish;

    // Start is called before the first frame update
    void Start()
    {
        numPlates = 3;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    /// <summary>
    /// A function to pick up plates on the serving tray. It removes a plate from the serving tray and decreases the number of plates.
    /// </summary>
    public void PickUpPlate()
    {
        if (numPlates > 0)
        {
            // switch (numPlates)     //removes one plate from the serving tray
            // {
            //     case 1:
            //         plate1.gameObject.SetActive(true);
            //         break;
            //     case 2:
            //         plate2.gameObject.SetActive(true);
            //         break;
            //     case 3:
            //         plate3.gameObject.SetActive(true);
            //         break;
            //     default:
            //         Debug.Log("there was an error with picking up plate from serving tray");
            //         return;
            // }

            //--numPlates;

            // if (numPlates == 0)
            // {
            //     NoFood();
            // }

            //Debug.Log("Number of plates: " + numPlates);

            //Picking.canPick = false;
            //Picking.pickedObject = "plate";
        }
    }

    /// <summary>
    /// A function for when there is no more food on the serving tray
    /// </summary>
    // public void NoFood()
    // {
    //     //Debug.Log("There's no more food");
 
    //     this.gameObject.tag = "STNF";
    // }

    void OnCollisionStay2D(Collision2D other)
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Enter pressed");
            if(Picking.canPick)
            {
                pizzaDish.SetActive(true);
                Picking.canPick = false;
            }
        }
    }
}