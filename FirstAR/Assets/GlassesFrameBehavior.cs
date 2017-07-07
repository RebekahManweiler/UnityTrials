using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassesFrameBehavior : MonoBehaviour {

    private Camera arcam = null;
    private bool isCamEnabled = false;
    private bool animationPlayed = false;

	// Use this for initialization
	void Start () {
        Camera arcam = GetComponentInParent<Camera>(); 
	}
	
	// Update is called once per frame
	void Update () {
        /*isCamEnabled = arcam.isActiveAndEnabled;
        if(isCamEnabled && !animationPlayed)
        {
            Animation _animation = GetComponent<Animation>();
            if (_animation != null)
            {
                _animation.Play();
                animationPlayed = true;
            }
        }*/
	}
}
