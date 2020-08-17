using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class BookScript : MonoBehaviour
{
    public Canvas bookText;
    private bool hasPickedUpBook = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPickup()
    {
        bookText.gameObject.SetActive(true);
        hasPickedUpBook = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && hasPickedUpBook)
        {
            if (bookText.gameObject.activeSelf)
            {

                bookText.gameObject.SetActive(false);
            }
            else
            {
                bookText.gameObject.SetActive(true);
            }
        }
    }
}
