using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine. UI ;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] float StartingHealth;
    public float CurrentHealth { get; private set; }
    public void TakeDamage(float Damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - Damage, 0, StartingHealth);
       
        if (CurrentHealth > 0)
        {

        }
        else
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    private void Awake()
    {
        CurrentHealth = StartingHealth;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1f);
        }
    }
}

