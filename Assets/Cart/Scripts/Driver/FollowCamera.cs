using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.7
/// </summary>

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    // Update is called once per frame
    void LateUpdate()
    {
        //using lateupdate to..
        //follow slowly, smoothly  and to prevent jittery
        Vector3 offSet = new Vector3(0, 0, -10);
        transform.position = target.transform.position + offSet;
    }
}
