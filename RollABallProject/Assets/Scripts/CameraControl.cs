using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// garunteed to run after all items in update have been processed
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
