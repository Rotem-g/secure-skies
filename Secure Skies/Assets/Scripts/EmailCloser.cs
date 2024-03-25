using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailCloser : MonoBehaviour
{
    public GameObject Panel0;
    
    public void ClosePanel0(){
        if (Panel0 != null)
        {
            Panel0.SetActive(false);
        }
    }
}

