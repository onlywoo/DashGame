using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{

    public Button Startgame;

    public GameObject info;

    private void Start()
    {
        info.SetActive(false);
    }
    public void startGame()
    {
        StartCoroutine(Instructions());
       
    }

    IEnumerator Instructions()
    { 
        info.SetActive(true);
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(1);
      
    }
}
