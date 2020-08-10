using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Settings))]
public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float walkSpeed;
    public float sprintSpeed;
    public enum controlScheme {WASD, Arrows}
    public controlScheme controls;

    [Header("Camera Controls")]
    public float verticalCameraSensitivity = 20;
    public float horizontalCameraSensitivity = 20;

    [Header("Audio")]
    public float volume;

    private void Awake()
    {
        SettingsUpdate();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    public void SettingsUpdate()
    {
        volume = PlayerPrefs.GetFloat("Volume") / 100;
        if (PlayerPrefs.GetString("Controls") == "WASD")
        {
            controls = controlScheme.WASD;
        }
        else if (PlayerPrefs.GetString("Controls") == "Arrows")
        {
            controls = controlScheme.Arrows;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
