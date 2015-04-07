using UnityEngine;
using System.Collections;

public class Pivot : MonoBehaviour {

	public float pivotSize = .75f;
	public Color pivotColor = Color.yellow;

	// Use this for initialization
	void OnDrawGizmos()
	{
		Gizmos.color = pivotColor;
		Gizmos.DrawWireSphere (transform.position, pivotSize);
	}
}
