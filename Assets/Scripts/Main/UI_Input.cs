using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UI_Input : MonoBehaviour {
    public TMP_InputField inputField;
    public bool isPopupActive = false;
    public static bool puzzleSolved = false;
    public GameObject boxPopUp;
    
    public void CheckInputAndClose() {
        string inputText = inputField.text;
        if (inputText == "123") {
            isPopupActive = false;
            boxPopUp.SetActive(false);
            SetPuzzleSolved(true);
            Debug.Log("Puzzle solved!");
            // Debug.Log(puzzleSolved);
            // Debug.Log(isPopupActive);
        }
    }

    public void SetPuzzleSolved(bool b) {
        puzzleSolved = b;
    }

    public bool GetPuzzleSolved () {
        return puzzleSolved;
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