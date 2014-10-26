using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey ("left")) {
			float translation = Time.deltaTime * 10;
			transform.Translate (-translation, 0, 0);
		}

		if(Input.GetKey ("right")) {
			float translation = Time.deltaTime * 10;
			transform.Translate (translation, 0, 0);
		}

		if(Input.GetKey ("up")) {
			float translation = Time.deltaTime * 10;
			transform.Translate (0, translation, 0);
		}

		if(Input.GetKey ("down")) {
			float translation = Time.deltaTime * 10;
			transform.Translate (0, -translation, 0);
		}
	}
}
