﻿using UnityEngine;
using System.Collections;

public class HurtByContact : MonoBehaviour {

	public GameObject hurtParticle;

	void Start() {
		
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Enemy")
		{
			print ("hahahah");
			Instantiate(hurtParticle, gameObject.transform.position, gameObject.transform.rotation);
		}
	}
}
