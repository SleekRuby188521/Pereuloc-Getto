using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MarketBuying : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI moneyValueTMP;
    public TextMeshProUGUI grenadeCountText;

    public GameObject aidkit;
    public GameObject Playercamera;
    public AudioSource Buying;
    public AudioSource unBuying;
    void Start()
    {
        GetComponent<GrenadeCaster>();
        GetComponent<PlayerRoberry>();
        
    }

    
    void Update()
    {
        GrenadeBuying();

        AidkitBuying();
    }

    private void AidkitBuying()
    {
        if (Vector3.Distance(Playercamera.transform.position, transform.position) <= 5f && Input.GetKeyDown(KeyCode.G))
        {
            if (PlayerRoberry.playerMoney >= 4)
            {
                var Aidkit = Instantiate(aidkit);
                Aidkit.transform.position = player.transform.position;
                PlayerRoberry.playerMoney -= 4;
                DrawUI();
                Buying.Play();
            }
        }
    }

    private void GrenadeBuying()
    {
        if (Vector3.Distance(Playercamera.transform.position, transform.position) <= 5f && Input.GetKeyDown(KeyCode.F))
        {
            if (PlayerRoberry.playerMoney >= 3f)
            {
                GrenadeCaster.grenadeCount++;
                grenadeCountText.text = GrenadeCaster.grenadeCount.ToString();
                PlayerRoberry.playerMoney -= 3f;
                DrawUI();
                Buying.Play();
            }
        }
    }

    private void DrawUI()
    {
        moneyValueTMP.text = PlayerRoberry.playerMoney.ToString();
    }
}
