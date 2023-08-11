using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;    //velocidade do player
    private Rigidbody2D rig;   //fisica do player
    //public GameObject gameOver;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ponto"))
        {
            GameController.instance.AtualizarPontos(1);
        }
    }

    void OnCollisionEnter2D(Collision2D bateu)
    {
        GameController.instance.GameOver();
        Time.timeScale = 0;
    }
}
