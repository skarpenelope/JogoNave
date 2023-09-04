using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class tiroinimigo : MonoBehaviour
{
    public float velocidadeTiro;
    public Rigidbody2D rigidbody;
    public GameObject tiroDoInimigo;

    public Transform localDoTiro;

    public float tempoEntreDisparos;

    public float tempoDosTiros;

    public int danoParaDar;

    public bool naveAtaque;
    public bool cruzadorBatalha;
    public bool inimigoAtirador;

    public int speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        AtirarLaserTodoLado();

    }

    private void AtirarLaser()
    {
        tempoDosTiros -= Time.deltaTime;
        if (tempoDosTiros <= 0f)
        {
            Instantiate(tiroDoInimigo, localDoTiro.position, quaternion.Euler (0f, 0f, 180f));
            tempoDosTiros = tempoEntreDisparos;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<vidaDoJogador>().DanoJogador(danoParaDar);
            Destroy(gameObject);
        }
    }

    private void AtirarLaserTodoLado()
    {
        tempoDosTiros -= Time.deltaTime;
        if (tempoDosTiros <= 0f && naveAtaque == true)
        {
            float angulacao1 = Random.Range(-60f, 60f); 
            Instantiate(tiroDoInimigo, localDoTiro.position, UnityEngine.Quaternion.Euler(0f, 0f, angulacao1));
            tempoDosTiros = tempoEntreDisparos;
        }

        if (tempoDosTiros <= 0f && cruzadorBatalha == true)
        {
            float angulacao2 = Random.Range(-120f, 120f);
            Instantiate(tiroDoInimigo, localDoTiro.position,UnityEngine.Quaternion.Euler(0f, 0f, angulacao2));
            tempoDosTiros = tempoEntreDisparos;

        }
    }
    
   
}
