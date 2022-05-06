using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCustomer : MonoBehaviour
{

    public bool table1Clear = false;
    public bool table2Clear = false;
    public bool table3Clear = false;
    public bool table4Clear = false;
    public bool table5Clear = false;
    public bool table6Clear = false;
    public bool table7Clear = false;

    [SerializeField]
    GameObject customerPrefab;

    Vector2 tablePos1 = new Vector2(-5244, -277);
    Vector2 tablePos2 = new Vector2(-2322, -277);
    Vector2 tablePos3 = new Vector2(600, -277);
    Vector2 tablePos4 = new Vector2(-5244, -3871);
    Vector2 tablePos5 = new Vector2(-2322, -3871);
    Vector2 tablePos6 = new Vector2(600, -3871);
    Vector2 tablePos7 = new Vector2(4428, -3871);

    GameObject newCustomer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (table1Clear == true)
        {
            StartCoroutine("InstantiateTable1");
        }

        if (table2Clear == true)
        {
            StartCoroutine("InstantiateTable2");
        }

        if (table3Clear == true)
        {
            StartCoroutine("InstantiateTable3");
        }

        if (table4Clear == true)
        {
            StartCoroutine("InstantiateTable4");
        }

        if (table5Clear == true)
        {
            StartCoroutine("InstantiateTable5");
        }

        if (table6Clear == true)
        {
            StartCoroutine("InstantiateTable6");
        }

        if (table7Clear == true)
        {
            StartCoroutine("InstantiateTable7");
        }
    }

    IEnumerator InstantiateTable1()
    {
        yield return new WaitForSeconds(1);
        newCustomer = Instantiate(customerPrefab, tablePos1, Quaternion.identity);
        Debug.Log(tablePos1);
        Debug.Log(newCustomer.transform.position);
    }

    IEnumerator InstantiateTable2()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos2, Quaternion.identity);
    }

    IEnumerator InstantiateTable3()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos3, Quaternion.identity);
    }

    IEnumerator InstantiateTable4()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos4, Quaternion.identity);
    }

    IEnumerator InstantiateTable5()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos5, Quaternion.identity);
    }

    IEnumerator InstantiateTable6()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos6, Quaternion.identity);
    }

    IEnumerator InstantiateTable7()
    {
        yield return new WaitForSeconds(1);
        Instantiate(customerPrefab, tablePos7, Quaternion.identity);
    }
}