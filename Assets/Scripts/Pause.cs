using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Pause : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject Object1;
    public GameObject Object2;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
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
