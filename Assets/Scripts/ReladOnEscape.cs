using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ReladOnEscape : MonoBehaviour
{
    public TextMeshProUGUI playerMoney;
    public TextMeshProUGUI grenadeCountText;

    private void Start()
    {
        GetComponent<PlayerRoberry>();
        GetComponent<GrenadeCaster>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            PlayerRoberry.playerMoney = 0;
            playerMoney.text = PlayerRoberry.playerMoney.ToString();
            GrenadeCaster.grenadeCount = 5;
            grenadeCountText.text = GrenadeCaster.grenadeCount.ToString();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
}
