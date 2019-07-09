using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SessionNS;

public class SessionController : MonoBehaviour {
    public Session session;
    // Start is called before the first frame update
    void Start()
    {
        session = new Session();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddUserToSession(User user) {
        List<User> users = session.GetUsersInSession();
        users.Add(user);
    }

    public void RemoveUserFromSession(User user) {
        List<User> users = session.GetUsersInSession();
        users.Remove(user);
    }

    public int GetUserSessionCount() {
        List<User> users = session.GetUsersInSession();
        return users.Count();
    }

    public void ClearAllUsersFromSession() {
        List<User> users = session.GetUsersInSession();
        users.Clear();
    }
}
