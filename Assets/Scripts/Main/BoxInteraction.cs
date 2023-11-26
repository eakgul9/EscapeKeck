using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool triggerActive = false;
    public GameObject boxPopUp;
    public UI_Input uiInput;

    public void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            triggerActive = true;
        }
    }

    private void Update() {
        if (triggerActive && Input.GetKeyDown(KeyCode.F)) {
            boxPopUp.SetActive(true);
            uiInput.isPopupActive = true;
        }
    }
    
}