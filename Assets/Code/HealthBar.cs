using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image TotalHealthBar;
    [SerializeField] private Image CurrentHealthBar;
    // Start is called before the first frame update
    void Start()
    {
        TotalHealthBar.fillAmount = playerHealth.CurrentHealth / 10;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealthBar.fillAmount = playerHealth.CurrentHealth / 10;
    }
}
