using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {

	public float speed = 1f;
	public GameObject TitleMain;
	public GameObject Menu;
	public float pixeljump;
	public Vector3 StartPosition;

	void Start() {
		StartPosition = transform.position;
	}
	void Awake() 
	{
		TitleMain.SetActive(true);
		Menu.SetActive(false);
	}

	void FixedUpdate() {
		//float newPos = Mathf.Repeat(Time.time * speed, StartPosition);
		float newPos = Mathf.Repeat(Time.time * speed, pixeljump);
		
		transform.position = StartPosition + Vector3.left * newPos;

		

	}

	void Update() 
	{
	    if (Input.anyKey)
        {

            //TitleMain.SetActive(false);
			timer();
			bool isActive = TitleMain.activeSelf;
 
            TitleMain.SetActive(!isActive);
			
        }


		Menu.SetActive(!TitleMain.activeSelf);

		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			bool isActive = false;

			TitleMain.SetActive(!isActive);
		}
	
	
	}

	IEnumerator timer()
	{
		yield return new WaitForSeconds(0.25f);
	}



}
