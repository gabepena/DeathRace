using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CarLap : MonoBehaviour {

	int lapNum = 0;
	public GameObject finishLine;
	public GameObject theHud;
	public int maxLaps;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if( other.gameObject == finishLine)
		{
			lapNum++;
			UnityEngine.UI.Text s = theHud.GetComponent<Text>();
			s.text = "Lap " + lapNum.ToString() + " / " + maxLaps.ToString();
		}
	}
}
