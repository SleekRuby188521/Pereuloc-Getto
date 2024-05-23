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
    [SerializeField] float maxAmmo = 6f;
    [SerializeField] float curAmmo;
    public Camera PlayerCamera;
    public AudioSource wee;
    
    public GameObject rev;

 
    private void Start()
    {
        curAmmo = maxAmmo;
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && 1 <= fireRate && curAmmo > 0)
        {
            fireRate = q;
            Shoot();

        }
        if (fireRate == 0f)
        {

        }
        fireRate += Time.deltaTime;
        ReloadGun();
    }
    public void Shoot()
    {
        wee.Play();
        curAmmo--;
        rev.GetComponent<Animator>().SetTrigger("Fire");
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
    public void ReloadGun()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Invoke("rel", 1);
            rev.GetComponent<Animator>().SetTrigger("Reload");
        }
    }
    void rel()
    {
        curAmmo = maxAmmo;
    }
}
