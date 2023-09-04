using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserJogador : MonoBehaviour
{
    
    public Rigidbody2D rig;
   
    public GameObject lazerJogador;
    public Transform spawnLaserJo;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        AtirarLaser();
    }
    //quandi colidir vai dar dano
    
    public void AtirarLaser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerJogador, spawnLaserJo.position, spawnLaserJo.rotation);

        }
    }
}
