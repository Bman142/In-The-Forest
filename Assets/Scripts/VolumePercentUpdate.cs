using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class VolumePercentUpdate : MonoBehaviour
{
    Text txt;
    public Slider gameManager;
    private float volume = 50f;
    // Start is called before the first frame update
    void Start()
    {
        txt = this.GetComponent<Text>();
        txt.text = volume + "%";
    }

    // Update is called once per frame
    void Update()
    {
        volume = Mathf.RoundToInt(gameManager.value);
        txt.text = volume + "%";
    }
}
