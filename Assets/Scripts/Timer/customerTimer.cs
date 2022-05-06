using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerTimer : MonoBehaviour
{
    SpriteRenderer SpriteRenderer;

    private bool seated = false;
    private bool ordered = false;
    private bool eaten = false;
    private bool paid = false;

    private int money;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine("WaitingToOrder");
        SpriteRenderer.color = Color.green;
    }

       IEnumerator WaitingToOrder()
     {
        yield return new WaitForSeconds(6.5f);

          if(ordered == true){
            money += 40;
            StartCoroutine("WaitingForFood");
        }
        else{

            SpriteRenderer.color = Color.yellow;
            yield return new WaitForSeconds(8);
            if(ordered == true){
                money += 40;
                SpriteRenderer.color = Color.green;
                StartCoroutine("WaitingForFood");
            }
            else{
                SpriteRenderer.color = Color.red;
                money += 0; //customer is lost - no money gained
                // gameObject.SetActive(false);
            }
        }

     }

       IEnumerator WaitingForFood()
     {
        yield return new WaitForSeconds(6.5f);

          if(eaten == true){
            money += 40;
            StartCoroutine("WaitingForBill");
        }
        else{
            SpriteRenderer.color = Color.yellow;
            yield return new WaitForSeconds(8);
            if(eaten == true){
                money += 40;
                SpriteRenderer.color = Color.green;
                StartCoroutine("WaitingForBill");
            }
            else{
                SpriteRenderer.color = Color.red;
                money += 0; //customer is lost - no money gained
                // gameObject.SetActive(false);
            }
        }

     }

          IEnumerator WaitingForBill()
     {
        yield return new WaitForSeconds(6.5f);

          if(paid == true){
            money += 40;
            // gameObject.SetActive(false);
        }
        else{
            SpriteRenderer.color = Color.yellow;
            yield return new WaitForSeconds(8);
            if(paid == true){
                money += 40;
                SpriteRenderer.color = Color.green;
                // gameObject.SetActive(false);
            }
            else{
                SpriteRenderer.color = Color.red;
                money += 0; 
                // gameObject.SetActive(false);
            }
        }

     }
}
