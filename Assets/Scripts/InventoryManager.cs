using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<string> items;
    public List<Button> buttons;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void InventoryUpdate()
    {
        foreach (Button button in buttons)
        {
            foreach (string item in items)
            {
                if (button.name == item)
                {
                    button.gameObject.SetActive(true);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
