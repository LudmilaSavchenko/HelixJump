using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlatformSegment platformSegment))
        {
            other.GetComponentInParent<Platform>().Break();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out PlatformSegment platformSegment))
        {
            if (platformSegment.GetComponentInParent<FinishPlatform>())
            {
                Debug.Log("Достигнута финишная платформа.");
            }
        }
    }
}
