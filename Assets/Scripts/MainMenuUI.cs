using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject InfoPanel;
    
    private void Start()
    {
        InfoPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
    public void OnInfoBtnClicked()
    {
        MainMenuPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void OnPlBtnClicked()
    {
        SceneManager.LoadScene(1);
    }
}
