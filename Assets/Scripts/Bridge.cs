using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour 
{
	public Color 	transparentColor;
	private Color 	m_InitialColor;
	
	void Start () 
	{
	 	m_InitialColor = GetComponent<Renderer>().material.color;
	}
	
	public void SetTransparent()
	{
		GetComponent<Renderer>().material.color = transparentColor;
	}
	
	public void SetToNormal()
	{
		GetComponent<Renderer>().material.color = m_InitialColor;
	}
}
