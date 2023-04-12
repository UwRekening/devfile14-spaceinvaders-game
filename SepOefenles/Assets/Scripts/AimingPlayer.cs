using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingPlayer : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] float distance = 5f;
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(lineRenderer.transform.position, transform.up, distance);
        Debug.DrawRay(lineRenderer.transform.position, transform.up * distance);
        lineRenderer.SetPosition(0, lineRenderer.transform.position);

        if (hit.transform == null)
        {
            lineRenderer.SetPosition(1, lineRenderer.transform.position + transform.up * distance);
            Debug.DrawRay(lineRenderer.transform.position, transform.up * distance, Color.white);
            lineRenderer.startColor = Color.white;
            lineRenderer.endColor = Color.white;
        } 
        else
        {
            lineRenderer.SetPosition(1, hit.point);
            Debug.DrawRay(lineRenderer.transform.position, transform.up * distance, Color.red);
            lineRenderer.startColor = Color.red;
            lineRenderer.endColor = Color.red;
        }
    }

}
