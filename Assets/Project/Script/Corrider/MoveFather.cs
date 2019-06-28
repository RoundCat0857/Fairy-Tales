using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveFather : MonoBehaviour
{

    void OnTriggerStay()
    {
      if(Input.GetMouseButtonDown(0))
      SceneManager.LoadScene ("Fother_Room");
    }

}
