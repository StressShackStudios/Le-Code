using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualScare : MonoBehaviour
{
    public AudioClip Boo;
    public float Volume;
    AudioSource audioS;
    public AnxVal DecAnx;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        audioS = GetComponent<AudioSource>();
    }

    public void Scare()
    {
        this.gameObject.SetActive(true);
        audioS.PlayOneShot(Boo, Volume);
        DecAnx.AnxLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
