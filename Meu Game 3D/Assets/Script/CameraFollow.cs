using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        offSet = alvo.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alvo.position - offSet;
    }
}
