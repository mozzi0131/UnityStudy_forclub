using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningDishes : MonoBehaviour {

    int[] cleannum = new int[3];
    GameObject[] cleanObj = new GameObject[3];
    int nowobjindex;

    void Start()
    {
        cleannum[0] = 3;
        cleannum[1] = 4;
        cleannum[2] = 5;

        cleanObj[0] = GameObject.Find("Plate");
        cleanObj[1] = GameObject.Find("CuttingBoard");
        cleanObj[2] = GameObject.Find("Spoon");
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(other.gameObject.name);
            switch (other.gameObject.name)
            { 
                case "Plate":
                    nowobjindex = 0;
                    cleannum[0]--;
                    break;
                case "CuttingBoard":
                    nowobjindex = 1;
                    cleannum[1]--;
                    break;
                case "Spoon":
                    nowobjindex = 2;
                    cleannum[2]--;
                    break;
            }

            if (cleannum[nowobjindex] == 0)
            {
                gameObject.GetComponent<PlayerMoving>().killObj[nowobjindex] = true;
                cleanObj[nowobjindex].SetActive(false);
            }
                
        }
         
    }
}
