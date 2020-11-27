using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject gameObject;
    protected Vector3 posicionOrigenObjeto;
    protected Vector3 posicionOrigenCamara;

    // Start is called before the first frame update
    void Start()
    {
        this.posicionOrigenObjeto = gameObject.transform.position;
        this.posicionOrigenCamara = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = (this.gameObject.transform.position - this.posicionOrigenObjeto) + this.posicionOrigenCamara;
    }
}
