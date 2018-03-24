using UnityEngine;
using System.Collections;

public class UnitScript : MonoBehaviour
{
	public Transform Player;
	public GameObject MainCamera, SecondCamera;


	//public string @string = "Что делаешь?";
	public int @int = 5;
	//public float @float = 6;
	//public float _float = 4;
	//sbyte[] array = new sbyte[5];

		void Start () 
	{

		/*Debug.Log (@string);

		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		{
			rb.isKinematic = false;
			rb.mass = @int; //34.523f;
		}

		SpriteRenderer SR = GetComponent<SpriteRenderer>();

		BoxCollider2D BoxCol2D = GetComponent<BoxCollider2D>();
		{
			BoxCol2D.isTrigger = false; 
		}*/



	}
	

		void Update ()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.mass = 5;
			
			if (rb.mass <= 5) 
		{ 
			Debug.Log ("Not now");
		}
			else
		{
			transform.position = Player.transform.position = Vector2.MoveTowards(transform.position, Player.position, Time.deltaTime);
		}
	

		//Debug.Log ("Опаа??");
		  
		/*{   Time.time(5)
			{
			MainCamera = false;
			SecondCamera = true;
			}
			{
			MainCamera = true;
			SecondCamera = false;
			}
		}*/ //                        НЕРАБОЧИЙ код

	}


}
