using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {

    float playerspeed = 10f;
    public bool[] killObj = new bool[3];

    public bool killPlate = false;
    public bool killCuttingboard = false;
    public bool killSpoon = false;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 3; i++)
        {
            killObj[i] = false;
        }
        
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x >= -8)
                gameObject.transform.Translate(-playerspeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x <= 8)
            {
                gameObject.transform.Translate(playerspeed * Time.deltaTime, 0, 0);
                if(killObj[0] == false && gameObject.transform.position.x >= -4.79f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(-4, gameObject.transform.position.y, 0);
                }
                else if (killObj[1] == false && gameObject.transform.position.x >= -0.9f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(-0.9f, gameObject.transform.position.y, 0);
                }
                else if(killObj[2] == false && gameObject.transform.position.x >= 2.7f)
                {
                    gameObject.GetComponent<Transform>().position = new Vector3(2.7f, gameObject.transform.position.y, 0);
                }
            }
                
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerspeed * 50);
        }
            
    }
    
}
