using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MarketTrigger : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] virtualCameras;
    private int currenCameraIndex;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            virtualCameras[currenCameraIndex].Priority = 0;
            currenCameraIndex++;

            if (currenCameraIndex >= virtualCameras.Length)
                currenCameraIndex = 0;

            virtualCameras[currenCameraIndex].Priority = 1;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        
        virtualCameras[currenCameraIndex].Priority = 0;
        currenCameraIndex--;
        virtualCameras[currenCameraIndex].Priority = 1;
    }
}
