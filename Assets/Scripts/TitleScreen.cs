using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class TitleScreen : MonoBehaviour {

    public GameObject startPanel;
    public GameObject horrorStart;
    public GameObject controlsPanel;
    public GameObject horrorControls;
    public GameObject creditsPanel;
    public GameObject horrorCredits;
    public PostProcessVolume postProcessVolume;
    private bool isGlitchActive = false;
    private float glitchSwitchInterval = 2f;
    
    private void Start() {
        StartCoroutine(ToggleGlitchWithTimer());
    }

    private IEnumerator ToggleGlitchWithTimer() {
        while (true) {
            yield return new WaitForSeconds(glitchSwitchInterval);

            isGlitchActive = !isGlitchActive;
            ToggleGlitchEffect(isGlitchActive);

            if (isGlitchActive) {
                SwitchToMainPanel();
            }
            else {
                SwitchToOtherPanel();
            }
        }
    }

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

    public void SwitchToMainPanel() {
        startPanel.SetActive(true);
        horrorStart.SetActive(false);
    }

    public void SwitchToOtherPanel() {
        startPanel.SetActive(false);
        horrorStart.SetActive(true);
    }

    private void ToggleGlitchEffect(bool enable) {
        if (postProcessVolume != null) {
            ChromaticAberration chromaticAberration;
            if (postProcessVolume.profile.TryGetSettings(out chromaticAberration)) {
                chromaticAberration.enabled.value = enable;
            }
        }
    }
}
