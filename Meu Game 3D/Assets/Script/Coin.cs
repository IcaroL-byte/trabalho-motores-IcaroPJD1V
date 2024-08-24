using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int velocidadeGiro = 50;
    
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collisionCoin)
    {
        if (collisionCoin.tag == "Player")
        {
            FindObjectOfType<GameManeger>().SubtrairMoeda(1);
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        transform.Rotate(Vector3.up * velocidadeGiro * Time.deltaTime, Space.World);
    }
}
