using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOnClick : MonoBehaviour
{
    public AudioSource music;
    public Transform[] otherObjects;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        AudioSource currentAudio;
        for(int i = 0; i <= otherObjects.Length - 1; i++)
        {
            currentAudio = otherObjects[i].GetComponent<AudioSource>();
            if (currentAudio != null)
                currentAudio.Stop();
        }
        music.Play();
    }
}
