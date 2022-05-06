using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class ButtonScripts : MonoBehaviour
{

    [SerializeField] private Button Quit;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void quitGame()
    {
        Application.Quit();
    }


}
