using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour {

    public UI_Input uiInput;

    public void OnTriggerEnter(Collider other) {
        // Debug.Log("We're in ESCAPE:" + uiInput.GetPuzzleSolved());
        if (other.CompareTag("Player") && uiInput.GetPuzzleSolved()) {
            Debug.Log("You've escaped!");
        }
    }
}
