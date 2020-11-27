using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movimiento : MonoBehaviour
{

	//Poner publico para poder ser editado desde unity
	public float velocidad = 1000;
	public Text guiText;
	protected int puntos;
	protected float tiempo;
	protected Rigidbody rig;

	// Use this for initialization
	void Start()
	{
		puntos = 0;
		tiempo = Time.time;
		guiText.text = "";
		rig = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Puntos")
		{
			puntos++;
			other.gameObject.SetActive(false);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Final")
		{
			float puntuacion = (Time.time - tiempo) - puntos * 5;
			guiText.text = "Nivel superado!!: " + puntuacion;
			//Destroy (this.rigidbody);
			this.rig.isKinematic = true;
		}
	}

	void FixedUpdate()
	{
		Vector3 direccion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rig.AddForce(direccion * velocidad * Time.deltaTime);
		//Camera.main.transform.LookAt (transform);
	}
}
