using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.2.16
/// </summary>

public class SBResponsiveCamera : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    private float buffer = 2.2f;

    // Update is called once per frame
    void Update()
    {
        var (center, size) = CalulateOtherSize();
        cam.transform.position = center;
        cam.orthographicSize = size;
    }

    private (Vector3 center, float size) CalulateOtherSize()
    {
        /*
         tileMap.CompressBounds();
        var bounds = tileMap.localBounds;
         */
        var bounds = new Bounds();
        foreach(var col in FindObjectsOfType<Collider2D>()) bounds.Encapsulate(col.bounds);

        bounds.Expand(buffer);
        var vertical = bounds.size.y;
        var horizontal = bounds.size.x * cam.pixelHeight / cam.pixelWidth;

        var size = Mathf.Max(horizontal, vertical) * 0.5f;
        var center = bounds.center + new Vector3(0, 0, -10);

        return (center, size);
    }
}
