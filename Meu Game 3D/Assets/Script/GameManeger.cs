using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    public TextMeshProUGUI hud, msg_vitoria;
    public int restantes;

    public AudioClip clipMoeda, clipVitoria;
    private AudioSource soucer;

    public string nomeDaProxFase;
    void Start()
    {
        restantes = FindObjectsOfType<Coin>().Length;

        TryGetComponent(out soucer);
        hud.text = $"NeymarCoins restantes: {restantes}";
    }

    public void SubtrairMoeda(int valor)
    {
        restantes -= valor;
        hud.text = $"NeymarCoins restantes: {restantes}";
        soucer.PlayOneShot(clipMoeda);

        if(restantes <= 0)
        {
            msg_vitoria.text = "Parabens";
            soucer.Stop();
            soucer.PlayOneShot(clipVitoria);
            
            Invoke("ProxFase",3);
        }
    }

    void ProxFase()
    {
        SceneManager.LoadScene(nomeDaProxFase);
    }
}
