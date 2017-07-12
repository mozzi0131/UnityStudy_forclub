using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

    float playerspeed = 10f;

    public bool killPlate = false;
    public bool killCuttingboard = false;
    public bool killSpoon = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            if (gameObject.transform.position.x >= -8)
                gameObject.transform.Translate(-playerspeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
            if (gameObject.transform.position.x <= 8)
            {
                gameObject.transform.Translate(playerspeed * Time.deltaTime, 0, 0);
                if(killPlate == false && gameObject.transform.position.x >= -4.79f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(-4, gameObject.transform.position.y, 0);
                }
                else if (killCuttingboard==false && gameObject.transform.position.x >= -0.9f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(-0.9f, gameObject.transform.position.y, 0);
                }
                else if(killSpoon == false && gameObject.transform.position.x >= 2.7f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(2.7f, gameObject.transform.position.y, 0);
                }
            }
                
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space");
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerspeed * 50);
        }
            
    }
    
}
