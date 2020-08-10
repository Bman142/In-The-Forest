using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector2 mouseDirection;
    private float cameraSensitivity;
    private KeyCode flashlight;
    private Light torch;
    public bool inMenu = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraSensitivity = this.gameObject.GetComponentInParent<Player>().verticalCameraSensitivity;
        flashlight = this.gameObject.GetComponentInParent<PlayerMovement>().flashlight;
        torch = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inMenu)
        {
            Vector2 mouseChange = new Vector2(Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Mouse Y"));
            mouseDirection += mouseChange;
            // Lock vertical field of view to approx. -45 to 90
            if (mouseDirection.y > 2.3) { mouseDirection.y = 2.3f; }
            else if (mouseDirection.y < -4.5) { mouseDirection.y = -4.5f; }

            this.transform.localRotation = Quaternion.AngleAxis(mouseDirection.y * cameraSensitivity, Vector3.right);
        }
        if (Input.GetKeyDown(flashlight))
        {
            bool torchOn = torch.enabled;
            if (torchOn)
            {
                torch.enabled = false;
            }
            else
            {
                torch.enabled = true;
            }
        }
    }
}
