using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Range(0, 100)]
    private float vol;
    public Slider volumeSlider;

    private Player.controlScheme controls;
    public Dropdown controlDropDown;

    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        if(volumeSlider == null && controlDropDown == null) { return; }
       volumeSlider.value = PlayerPrefs.GetFloat("Volume");
       if (PlayerPrefs.GetString("Controls") == "WASD")
       {
            controlDropDown.value = 0;
       }
        else
        {
            controlDropDown.value = 1;
        }

    }
    
    public void OnSettingsSave()
    {
        vol = volumeSlider.value;
        switch (controlDropDown.value)
        {
            case 0:
                controls = Player.controlScheme.WASD;
                break;
            case 1:
                controls = Player.controlScheme.Arrows;
                break;
        }

        PlayerPrefs.SetFloat("Volume", vol);
        PlayerPrefs.SetString("Controls", controls.ToString());
        PlayerPrefs.Save();
        if (player != null)
        {
            player.SettingsUpdate();
        }

    }
}
