using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    InstantiateCustomer InstantiateCustomer;
    GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        InstantiateCustomer = Canvas.GetComponent<InstantiateCustomer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.name == "Table1")
        {
                        if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table1Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table1Clear = false;
            }
        }



        if (gameObject.name == "Table2")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table2Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table2Clear = false;
            }
        }

        if (gameObject.name == "Table3")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table3Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table3Clear = false;
            }
        }


        if (gameObject.name == "Table4")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table4Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table4Clear = false;
            }
        }


        if (gameObject.name == "Table5")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table5Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table5Clear = false;
            }
        }


        if (gameObject.name == "Table6")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table6Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table6Clear = false;
            }

        }

        if (gameObject.name == "Table7")
        {
            if (gameObject.tag == "TNP")
            {
                InstantiateCustomer.table7Clear = true;
                gameObject.tag = "TNF";
            }
            else
            {
                InstantiateCustomer.table7Clear = false;
            }
        }
    }

    public void DropPlate()
    {
        this.gameObject.tag = "TFS";
        Debug.Log("Dropped the plate on the table");
    }

    public void PickUpDish()
    {
        this.gameObject.tag = "TNP";
        Debug.Log("Cleared dishes and table, ready for seating");
    }
}