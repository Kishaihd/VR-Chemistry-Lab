using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartandUpdate : MonoBehaviour {

	public float Xgo;
	public float Ygo;
	public float Zgo;
	public float Xvector;
	public float Yvector;
	public float Zvector;
	public int PowerLevel;
	public string PlayerName;

	// Use this for initialization
	void Start () {
		//initial facing
		transform.Rotate (0, 45, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		//rotate on y axis
		transform.Rotate (Xgo,Ygo,Zgo);
		transform.Translate (Xvector, Yvector, Zvector);
	}
}
