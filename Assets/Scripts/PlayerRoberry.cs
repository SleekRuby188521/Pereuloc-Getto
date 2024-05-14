using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerRoberry : MonoBehaviour
{
    public int playerMoney = 0;
    public TextMeshProUGUI moneyValueTMP;
    public GameObject player;

    public AudioSource audiosource;
    public AudioClip moneysound;

    private void Start()
    {
        DrawUI();
    }

    private void DrawUI()
    {
        moneyValueTMP.text = playerMoney.ToString();
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= 3f && Input.GetKeyUp(KeyCode.E))
        {
            audiosource.Play();
            GetComponent<PlayerRoberry>().enabled = false;
            playerMoney++;
            DrawUI();
            
        }
    }
}
