using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
  public GameObject targetObj;
  Vector3 targetPos;

  void Start () {
      // targetObj = GameObject.Find("TargetGameObject");
      targetPos = targetObj.transform.position;
  }

  void Update() {
      transform.position += targetObj.transform.position - targetPos;
      targetPos = targetObj.transform.position;
      float mouseInputX = Input.GetAxis("Mouse X");
      float mouseInputY = Input.GetAxis("Mouse Y");
      transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
      // transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 100f);
  }
}
