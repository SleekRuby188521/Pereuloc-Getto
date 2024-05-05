using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 0f;
    public float q = 0f;
    public float impactForce;
    public Camera PlayerCamera;
    public AudioSource wee;
    public ParticleSystem zxc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && 1 <= fireRate)
        {
            fireRate = q;
            Shoot();
        }
        fireRate += Time.deltaTime;
    }
    public void Shoot()
    {
        wee.Play();
        zxc.Play();
        RaycastHit hit;
        if(Physics.Raycast(PlayerCamera.transform.position,PlayerCamera.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name); 
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            Health healtht = hit.transform.GetComponent<Health>();
            if (healtht != null)
            {
                healtht.TakeDamage(damage);
            }
        }
    }
}
