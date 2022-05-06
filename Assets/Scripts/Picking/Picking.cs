using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{

    public static bool canPick = true;
    private string objectState = null;
    public static string pickedObject = null;

    [SerializeField] private GameObject servingTray;

    [SerializeField]
    GameObject PizzaDish;

    [SerializeField]
    GameObject EmptyPlate;

    GameObject Table1;
    GameObject Table2;
    GameObject Table3;
    GameObject Table4;
    GameObject Table5;
    GameObject Table6;
    GameObject Table7;

    Vector2 TablePos1 = new Vector2(-6293, -572);
    Vector2 TablePos2 = new Vector2(-3438, -572);
    Vector2 TablePos3 = new Vector2(-393, -572);
    Vector2 TablePos4 = new Vector2(-6293, -3490);
    Vector2 TablePos5 = new Vector2(-3438, -3490);
    Vector2 TablePos6 = new Vector2(-393, -3490);
    Vector2 TablePos7 = new Vector2(3413, -3490);

    public GameObject EmptyPlates1;
    public GameObject EmptyPlates2;
    public GameObject EmptyPlates3;
    public GameObject EmptyPlates4;
    public GameObject EmptyPlates5;
    public GameObject EmptyPlates6;
    public GameObject EmptyPlates7;

    public GameObject pizzaPrefab1;
    public GameObject pizzaPrefab2;
    public GameObject pizzaPrefab3;
    public GameObject pizzaPrefab4;
    public GameObject pizzaPrefab5;
    public GameObject pizzaPrefab6;
    public GameObject pizzaPrefab7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Diner"))  //checks if player has collided with any gameobjects of the diner layer
        {
            Debug.Log(collision.gameObject.tag);
            objectState = collision.gameObject.tag;
            CheckPicking();
            CheckDropping(collision);

        }
    }

    /// <summary>
    /// Function to check if the player can pick up items, that calls the relevant functions for specific actions
    /// </summary>
    void CheckPicking()
    {
        if (canPick)
        {

            switch (objectState)
            {
                case "TD":
                    Debug.Log("Table with Dishes");
                    return;
                case "TFS":
                    Debug.Log("Table with Food Served");
                    return;
                case "TNF":
                    Debug.Log("Table with No Food");
                    return;
                case "TNP":
                    Debug.Log("Table with No People to serve");
                    return;
                case "STF":
                    Debug.Log("Serving Table with Food");
                    PickFood();
                    return;
                case "STNF":
                    Debug.Log("Serving Table with No Food");
                    return;
                case "DR":
                    Debug.Log("Dish Rack");
                    return;
                default:
                    Debug.Log("An error has occured with identifying the object state");
                    return;

            }
        }
        else
        {
            Debug.Log("Waiter has hands full");
        }
    }

    void CheckDropping(Collision2D coll)
    {
        if (!canPick)
        {
            switch (objectState)
            {
                case "TD":
                    Debug.Log("Table with Dishes");
                    return;
                case "TFS":
                    Debug.Log("Table with Food Served");
                    return;
                case "TNF":
                    Debug.Log("Table with No Food");
                    return;
                case "TNP":
                    Debug.Log("Table with No People to serve");
                    return;
                case "STF":
                    Debug.Log("Serving Table with Food");
                    return;
                case "STNF":
                    Debug.Log("Serving Table with No Food");
                    return;
                case "DR":
                    Debug.Log("Dish Rack");
                    DropDishes();
                    return;
                default:
                    Debug.Log("An error has occured with identifying the object state");
                    return;

            }
        }
        else
        {
            if (objectState == "TD")
            {
                PickUpDish(coll);
            }
            else
            {
                Debug.Log("Waiter is carrying nothing");
            }
            
        }
    }

    void DropDishes()
    {
        canPick = true;
        pickedObject = null;
    }

   /// <summary>
   /// A function for picking up dirty dishes from the table
   /// </summary>
   /// <param name="coll"></param>
    void PickUpDish(Collision2D coll)
    {
        canPick = false;
        pickedObject = "dish";
        coll.gameObject.GetComponent<Table>().PickUpDish();
    }

    /// <summary>
    /// A function that handles the picking of food from the serving tray by the player
    /// </summary>
    void PickFood()
    {
        servingTray.GetComponent<ServingTray>().PickUpPlate();

        Debug.Log("Picked Food From serving table");
    }

    /// <summary>
    /// Function that handles the delivering of plates to customer tables
    /// </summary>
    void DropPlate(Collision2D coll)
    {
        canPick = true;
        pickedObject = null;
        PizzaDish.SetActive(false);
        //coll.gameObject.tag = "TFS";
        coll.gameObject.GetComponent<Table>().DropPlate();

        if(coll.gameObject.name=="Table1")
        {
            Table1 = coll.gameObject;
            pizzaPrefab1 = Instantiate(PizzaDish, TablePos1, Quaternion.identity);
            EmptyPlates1 = Instantiate(EmptyPlate, TablePos1, Quaternion.identity);
            EmptyPlates1.name = "EmptyPlates1";
            EmptyPlates1.SetActive(false);
            pizzaPrefab1.SetActive(true);
            pizzaPrefab1.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza1");
            Table1.AddComponent<EmptyPlate>();
        }
          else if(coll.gameObject.name=="Table2")
        {
            Table2 = coll.gameObject;
            pizzaPrefab2 = Instantiate(PizzaDish, TablePos2, Quaternion.identity);
            EmptyPlates2 = Instantiate(EmptyPlate, TablePos2, Quaternion.identity);
            EmptyPlates2.SetActive(false);
            pizzaPrefab2.SetActive(true);
            pizzaPrefab2.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza2");
            Table2.AddComponent<EmptyPlate>();
        }
          if(coll.gameObject.name=="Table3")
        {
            Table3 = coll.gameObject;
            pizzaPrefab3 = Instantiate(PizzaDish, TablePos3, Quaternion.identity);
            EmptyPlates3 = Instantiate(EmptyPlate, TablePos3, Quaternion.identity);
            EmptyPlates3.SetActive(false);
            pizzaPrefab3.SetActive(true);
            pizzaPrefab3.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza3");
            Table3.AddComponent<EmptyPlate>();
        }
          if(coll.gameObject.name=="Table4")
        {
            Table4 = coll.gameObject;
            pizzaPrefab4 = Instantiate(PizzaDish, TablePos4, Quaternion.identity);
            EmptyPlates4 = Instantiate(EmptyPlate, TablePos4, Quaternion.identity);
            EmptyPlates4.SetActive(false);
            pizzaPrefab4.SetActive(true);
            pizzaPrefab4.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza4");
            Table4.AddComponent<EmptyPlate>();
        }
          if(coll.gameObject.name=="Table5")
        {
            Table5 = coll.gameObject;
            pizzaPrefab5 = Instantiate(PizzaDish, TablePos5, Quaternion.identity);
            EmptyPlates5 = Instantiate(EmptyPlate, TablePos5, Quaternion.identity);
            EmptyPlates5.SetActive(false);
            pizzaPrefab5.SetActive(true);
            pizzaPrefab5.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza5");
            Table5.AddComponent<EmptyPlate>();
        }
              if(coll.gameObject.name=="Table6")
        {
            Table6 = coll.gameObject;
            pizzaPrefab6 = Instantiate(PizzaDish, TablePos6, Quaternion.identity);
            EmptyPlates6 = Instantiate(EmptyPlate, TablePos6, Quaternion.identity);
            EmptyPlates6.SetActive(false);
            pizzaPrefab6.SetActive(true);
            pizzaPrefab6.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza6");
            Table6.AddComponent<EmptyPlate>();
        }
        else if(coll.gameObject.name=="Table7")
        {
            Table7 = coll.gameObject;
            pizzaPrefab7 = Instantiate(PizzaDish, TablePos7, Quaternion.identity);
            EmptyPlates7 = Instantiate(EmptyPlate, TablePos7, Quaternion.identity);
            EmptyPlates7.SetActive(false);
            pizzaPrefab7.SetActive(true);
            pizzaPrefab7.transform.localScale = new Vector3(100,100,100);
            StartCoroutine("EatPizza7");
            Table7.AddComponent<EmptyPlate>();
        }
    }

   IEnumerator EatPizza1()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab1.SetActive(false);
        EmptyPlates1.SetActive(true);
        EmptyPlates1.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

       IEnumerator EatPizza2()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab2.SetActive(false);
        EmptyPlates2.SetActive(true);
        EmptyPlates2.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

       IEnumerator EatPizza3()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab3.SetActive(false);
        EmptyPlates3.SetActive(true);
        EmptyPlates3.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

       IEnumerator EatPizza4()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab4.SetActive(false);
        EmptyPlates4.SetActive(true);
        EmptyPlates4.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

       IEnumerator EatPizza5()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab5.SetActive(false);
        EmptyPlates5.SetActive(true);
        EmptyPlates5.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

       IEnumerator EatPizza6()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab6.SetActive(false);
        EmptyPlates6.SetActive(true);
        EmptyPlates6.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

    IEnumerator EatPizza7()
    {
        yield return new WaitForSeconds(5);
        pizzaPrefab7.SetActive(false);
        EmptyPlates7.SetActive(true);
        EmptyPlates7.transform.localScale = new Vector3(50,50,50);
        Debug.Log("eaten pizza");
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "TNF")
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                 DropPlate(other);
            }
           
        }
    }
}