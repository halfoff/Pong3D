using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		float moveH = Input.GetAxis ("Vertical");
		Vector3 mov = new Vector3 (0, 0, moveH);
		rb.AddForce (mov * speed);
	}

}
