using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public int pontuaçãoAtual;

    public Text pontuação;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuação(int pontosParaGanhar)
    {
        pontuação.text = "PONTUAÇAÕ:" + pontuaçãoAtual;
        pontuaçãoAtual += pontosParaGanhar;
    }
}
