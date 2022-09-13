using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.9.13
/// </summary>

[CreateAssetMenu(menuName = "tools/points", fileName = "Point_To_Add")]
public class TPointsSO : ScriptableObject
{
    public float point;

    public float PointToAdd()
    {
        return point;
    }
}
