using UnityEngine;
using System.Collections;

public class ObstructionDetector : MonoBehaviour 
{
	public Transform 	playerTrans;
	private Bridge		m_LastBridge;
	
	void Start () 
	{
//		StartCoroutine(DetectPlayerObstructions());
	}
	
	IEnumerator DetectPlayerObstructions()
	{
		while(true)
		{
			yield return new WaitForSeconds(0.5f);
			
			Vector3 direction = (playerTrans.position - Camera.mainCamera.transform.position).normalized;
			RaycastHit rayCastHit;
			
			if(Physics.Raycast(Camera.mainCamera.transform.position, direction, out rayCastHit, Mathf.Infinity))
			{
				Bridge bridge = rayCastHit.collider.gameObject.GetComponent<Bridge>();
				if(bridge)
				{
					bridge.SetTransparent();
					m_LastBridge = bridge;
				}
				else 
				{
					if(m_LastBridge)
					{
						m_LastBridge.SetToNormal();
						m_LastBridge = null;
					}
				}
			}
			
		}
	}
	
	public void StartRayCast()
	{
		StopCoroutine("DetectPlayerObstructions");
		StartCoroutine(DetectPlayerObstructions());
	}
	
	public void StopRayCast()
	{
		StopCoroutine("DetectPlayerObstructions");
	}
}
