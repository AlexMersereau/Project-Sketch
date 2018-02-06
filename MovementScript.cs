using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;
using UnityEngine.AI;


namespace UnityStandardAssets._2D
{
	[RequireComponent(typeof (PlatformerCharacter2D))]
	public class MovementScript : MonoBehaviour {

		private PlatformerCharacter2D m_Character;
		private bool m_Jump;
		private Vector2 touchOrigin = -Vector2.one;

		private void Awake()
		{
			m_Character = GetComponent<PlatformerCharacter2D>();
		}

		
		// Update is called once per frame
		void Update () {
			
		}

		private void FixedUpdate()
		{
			// Read the inputs.
			float h = CrossPlatformInputManager.GetAxis("Horizontal");
			float touchPos = Input.mousePosition.x; 		//Input.GetTouch(0).position.x;			
			float direction = (Screen.width / 2) > touchPos ? -1 : 1;
			Debug.Log ("direction:" + direction);
			Debug.Log ("touchPos:" + touchPos);
			h = direction;
			// Pass all parameters to the character control script.
			if(Input.GetMouseButton(0)) m_Character.Move(h, false, false);
		}
	}
}