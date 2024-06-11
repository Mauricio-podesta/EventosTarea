using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocidadX = 0.0f;
    void Start()
    {

    }
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputHorizontal * velocidadX * Time.deltaTime, 0.0f);
        if (Input.GetKeyDown(KeyCode.R))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
           
        }
    }
    
}
