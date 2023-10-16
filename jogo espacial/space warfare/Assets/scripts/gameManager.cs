using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject playerstart;
    public GameObject player;
    public Transform spawmPlayer;
    public static gameManager instance;
    public int pontuaçãoAtual;

    public Text pontuação;

    [SerializeField] private string lvl_1;
    
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void CarregarCenas()
    {
        SceneManager.LoadScene("GUI");
        SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Additive);
    }

    void Start()
    {
        SceneManager.LoadScene("lvl_1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AumentarPontuação(int pontosParaGanhar)
    {
        pontuação.text = "PONTUACAO:" + pontuaçãoAtual;
        pontuaçãoAtual += pontosParaGanhar;
        Observer.PointsChanged(pontuaçãoAtual);
    }
    
    public void LoadScene()
    {
        SceneManager.LoadScene("GUI");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }

    public void Cenas()
    {
        SceneManager.LoadScene("GUI");
        SceneManager.LoadSceneAsync("lvl_1", LoadSceneMode.Additive).completed += delegate(AsyncOperation operation)
        {
            playerstart = GameObject.FindWithTag("playerstart");
            Instantiate(player, spawmPlayer.transform.position,  Quaternion.Euler(0,0,0));

        };
    }
}
