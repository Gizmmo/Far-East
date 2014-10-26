using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

		public float speed;

		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetAxis ("Vertical") != 0) {
						float translation = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
						transform.Translate (0, translation, 0);
				} else if (Input.GetAxis ("Horizontal") != 0) {
						float translation = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
						transform.Translate (translation, 0, 0);
				}
		}
}
