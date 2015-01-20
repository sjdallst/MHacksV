using UnityEngine;
using System.Collections;
using Meta;

public class MyCubeScript : MetaBehaviour {
	public GameObject hud;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnGazeEnter() {
		hud.SetActive (true);
	}

	public void OnGazeExit() {
		hud.SetActive (false);
	}
}
