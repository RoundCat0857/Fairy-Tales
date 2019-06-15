using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveArchive : MonoBehaviour
{

    void OnTriggerStay()
    {
      if(Input.GetMouseButtonDown(0))
      SceneManager.LoadScene ("Archive");
    }

}
