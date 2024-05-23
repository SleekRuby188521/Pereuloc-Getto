using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanForSources : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Timer());
    }

  IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        
    }
}
