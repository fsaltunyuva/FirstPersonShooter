using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    [SerializeField] private float defaultFOV = 50f;
    [SerializeField] private float zoomedInFOV = 20f;
    
    [SerializeField] private float zoomOutSensitivity = 1f;
    [SerializeField] private float zoomInSensitivity = 0.3f;
    
    [SerializeField] StarterAssets.FirstPersonController firstPersonController;

    private void OnDisable()
    {
        camera.m_Lens.FieldOfView = defaultFOV;
        firstPersonController.RotationSpeed = zoomOutSensitivity;
    }

    // private void Start()
    // {
    //     firstPersonController = GetComponent<StarterAssets.FirstPersonController>();
    // }
    
    public void Zoom(bool zoomedIn)
    {
        camera.m_Lens.FieldOfView = zoomedIn ? zoomedInFOV : defaultFOV;
        firstPersonController.RotationSpeed = zoomedIn ? zoomInSensitivity : zoomOutSensitivity;
    }
}
