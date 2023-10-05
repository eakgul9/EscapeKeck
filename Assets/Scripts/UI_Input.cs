using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Input : MonoBehaviour {
    public TMP_InputField inputField;
    private TextMeshProUGUI resultText;
    public bool isPopupActive = false;
    public GameObject boxPopUp;
    public void GetInputText() {
        string inputText = inputField.text;
        resultText.text = "Entered Text: " + inputText;
        Debug.Log(resultText);
    }

    public void Update() {
        if (isPopupActive) {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
        else {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; 
        }
    }

    public void ButtonClick() {
        isPopupActive = false;
        boxPopUp.SetActive(false);
    }
}
