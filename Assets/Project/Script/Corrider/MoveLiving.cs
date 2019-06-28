using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveLiving : MonoBehaviour
{

    void OnCollisionEnter()
    {
      SceneManager.LoadScene ("Living");
    }

}
