using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CaptainCoder.CrazyMarble
{
    public static class CameraExtensions
    {
        public static Vector3 TransformToCameraForward(this Vector2 inputAxis, Camera camera)
        {
            Quaternion cameraRotation = camera.transform.rotation;
            Vector3 inputDirection = cameraRotation * new Vector3(inputAxis.x, 0, inputAxis.y);
            return inputDirection;
        }
    }

}