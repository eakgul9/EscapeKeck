using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageClick : MonoBehaviour, IPointerClickHandler {
    public GameManager gameManager;

    // Call this method when the object is clicked
    public void OnPointerClick(PointerEventData eventData) {
        gameManager.AddToInventory(gameObject.name); // Add the GameObject's name to the inventory
        gameObject.SetActive(false); // Make the clicked GameObject invisible
        if (gameObject.name == "screwdriver") {
            gameManager.screwdriverObtained = true;
        }
        Time.timeScale = 0;
    }
}


