using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    
    void Start()
    {
        gameOverCanvas.enabled = false;
    }
    
    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        //
        //FindObjectOfType<FirstPersonController>().enabled = false;
        FindObjectOfType<FirstPersonController>().RotationSpeed = 0;
        //
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    
}
