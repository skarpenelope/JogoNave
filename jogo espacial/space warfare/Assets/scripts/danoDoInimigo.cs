using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoDoInimigo : MonoBehaviour
{
    public float velocidadeX;
    public int danoParaDar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * velocidadeX * Time.deltaTime);
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<vidaDoJogador>().DanoJogador(danoParaDar);
            Destroy(this.gameObject);
        }
    }
}
