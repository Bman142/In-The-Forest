using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimationControl : MonoBehaviour
{
    private Animator animator;
    private KeyCode forward;
    private Player.controlScheme controls;

    // Start is called before the first frame update
    void Start()
    {
        controls = FindObjectOfType<Player>().controls;
        animator = this.GetComponent<Animator>();
        switch (controls)
        {
            case Player.controlScheme.WASD:
                forward = KeyCode.W;
                break;
            case Player.controlScheme.Arrows:
                forward = KeyCode.UpArrow;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(forward))
        {
            animator.SetBool("Walking", true);
        }
        if (Input.GetKeyUp(forward))
        {
            animator.SetBool("Walking", false);
        }
    }
}
