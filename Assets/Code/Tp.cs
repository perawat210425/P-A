using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tp : MonoBehaviour
{



    [SerializeField] private int Endgame;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ghost")
        {
            SceneManager.LoadScene(Endgame, LoadSceneMode.Single); //เปลี่ยนไปหน้า Game Over

        }
    }

}
