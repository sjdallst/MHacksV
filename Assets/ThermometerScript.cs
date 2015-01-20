using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Meta;


public class ThermometerScript : MonoBehaviour {
	Text data;
	// Use this for initialization
	void Start () {
		data = GetComponent<Text> ();
		data.text = "HELLO";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
