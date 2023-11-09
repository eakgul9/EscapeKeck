using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

    public GameObject startPanel;
    public GameObject horrorStart;
    public GameObject controlsPanel;
    public GameObject horrorControls;
    public GameObject creditsPanel;
    public GameObject horrorCredits;
    
    public void PlayGame() {
        SceneManager.LoadScene("Main");
    }

    public void OpenControls() {
        controlsPanel.SetActive(true);
        startPanel.SetActive(false);
    }

    public void CloseControls() {
        startPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }

    public void OpenCredits() {
        creditsPanel.SetActive(true);
        startPanel.SetActive(false);
    }

    public void CloseCredits() {
        startPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
