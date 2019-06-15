using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveLiving : MonoBehaviour
{

    void OnTriggerExit()
    {
      SceneManager.LoadScene ("Living");
    }

}
