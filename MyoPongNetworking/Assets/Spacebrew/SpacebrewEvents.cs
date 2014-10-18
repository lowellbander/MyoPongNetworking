using UnityEngine;
using System.Collections;

public class SpacebrewEvents : MonoBehaviour {

	SpacebrewClient sbClient;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("SpacebrewObject"); // the name of your client object
		sbClient = go.GetComponent <SpacebrewClient> ();

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

		Vector3 ballPos1;
		Vector3 ballPos2;

		// REGISTER EVENT LISTENERS

		sbClient.addEventListener (this.gameObject, "paddleOn1");
		sbClient.addEventListener (this.gameObject, "paddleOn2");

		sbClient.addEventListener (this.gameObject, "paddlePos1");
		sbClient.addEventListener (this.gameObject, "paddlePos2");

		sbClient.addEventListener (this.gameObject, "ballPos1");
		sbClient.addEventListener (this.gameObject, "ballPos2");

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnSpacebrewEvent(SpacebrewClient.SpacebrewMessage _msg) {

	}

}
