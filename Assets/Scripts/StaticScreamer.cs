using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticScreamer : MonoBehaviour
{
    public bool isActive = true;

    public GameObject monster;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (isActive)
            {
                isActive = false;
                monster.SetActive(true);
                StartCoroutine(Timer());
            }
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        monster.SetActive(false);
    }
}
