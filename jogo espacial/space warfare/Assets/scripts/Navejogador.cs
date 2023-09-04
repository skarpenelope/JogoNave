using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navejogador : MonoBehaviour
{
    //movimentar
    public Rigidbody2D rigidbody;
    public float velocidademovimento;
    
    //atirar
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("iniciando script do jogador");
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * velocidademovimento);
        float velocidadeY = (vertical * velocidademovimento);

        rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);
        
        
    }
    
}
