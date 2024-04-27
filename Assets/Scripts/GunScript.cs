using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 10f;
    public ParticleSystem qq;
    public Camera PlayerCamera;
    public AudioSource wee;

    private float nextTimeToFire=0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time>=nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
    }
    public void Shoot()
    {
        qq.Play();
        wee.Play();
        RaycastHit hit;
        if(Physics.Raycast(PlayerCamera.transform.position,PlayerCamera.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);
           
        }
    }
}
