using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;

public class GameManeger : MonoBehaviour
{
    public TextMeshProUGUI hud, msg_vitoria;
    public int restantes;

    void Start()
    {
        restantes = FindObjectsOfType<Coin>().Length;

        hud.text = $"NeymarCoins restantes: {restantes}";
    }

    public void SubtrairMoeda(int valor)
    {
        restantes -= valor;
        hud.text = $"NeymarCoins restantes: {restantes}";
    

        if(restantes <= 0)
        {
            msg_vitoria.text = "Parabens";
        }
    }

    void Update()
    {
        
    }
}
