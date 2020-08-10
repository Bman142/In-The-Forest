using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    Player player;
    AudioSource source;
    private float volume;
    // Start is called before the first frame update
    void Start()
    {
        source = this.GetComponent<AudioSource>();
        player = this.GetComponent<Player>();
        volume = player.volume;
        source.volume = volume;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
