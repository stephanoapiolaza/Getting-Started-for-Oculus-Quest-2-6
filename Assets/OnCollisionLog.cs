using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Comenzo la colisión!");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Estamos colisionando!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Termino la colisión!");
    }

}
