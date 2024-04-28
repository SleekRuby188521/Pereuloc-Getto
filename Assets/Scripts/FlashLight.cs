﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] Light _flashLight;
    [SerializeField] AudioSource _xzKakNazzvat;
    [SerializeField] Light _flashLightq;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _flashLight.enabled = !_flashLight.enabled;
            _flashLightq.enabled = !_flashLightq.enabled;
            _xzKakNazzvat.Play();
        }
    }
}
