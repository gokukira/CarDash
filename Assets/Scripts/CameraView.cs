﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraView : MonoBehaviour
{
    public GameObject firstPersonCamera;
    public GameObject overheadCamera;
    public Toggle View;
    public Toggle D;
    int CamMode;
   
  
    void Update()
    {
       
        if(D.isOn)
        {
            if(View.isOn)
                CamMode = 1;

            else
                CamMode = 0;
            
        }
        CamChange();
    }

    void CamChange()
    {

        //yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            overheadCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
        }

        if (CamMode == 1)
        {
            firstPersonCamera.SetActive(true);
            overheadCamera.SetActive(false);

        }

    


    }

}