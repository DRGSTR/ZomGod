using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private GameObject creditsPanel;
    [SerializeField]
    private GameObject UIHolder;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        UIHolder.SetActive(false);
        settingsPanel.SetActive(true);
        //xsettingsPanel.GetComponent<"Back Button">().SetActive(true);
    }

    public void Back()
    {
        Debug.Log("BACK BUTTON PRESSED");
        UIHolder.SetActive(true);
    }

    public void Credits()
    {
        UIHolder.SetActive(false);
        creditsPanel.SetActive(true);
    }

} // class
