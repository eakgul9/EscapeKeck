using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetScript : MonoBehaviour {
    public GameManager gameManager;
    public GameObject preChatBox;
    public GameObject postChatBox;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            if (!gameManager.screwdriverObtained) {
                preChatBox.SetActive(true);
            } else {
                postChatBox.SetActive(true);
                gameManager.taskComplete = true;
            }
            Time.timeScale = 0;
        }
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            if (preChatBox.activeSelf) {
                preChatBox.SetActive(false);
            } else if (postChatBox.activeSelf) {
                postChatBox.SetActive(false);
            }
            Time.timeScale = 1;
        }
    }

}
