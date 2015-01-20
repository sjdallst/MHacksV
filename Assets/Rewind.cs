using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.IO;

public class Rewind : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf == true) {
			string filename = "C:\\Users\\" + Environment.UserName + "\\Documents\\Visual Studio 2013\\Projects\\Publisher\\Publisher\\bin\\Release\\Publisher.exe";
			Process.Start(filename, "RR");
			gameObject.SetActive (false);
		} 
	}
}
