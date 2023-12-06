using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI_Input : MonoBehaviour {
    public TMP_InputField inputField;
    public static bool puzzleSolved = false;
    public GameObject boxPopUp;
    
    public void start() {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    public void CheckInputAndClose() {
        string inputText = inputField.text;
        if (inputText == "123") {
            boxPopUp.SetActive(false);
            SetPuzzleSolved(true);
            Debug.Log("Puzzle solved!");
            // Debug.Log(puzzleSolved);
            // Debug.Log(isPopupActive);
        }
    }

    public void ClosePopUp() {
        boxPopUp.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void SetPuzzleSolved(bool b) {
        puzzleSolved = b;
    }

    public bool GetPuzzleSolved () {
        return puzzleSolved;
    }
}