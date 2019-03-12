using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fpsmouse : MonoBehaviour {

	[SerializeField]private float Speed;
	private const float Angle_limitup = 90f;
	private const float Angle_limitdown = -90f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)CmaeraAngle();
		float angle_x = 180f <= transform.eulerAngles.x ? transform.eulerAngles.x - 360 : transform.eulerAngles.x;//三項演算子
		transform.eulerAngles = new Vector3(Mathf.Clamp(angle_x, Angle_limitdown, Angle_limitup),
		transform.eulerAngles.y,
	    transform.eulerAngles.z);
	}

	private void CmaeraAngle()
	{
		Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * Speed, Input.GetAxis("Mouse Y") * Speed,0);
		transform.eulerAngles += new Vector3(angle.y, angle.x);
	}
}
