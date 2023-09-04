using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaDoInimigo : MonoBehaviour
{
    public int inimigoVidaAtual;

    public int inimigoVidaMaxima;

    public int pontosParaDar;
    // Start is called before the first frame update
    void Start()
    {
        inimigoVidaAtual = inimigoVidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MachucarInimigo(int danoRecebido)
    {
        inimigoVidaAtual -= danoRecebido;
        if (inimigoVidaAtual <= 0)
        {
            gameManager.instance.AumentarPontuação(pontosParaDar);
            Destroy(this.gameObject);
        }
    }
}
