using UnityEngine;
using System.Collections;

public class PSDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	ParticleSystem ps = GetComponent<ParticleSystem>();
    Destroy(gameObject, ps.main.duration);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
