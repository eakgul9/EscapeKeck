using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Input : MonoBehaviour {
    public TMP_InputField inputField;
    private TextMeshProUGUI resultText;
    public bool isPopupActive = false;
    public bool puzzleSolved = false;
    public GameObject boxPopUp;
    public void CheckInputAndClose() {
        string inputText = inputField.text;
        if (inputText == "123") {
            isPopupActive = false;
            boxPopUp.SetActive(false);
            puzzleSolved = true;
            Debug.Log("Puzzle solved!");
            Debug.Log(puzzleSolved);
        }
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
}