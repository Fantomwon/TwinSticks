using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Beam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}
