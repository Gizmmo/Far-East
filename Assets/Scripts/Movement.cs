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

				//Actually Moves the character by the given translations.
				transform.Translate (horizontalTranslation, verticalTranslation, 0);
		}

		/**
		 * Generates a movement translation for an axis based on the number passed (which will be between -1 and 1, as well as
		 * Delta Time and the speed variable.
		 * 
		 * @Return The translation amount to move by.
		 **/ 
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
