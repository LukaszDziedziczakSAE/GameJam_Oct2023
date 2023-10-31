using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI Instance { get; private set; }

    [SerializeField] TMP_Text healthText;
    [SerializeField] Image healthBar;
    [SerializeField] Health castleHealth;
    [SerializeField] TMP_Text roundText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }


    public static void UpdateUI()
    {
        if (Instance.castleHealth != null)
        {
            Instance.healthText.text = Instance.castleHealth.HealthString;
            Instance.healthBar.fillAmount = Instance.castleHealth.HealthNormalzed;
        }

        Instance.roundText.text = "Round: " + GameManager.Instance.RoundNumber;
    }

    public void OnXPress()
    {
        Application.Quit();
    }
}
