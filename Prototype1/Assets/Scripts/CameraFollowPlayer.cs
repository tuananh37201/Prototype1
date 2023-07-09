using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offSet = new Vector3(0, 4, -7);

    void LateUpdate()
    {
        transform.position = player.transform.position + offSet;
    }
}
