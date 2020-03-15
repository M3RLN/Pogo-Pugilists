using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public void ItemSelect()
    {
        SceneManager.LoadScene("ItemSelection");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
