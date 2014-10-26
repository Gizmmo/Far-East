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
				updatePlayerMovement (); //Used to control the players movement through key presses
		}

		/**
		 * Updates the players current position through a translate by checking the current axis values of both the
		 * Horizontal Axis as well as the vertical axis.  If both are being used, it cuts the movement speed to prevent
		 * the user from cheating walking speeds
		 **/
		void updatePlayerMovement ()
		{
				float verticalTranslation;  //Used to keep track of the players current vertical movement
				float horizontalTranslation; //Used to keep track of the players current horizontal movement


				verticalTranslation = generateMovementTranslation (Input.GetAxis ("Vertical")); 
				horizontalTranslation = generateMovementTranslation (Input.GetAxis ("Horizontal"));

				//This is used to stop the user from using both direction to go fasther then just a single direction
				if (verticalTranslation != 0 && horizontalTranslation != 0) {
						horizontalTranslation *= .75f;
						verticalTranslation *= .75f;
				}
		
				//Actually Moves the character by the given translations.
				transform.Translate (horizontalTranslation, verticalTranslation, 0);
		}

		/**
		 * Generates a movement translation for an axis based on the number passed (which will be between -1 and 1, as well as
		 * Delta Time and the speed variable.
		 * 
		 * @Return The translation amount to move by.
		 **/ 
		private float generateMovementTranslation (float translation)
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
