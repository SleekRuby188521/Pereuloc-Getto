using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoberry : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip moneysound;

    public GameObject target;
    void Update()
    {
        if(Vector3.Distance(target.transform.position, transform.position) <= 3f && Input.GetKeyUp(KeyCode.E))
        {
            audiosource.PlayOneShot(moneysound);
        }
    }
}
