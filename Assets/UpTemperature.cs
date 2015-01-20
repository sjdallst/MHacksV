using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Meta;

public class UpTemperature : Button {
	public GameObject temperature;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void OnClick() {
		int temp = int.Parse(temperature.GetComponent<Text>().text);
		temp++;
		temperature.GetComponent<Text>().text = temp.ToString ();
	}
}
