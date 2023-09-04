using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject inimigoIma;

    public Transform LocalSpawner;
    public float tempoDeSpawn;
    public float tempoEntreSpawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoDeSpawn -= Time.deltaTime;
        if (tempoDeSpawn <= 0)
        {

            Instantiate(inimigoIma, transform.position, inimigoIma.transform.rotation);
            tempoDeSpawn = tempoEntreSpawn;

        }
    }
}
