using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: isolate this script to test separately
public class genericNode : MonoBehaviour
{
    public GameObject Sphere;
    public AudioClip clip; //make sure you assign an actual clip here in the inspector
    private Vector3 spherePosition;

    // Start is called before the first frame update
    void Start()
    {
        // initialize the sphere GameObject
        Instantiate(Sphere);
        
    }

    // Update is called once per frame
    void Update()
    {
        // create an empty vector to fetch position from later
        spherePosition = new Vector3(1, 1, 1);
        // driver function to get input
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Select Stage (node GameObject)
                if (hit.transform.name == "Sphere")
                {
                    // play sound 1 
                    //SceneManager.LoadScene("SceneTwo");
                    Debug.Log("click 1");
                    // fetch the sphere object position
                    spherePosition = transform.position;
                    // attach generic audio clip #1
                    AudioSource.PlayClipAtPoint(clip, spherePosition);
                }
            }
        }
        // rinse and repeat process here... possibly with prefabs
        // a different input 
        //if (Input.GetMouseButtonDown(1))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        //Select Stage
        //        if (hit.transform.name == "Sphere")
        //        {
        //            // play sound 2 
        //            //SceneManager.LoadScene("SceneTwo");
        //            Debug.Log("click 2");
        //        }
        //    }
        //}
        //// TODO: handle more cases here
        //// ...
    }

}
