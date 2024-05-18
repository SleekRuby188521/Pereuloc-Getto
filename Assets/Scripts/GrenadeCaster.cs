using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrenadeCaster : MonoBehaviour
{
    public TextMeshProUGUI grenadeCountText;

    public static float grenadeCount = 5;

    public Rigidbody grenadePrefab;
    public Transform grenadeSourceTransform;

    public float force = 10;

    private void Start()
    {
        DrawUI();
    }

    private void DrawUI()
    {
        grenadeCountText.text = grenadeCount.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (grenadeCount > 0)
            {
                var grenade = Instantiate(grenadePrefab);
                grenade.transform.position = grenadeSourceTransform.position;
                grenade.GetComponent<Rigidbody>().AddForce(grenadeSourceTransform.forward * force);
                grenadeCount--;
                DrawUI();
            }
        }   
    }
}
