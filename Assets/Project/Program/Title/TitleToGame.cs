using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class TitleToGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) //マウス左クリック、スペースキー、ボタンを押した場合
      {
          SceneManager.LoadScene("Kanako_Room");//Kanako_Roomシーンをロードする
      }
    }
}
