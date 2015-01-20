using UnityEngine;
using System.Collections;
using Meta;

public class TemperatureBoxScript : MetaBehaviour {
	public GameObject temperaturePanel;
	public GameObject thermometerPanel;
	public GameObject humidityPanel;
	public GameObject humidifierPanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGazeEnter() {
		temperaturePanel.SetActive (true);
	}

	public void OnGazeExit() {
		temperaturePanel.SetActive(false);
		thermometerPanel.SetActive (false);
		humidityPanel.SetActive (false);
		humidifierPanel.SetActive (false);
	}
}
