using System.Collections.Specialized;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.position);
        transform.position = Player.position + offset;
    }
}
