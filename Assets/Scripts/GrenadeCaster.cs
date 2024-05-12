using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCaster : MonoBehaviour
{
    public float grenadeCount = 5;

    public Rigidbody grenadePrefab;
    public Transform grenadeSourceTransform;

    public float force = 10;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (grenadeCount > 0)
            {
                var grenade = Instantiate(grenadePrefab);
                grenade.transform.position = grenadeSourceTransform.position;
                grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force);
                grenadeCount--;
            }
        }   
    }
}
