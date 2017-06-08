﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    public float speed;
    public Text counttext;
    public Text wintext;
    private Rigidbody rb;
    private int count;

    //called on first frame
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        wintext.text = "";
    }
    
    //for physics
    void FixedUpdate()
    {
        //grabs keyboard input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
            if (count == 12) wintext.text = "YOU WIN";
        }
    }

    void SetCountText()
    {
        counttext.text = "Count: " + count.ToString();
    }
}