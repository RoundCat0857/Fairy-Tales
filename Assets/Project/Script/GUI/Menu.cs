﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //GameObject Menu;
    public GameObject Hint;
    public GameObject Item;
    public GameObject Save;
    public GameObject Config;
    public GameObject Return;

    public void Click() {
      Hint.SetActive(true);
      Item.SetActive(true);
      Save.SetActive(true);
      Config.SetActive(true);
      Return.SetActive(true);
      gameObject.SetActive(false);
      Debug.Log("押した");
    }

}
