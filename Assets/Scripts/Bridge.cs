using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour 
{
	public Color 	transparentColor;
	private Color 	m_InitialColor;
	
	void Start () 
	{
	 	m_InitialColor = renderer.material.color;
	}
	
	public void SetTransparent()
	{
		renderer.material.color = transparentColor;
	}
	
	public void SetToNormal()
	{
		renderer.material.color = m_InitialColor;
	}
}
