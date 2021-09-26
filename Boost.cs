using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{

	public float normalspeed;
	public float boostspeed;

	void Start()
	{
		normalspeed = 50f;
		boostspeed = 100f;
	}

	void Update()
	{
		transform.Translate(normalspeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, normalspeed * Input.GetAxis("Vertical") * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			normalspeed = 100f;
		}
        else
        {
			normalspeed = 50f;
        }
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			normalspeed = 50f;
		}
	}
}
