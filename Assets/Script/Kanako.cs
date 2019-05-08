﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kanako : MonoBehaviour
{
  public float speed = 0.1f;

  // Start is called before the first frame update
  void Start(){

  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey(KeyCode.W)){
      transform.Translate(transform.forward*speed);
    }
    if (Input.GetKey(KeyCode.S)){
      transform.Translate(-transform.forward*speed);
    }
    if (Input.GetKey(KeyCode.D)){
      transform.Translate(transform.right*speed);
    }
    if (Input.GetKey(KeyCode.A)){
      transform.Translate(-transform.right*speed);
    }
  }
}
