using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableWipe : MonoBehaviour {
    [SerializeField] private bool triggerActive = false;
    public GameObject boxPopUp;
    public GameManager gameManager;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            boxPopUp.SetActive(false);
            triggerActive = false;
        }
    }

    private void Update() {
        if (triggerActive && Input.GetKeyDown(KeyCode.F) && gameManager.taskComplete) {
            boxPopUp.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
        if (Input.GetKeyDown(KeyCode.Escape) && boxPopUp.activeSelf) {
            boxPopUp.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            triggerActive = false;
        }
    }
}
