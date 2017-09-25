//Object with the script attached will always face camera and maintain z axis fixed.
using UnityEngine;
using System.Collections;

public class billboard : MonoBehaviour
{
	Camera m_Camera;

	void Start()
	{
		m_Camera = GameObject.Find("MainCamera").GetComponent<Camera>();
	}

	void Update()
	{
		transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
			m_Camera.transform.rotation * Vector3.up);
	}
}