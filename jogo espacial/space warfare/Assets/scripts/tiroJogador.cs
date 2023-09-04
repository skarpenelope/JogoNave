using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroJogador : MonoBehaviour
{
    public int danoParaDar;
    public float velocidadeLaser;
    
    void Update()
    {
        //this.rigidbody.velocity = new Vector2(this.velocidadeX, 0);
        transform.Translate(Vector3.right * (velocidadeLaser * Time.deltaTime));
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<inimigos>().MachucarInimigo(danoParaDar);
            Destroy(other.gameObject);
        }
    }
    
}
