using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    public int inimigoVidaAtual;
    public int inimigoVidaMaxima;
    public Rigidbody2D rigidbody;

    public float velocidadeX;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        inimigoVidaAtual = inimigoVidaMaxima;

    }

    // Update is called once per frame
    void Update()
    {
        //this.rigidbody.velocity = new Vector2(this.velocidadeX, 0);
        transform.Translate(Vector3.left * velocidadeX * Time.deltaTime);
    }
    
    public void MachucarInimigo(int danoRecebido)
    {
        inimigoVidaAtual -= danoRecebido;
        if (inimigoVidaAtual <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
