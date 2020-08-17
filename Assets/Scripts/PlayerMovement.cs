using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    //Camera Controls
    private Vector2 mouseDirection;
    private float cameraSensitivity;

    //Movement Controls (Keyboard)
    private KeyCode forward;
    private KeyCode backward;
    private KeyCode left;
    private KeyCode right;
    private KeyCode sprint;
    public KeyCode flashlight;
    private Player.controlScheme controls;
    private NavMeshAgent agent;
    private float walkSpeed;
    private float sprintSpeed;

    public bool inMenu = false;

    // Start is called before the first frame update
    void Start()
    {
        cameraSensitivity = this.gameObject.GetComponent<Player>().horizontalCameraSensitivity;
        controls = this.gameObject.GetComponent<Player>().controls;
        agent = this.GetComponent<NavMeshAgent>();
        walkSpeed = this.GetComponent<Player>().walkSpeed;
        sprintSpeed = this.GetComponent<Player>().sprintSpeed;

        switch (controls)
        {
            case Player.controlScheme.WASD:
                forward = KeyCode.W;
                backward = KeyCode.S;
                left = KeyCode.A;
                right = KeyCode.D;
                sprint = KeyCode.LeftShift;
                flashlight = KeyCode.F;
                break;
            case Player.controlScheme.Arrows:
                forward = KeyCode.UpArrow;
                backward = KeyCode.DownArrow;
                left = KeyCode.LeftArrow;
                right = KeyCode.RightArrow;
                sprint = KeyCode.RightControl;
                flashlight = KeyCode.Keypad0;

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse Movement (Left to Right)
        if (!inMenu)
        {
            Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
            mouseDirection += mouseChange;
            this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.x * cameraSensitivity, Vector3.up);
        }
        
        //Keyboard Movement (Forward and Backwards, Strafeing)
        float movementSpeed = walkSpeed;
        if (Input.GetKey(sprint)) { movementSpeed = sprintSpeed; }
        
        if (Input.GetKey(forward)) { agent.Move(this.transform.forward * movementSpeed); }
        if (Input.GetKey(backward)) { agent.Move(this.transform.forward * -movementSpeed); }
        if (Input.GetKey(left)) { agent.Move(this.transform.right * -movementSpeed); }
        if (Input.GetKey(right)) { agent.Move(this.transform.right * movementSpeed); }
        /*
        if (Input.GetKey(forward)) { this.transform.position += this.transform.forward * movementSpeed * Time.deltaTime; }
        if (Input.GetKey(backward)) { this.transform.position -= this.transform.forward * movementSpeed * Time.deltaTime; }
        if (Input.GetKey(left)) { this.transform.position -= this.transform.right * movementSpeed * Time.deltaTime; }
        if (Input.GetKey(right)) { this.transform.position += this.transform.right * movementSpeed * Time.deltaTime; }
        */
    }
}
