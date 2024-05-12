﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScreamer : MonoBehaviour
{
    public float speed = 0;
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
        yield return new WaitForSeconds(0.8f);        
        monster.SetActive(false);
        SceneManager.LoadScene("Titers");
    }

    private void Update()
    {
        if(monster.activeInHierarchy)
        {
            monster.transform.position += new Vector3(0, 0, -10 * Time.deltaTime * speed);
        }
    }
}