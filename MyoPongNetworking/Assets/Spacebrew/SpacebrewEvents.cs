using UnityEngine;
using System.Collections;

public class SpacebrewEvents : MonoBehaviour {

	SpacebrewClient sbClient;

	// VARIABLES FOR REFERENCE.
	// In production, these will likely be replaced with GameObject.Find("myObject").myAttribute.ToString();
	
	// player1 is master, player2 is slave
	bool isPlayer1 = true;
	
	bool paddleOn1;
	bool paddleOn2;
	
	Vector3 paddlePos1;
	Vector3 paddlePos2;
	
	// below can later be extended to 
	// Vector3[] ballPos1;
	// Vector3[] ballPos2;
	
	Vector3 ballPos;

	// Use this for initialization
	private void Start () {
		GameObject go = GameObject.Find ("SpacebrewObject"); // the name of your client object
		sbClient = go.GetComponent <SpacebrewClient> ();

		// REGISTER EVENT LISTENERS

		sbClient.addEventListener (this.gameObject, "paddleOn1");
		sbClient.addEventListener (this.gameObject, "paddleOn2");

		sbClient.addEventListener (this.gameObject, "paddlePos1");
		sbClient.addEventListener (this.gameObject, "paddlePos2");

		sbClient.addEventListener (this.gameObject, "ballPos");

	}

	// Update is called once per frame
	private void Update () {

		//	sbClient.SendMessage (name, type, value);	

		if (this.isPlayer1) {

			sbClient.SendMessage ("paddleOn1", "boolean", this.paddleOn1.ToString());	

			sbClient.SendMessage ("paddlePos1", "string", this.paddlePos1.ToString());	

			sbClient.SendMessage ("paddlePos1", "string", this.paddlePos1.ToString());	


		} else {
			// is Player 2

			sbClient.SendMessage ("paddleOn1", "boolean", this.paddleOn1.ToString());	

			sbClient.SendMessage ("paddlePos2", "string", this.paddlePos2.ToString());	

		}
	}

	public void OnSpacebrewEvent(SpacebrewClient.SpacebrewMessage _msg) {
		if (this.isPlayer1) {
			
		} else {
			// is Player 2

		}
	}

}
