using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBox : MonoBehaviour {
    public GameObject chatBox;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            chatBox.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    public void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            chatBox.SetActive(false);
        }
    }

    void Update() {
        if (Input.GetMouseButtonDown(0) && chatBox.activeSelf) {
            chatBox.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
