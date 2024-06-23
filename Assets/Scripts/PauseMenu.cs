using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;
    public float transitionTime;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                paused.TransitionTo(transitionTime);
                Time.timeScale = 0f;
            }
            else
            {
                unpaused.TransitionTo(transitionTime);
                Time.timeScale = 1f;
            }

        }
    }
}
