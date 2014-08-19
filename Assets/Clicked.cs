using UnityEngine;
using System.Collections;

public class Clicked : MonoBehaviour {
	public GameObject Cubey;
	public float burgerMove;
	public int jumpSize;
	public int NoOfMoves;
	public int moves;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Debug.Log("you clicked");
		if(moves<NoOfMoves)
		{
		Vector3 newPos = Cubey.transform.position;
		newPos.y += burgerMove;
		Cubey.transform.position = newPos;
		moves+=jumpSize;
		}
	}
}
