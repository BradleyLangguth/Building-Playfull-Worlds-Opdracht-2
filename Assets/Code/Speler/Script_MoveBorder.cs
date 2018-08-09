using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MoveBorder : MonoBehaviour 
{

	bool Begin = false;
	public Transform target;
	public float smoothSpeed = 0.025f;
	public Vector3 offset;


	// Use this for initialization
	void Start () {
		StartCoroutine(MoveBorder());
	}

	void Update () 
	{

		//if(Begin == true && target.position.x >= 0)
		//{
		//	transform.position = target.position + offset;
		//}
		
	}



	

	private IEnumerator MoveBorder()
	{
		yield return new WaitForSeconds (5.0f); //yield is wachten??

		while(transform.position.x < 10.0f)//while betekent letterlijk terwijl
		{
			//Debug.Log("Stage1");
			transform.position += new Vector3 (1.0f * Time.deltaTime, .0f, .0f);

			//yield return new WaitForSeconds (1.0f); //yield is wachten??

			yield return 0; //pauzeren van de functie 
		}

		while((transform.position.x > 10.0f) && (transform.position.x < 20.0f))//while betekent letterlijk terwijl
		{
			//Debug.Log("Stage2");
			transform.position += new Vector3 (2.0f * Time.deltaTime, .0f, .0f);

			yield return 0; //pauzeren van de functie 
		}

		//yield return new WaitForSeconds (1.0f); //yield is wachten??

		while(transform.position.x > 20.0f)//while betekent letterlijk terwijl
		{
			//Debug.Log("Stage3");
			transform.position += new Vector3 (4.0f * Time.deltaTime, .0f, .0f);

			//yield return new WaitForSeconds (1.0f); //yield is wachten??

			yield return 0; //pauzeren van de functie 
		}

		//while(transform.position.x > .0f)//while betekent letterlijk terwijl
		//{
		//	transform.position += new Vector3 (-5.0f * Time.deltaTime, .0f, .0f);     //-10.0f = snelheid en niet de positie.

		//	yield return 0;

			


		//}	

			//Begin = true;	
	}

}