using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] float maxCameraDistance;
    float cameraDistance;
    [SerializeField] float sensitivity = 1f;
    CinemachineComponentBase componentBase;

    private void Update()
    {
        if (componentBase == null)
        {
            componentBase = virtualCamera.GetCinemachineComponent(CinemachineCore.Stage.Body);
            maxCameraDistance = (componentBase as CinemachineFramingTransposer).m_CameraDistance;
        }

        if (Input.touchSupported)
        {

            if (Input.touchCount == 2)
            {
                Touch tZero = Input.GetTouch(0);
                Touch tOne = Input.GetTouch(1);
                Vector2 tZeroPrevious = tZero.position - tZero.deltaPosition;
                Vector2 tOnePrevious = tOne.position - tOne.deltaPosition;

                float oldTouchDistance = Vector2.Distance(tZeroPrevious, tOnePrevious);
                float currentTouchDistance = Vector2.Distance(tZero.position, tOne.position);
                float deltaDistance = oldTouchDistance - currentTouchDistance;

                cameraDistance = deltaDistance * sensitivity;

                if (componentBase is CinemachineFramingTransposer)
                {
                    if (cameraDistance < 0)
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                        if ((componentBase as CinemachineFramingTransposer).m_CameraDistance > maxCameraDistance)
                        {
                            (componentBase as CinemachineFramingTransposer).m_CameraDistance = maxCameraDistance;
                        }
                    }
                    else
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                        if ((componentBase as CinemachineFramingTransposer).m_CameraDistance < 2)
                        {
                            (componentBase as CinemachineFramingTransposer).m_CameraDistance = 2;
                        }
                    }
                }

            }
        }
        else
        {
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                cameraDistance = Input.GetAxis("Mouse ScrollWheel") * sensitivity;

                if (componentBase is CinemachineFramingTransposer)
                {
                    if (cameraDistance < 0)
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                        if ((componentBase as CinemachineFramingTransposer).m_CameraDistance > maxCameraDistance)
                        {
                            (componentBase as CinemachineFramingTransposer).m_CameraDistance = maxCameraDistance;
                        }
                    }
                    else
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                        if ((componentBase as CinemachineFramingTransposer).m_CameraDistance < 2)
                        {
                            (componentBase as CinemachineFramingTransposer).m_CameraDistance = 2;
                        }
                    }
                }
            }
        }
    }
}