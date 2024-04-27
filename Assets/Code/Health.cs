using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine. UI ;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float StartingHealth;
    public float CurrentHealth { get; private set; }
    public void TakeDamage(float Damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - Damage, 0, StartingHealth);
        CurrentHealth -= Damage;
        if (CurrentHealth > 0)
        {

        }
        else
        {

        }
    }
    private void Awake()
    {
        CurrentHealth = StartingHealth;
    }


    // Update is called once per frame
    void Update()
    {
    }
}

