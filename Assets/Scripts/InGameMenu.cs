using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameMenu : MonoBehaviour
{
    public Canvas canvas;
    public PlayerMovement player;
    public CameraControl camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMenu();
        }

    }
    public void LoadMenu()
    {
        if (player.inMenu)
        {
            player.inMenu = false;
        }
        else
        {
            player.inMenu = true;
        }
        if (camera.inMenu)
        {
            camera.inMenu = false;
        }
        else
        {
            camera.inMenu = true;
        }
        if (canvas.gameObject.activeSelf)
        {
            canvas.gameObject.SetActive(false);
        }
        else
        {
            canvas.gameObject.SetActive(true);
        }

        
    }

    public void ExitToMenu() 
    { 
        SceneManager.LoadScene(0); 
    }
    public void ExitToDesktop()
    {
        Application.Quit();
    }
}
