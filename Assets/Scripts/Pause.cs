using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject FireSound;
    public GameObject Walk;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseInGame();
        }
    }

    private void PauseInGame()
    {
        PauseScreen.SetActive(true);
        FireSound.SetActive(false);
        Walk.SetActive(false);
        GetComponent<PlayerController>().enabled = false;
    }
}
