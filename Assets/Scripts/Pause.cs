using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject Object1;
    public GameObject Object2;

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
        Object1.SetActive(false);
        Object2.SetActive(false);
        GetComponent<PlayerController>().enabled = false;
    }
}
