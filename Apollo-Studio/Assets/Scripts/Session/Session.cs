using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Session : MonoBehaviour {
    private List<User> users = new List<User>();
    // Start is called before the first frame update
    void Start()
    {
        // static SceneManager Class from Unity 
        SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public User GetUsersInSession() {
    //     return users;
    // }
}


