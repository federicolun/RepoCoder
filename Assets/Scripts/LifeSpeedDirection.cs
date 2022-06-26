using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpeedDirection : MonoBehaviour
{
    public int life;
    public float speed;
    public Vector3 direction;

    void Start()
    {
        life = 100;
        speed = 5.0f;
    }

    void Update()
    {
        MovementController();

        HealPlayer();

        DamagePlayer();
    }

    void MovementController()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void HealPlayer()
    {
        life++;
        Debug.Log("El jugador recupero salud : " + life);
    }

    void DamagePlayer()
    {
        life--;
        Debug.Log("La vida del jugador es : " + life);
    }
}
