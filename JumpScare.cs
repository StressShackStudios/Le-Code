using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.SendMessage("JumpScare");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
