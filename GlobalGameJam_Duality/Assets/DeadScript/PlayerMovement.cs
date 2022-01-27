using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject Arrow;
	public int Diamond;
    // Start is called before the first frame update
    void Start()
    {
		// SET the player's diamonds
		Diamond = 4;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.Space))
		{
			// if the player has diamond, he can shoot
			if(Diamond > 0)
			{
				// CHANGE this position
				Vector3 bulletPos = new Vector3(0.7f, 0f, 0f);
				GameObject arrowClone = Instantiate(Arrow);
				arrowClone.transform.position = bulletPos;
				Diamond--; 
			}
		}

	}
}
