using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoberry : MonoBehaviour
{
    
    public GameObject player;

    public AudioSource audiosource;
    public AudioClip moneysound;

    void Update()
    {
        if(Vector3.Distance(player.transform.position, transform.position) <= 3f && Input.GetKeyUp(KeyCode.E))
        {
            audiosource.Play();
            GetComponent<PlayerRoberry>().enabled = false;
            
        }
    }
}
