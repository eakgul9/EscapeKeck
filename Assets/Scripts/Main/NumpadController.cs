using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NumpadController : MonoBehaviour {
    public TMP_Text displayText;
    public GameObject popUp;

    public void OnNumberButtonClick(string number) {
        displayText.text += number;
    }

    public void OnBackspace() {
        if (displayText.text.Length > 0) {
            displayText.text = displayText.text.Substring(0, displayText.text.Length - 1);
        }
    }

    public void ClearDisplayText() {
        displayText.text = "";
    }

    public void OnEnterPressed() {
        string enteredCode = displayText.text;

        if (enteredCode == "84102") {
            //Debug.Log("Code is correct!");
            popUp.SetActive(false);
            SceneManager.LoadScene("End");
        }
        else {
            //Debug.Log("Code is incorrect!");
            displayText.text = "";
        }
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.Backspace)) {
            OnBackspace();
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            OnEnterPressed();
        }
    }
}

