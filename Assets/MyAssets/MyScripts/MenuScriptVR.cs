using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuScriptVR : MonoBehaviour
{
    public GameObject closingButtonBlock;
    public GameObject openingButtonBlock;

    public void ButtonClick()
    {
        Debug.Log("You pressed the button");
    }

    public void ExitButton()
    {
        if (!closingButtonBlock)
        {
            Debug.Log("You pressed the exit button");
            Application.Quit();
        }
        else
        {
            Debug.Log("You pressed the button");

            closingButtonBlock.SetActive(false);
            openingButtonBlock.SetActive(true);
        }
    }
}

