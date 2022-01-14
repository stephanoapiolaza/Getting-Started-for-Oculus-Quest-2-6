using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class OnTriggerLog : MonoBehaviour
{

    [Tooltip("Color example with picker color")]
    public ColorField color;

    [Header("The best properties")]
    [Tooltip("Message to concat OnTriggerEnter method")]
    [Space(10)]
    public string message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Comenzo el trigger! " + message);
    }

    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("Estamos realizando trigger!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Termino el trigger!");
    }

}
