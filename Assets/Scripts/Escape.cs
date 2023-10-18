using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour {

    public UI_Input uiInput;
    [SerializeField] private bool triggerActive = false;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && uiInput.puzzleSolved) {
            Debug.Log("You've escaped!");
            Debug.Log("TRIGGGERRRRR:" + triggerActive);
        }
    }
}
