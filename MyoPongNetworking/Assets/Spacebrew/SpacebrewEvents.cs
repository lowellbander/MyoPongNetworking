using UnityEngine;
using System.Collections;

public class SpacebrewEvents : MonoBehaviour {

	SpacebrewClient sbClient;

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("SpacebrewObject"); // the name of your client object
		sbClient = go.GetComponent <SpacebrewClient> ();

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnSpacebrewEvent(SpacebrewClient.SpacebrewMessage _msg) {

	}

}
