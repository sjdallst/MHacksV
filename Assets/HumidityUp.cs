using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HumidityUp : MonoBehaviour {
	public GameObject temperature;
	private Text texts;
	// Use this for initialization
	void Start () {
		texts = temperature.GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf == true) {
			int tmp = int.Parse (texts.text.Remove(texts.text.Length-1)) + 1;
			texts.text = (tmp.ToString () + "%");
			gameObject.SetActive (false);
		} 
	}
}
