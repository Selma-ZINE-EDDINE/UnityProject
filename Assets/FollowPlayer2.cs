using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate() //Late to avoid tremblements
    {
        transform.position = player.transform.position + offset;
    }
}
