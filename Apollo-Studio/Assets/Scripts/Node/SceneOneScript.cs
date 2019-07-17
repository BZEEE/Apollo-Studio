using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: where to store this file?? Ask Brandon
public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        return 0;
    }

    // Update is called once per frame
    void Update()
    {
        // driver function to get input
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage (node GameObject)
                if (hit.transform.name == "Sphere")
                {
                    // play sound 1 
                    //SceneManager.LoadScene("SceneTwo");
                    Debug.Log("click 1");
                }
            }
        }
        // a different input 
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "Sphere")
                {
                    // play sound 2 
                    //SceneManager.LoadScene("SceneTwo");
                    Debug.Log("click 2");
                }
            }
        }
        // TODO: handle more cases here
        // ...
    }

}
