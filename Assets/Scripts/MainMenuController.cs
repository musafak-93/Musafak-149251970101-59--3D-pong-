using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public string url;
    public GameObject CreditUI;

    public void CreditUi_btn()
    {
        CreditUI.SetActive(true);
    }

    public void Back_btn()
    {
        CreditUI.SetActive(false);
    }

    public void Open()
    {
        Application.OpenURL(url);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game2");
        Debug.Log("Musafak-149251970101-59");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Musafak");
    }
}
