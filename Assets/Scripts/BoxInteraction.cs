using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private bool triggerActive = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerActive = false;
        }
    }

    private void Update()
    {
        if (triggerActive && Input.GetKeyDown(KeyCode.F))
        {
            SomeCoolAction();
        }
        Debug.Log(triggerActive);
    }

    public void SomeCoolAction()
    {

    }
    
}
