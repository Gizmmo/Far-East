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
				float verticalTranslation = generateMovementTranslation (Input.GetAxis ("Vertical"));
				float horizontalTranslation = generateMovementTranslation (Input.GetAxis ("Horizontal"));
				transform.Translate (horizontalTranslation, verticalTranslation, 0);
		}

		float generateMovementTranslation (float translation)
		{
				if (translation != 0) {
						//If the character is moving in a direction on the given axis
						return translation * Time.deltaTime * speed;
				} else {
						//If the character is not moving in any direction on the given axis
						return 0;
				}
		}
}
