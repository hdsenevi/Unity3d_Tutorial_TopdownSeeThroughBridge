using UnityEngine;
using System.Collections;

public class BridgeCollider : MonoBehaviour 
{
	public ObstructionDetector 	obstructionDetec;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Debug.Log("Enter");
			obstructionDetec.StartRayCast();
		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			Debug.Log("Exit");
			obstructionDetec.StopRayCast();
		}
	}
}
