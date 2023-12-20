using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public Player player;
    public TextMeshProUGUI scoreTxt;
    public GameObject GameOverPanel;
       // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text ="Scores:" +player.Scores.ToString();

    }
    public void  GameOver()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;

    }
    public void OnPlayBtnClicked()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
        GameOverPanel.SetActive(false);
        Time.timeScale = 1f;
    }
  
}
