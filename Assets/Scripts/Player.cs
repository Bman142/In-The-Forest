using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
