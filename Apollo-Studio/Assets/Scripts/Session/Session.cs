using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SessioNS {
    public class Session : MonoBehaviour {
        private List<User> users = new List<User>();
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public User GetUsersInSession() {
            return users;
        }
    }
}


