using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidaDoJogador : MonoBehaviour
{
    public int vidaMaxDoJogador;

    public int vidaAtualDoJogador;

    public bool temEscudo;
    public Slider barradevida;
    
    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaxDoJogador;
        barradevida.maxValue = vidaMaxDoJogador;
        barradevida.value = vidaAtualDoJogador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DanoJogador(int danoParaReceber)
    {
        if (temEscudo == false)
        {
            vidaAtualDoJogador -= danoParaReceber;
            barradevida.value = vidaAtualDoJogador;

            if (vidaAtualDoJogador <= 0f)
            {
                Debug.Log("Game Over");
            }
            Observer.EnergyChanged((float) vidaAtualDoJogador/vidaMaxDoJogador);
        }
    }
    

}
