using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakod : MonoBehaviour
{

	public Transform sise;
	

	

	void Start()
	{
		

	}

	void LateUpdate()
	{
		gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, sise.transform.position.z);
	}

}
