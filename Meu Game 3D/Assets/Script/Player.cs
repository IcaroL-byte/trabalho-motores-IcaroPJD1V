using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 7;
    private Rigidbody rb;


    void Start()
    {
       TryGetComponent(out rb);
    }

    
    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal"); //valor do input horizontal, sendo -1 esquerda e 1 direita.
        float vertical = Input.GetAxis("Vertical"); //a mesma coisa que ode cima só que na vertical. moró?

        UnityEngine.Vector3 direcao = new Vector3(horizontal, 0, vertical);
        rb.AddForce(direcao * velocidade * Time.deltaTime,ForceMode.Impulse);
    
        if(transform.position.y <= -10)
        {
            //jogador caiu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
