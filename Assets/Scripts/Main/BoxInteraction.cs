using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour {
    [SerializeField] private bool triggerActive = false;
    public GameObject boxPopUp;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            triggerActive = true;
        }
    }

    private void Update() {
        if (triggerActive && Input.GetKeyDown(KeyCode.F)) {
            boxPopUp.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
    }
    
}