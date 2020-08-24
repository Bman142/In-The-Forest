using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class EventTriggerPlaceHolder : MonoBehaviour
{
    public Canvas eventText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnEventTrigger()
    {
        eventText.gameObject.SetActive(true);
        if (this.gameObject.GetComponent<Renderer>())
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
        }
        this.gameObject.GetComponent<Collider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (eventText.gameObject.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            eventText.gameObject.SetActive(false);
        }
    }
}
