using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //public Transform target;
    public Transform playerTransform;
    public float speed;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private void Start()
    {
        // transform.position = target.position;

        transform.position = playerTransform.position;
    }

    private void LateUpdate()
    {
       // if (target != null)
            if (playerTransform != null)
            {
            //float clampedX = Mathf.Clamp(target.position.x, minX, maxX);
            //float clampedY = Mathf.Clamp(target.position.y, minY, maxY);
            float clampedX = Mathf.Clamp(playerTransform.position.x, minX, maxX);
            float clampedY = Mathf.Clamp(playerTransform.position.y, minY, maxY);
            transform.position = Vector2.Lerp(transform.position, new Vector2(clampedX, clampedY), speed);
        }
    }


}
