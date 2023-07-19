using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject menu; // Assign in inspector
    private bool toggledShow;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            toggledShow = !toggledShow;
            menu.SetActive(toggledShow);
        }
    }
    }
