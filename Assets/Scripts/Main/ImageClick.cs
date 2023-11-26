using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageClick : MonoBehaviour, IPointerClickHandler {

    public GameManager gameManager;
    
    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("HEREEEEEEEEEEEEEEEEEEEEEEEEE");
        //Debug.Log(gameObject.name);
        gameManager.AddToInventory(gameObject.name);
        gameObject.SetActive(false);
    }
}

