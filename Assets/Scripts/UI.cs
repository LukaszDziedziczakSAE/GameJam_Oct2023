using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    [SerializeField] Image healthBar;
    [SerializeField] Health castleHealth;


    public void UpdateUI()
    {
        if (castleHealth)
        {
            healthText.text = castleHealth.HealthString;
            healthBar.fillAmount = castleHealth.HealthNormalzed;
        }
    }
}
