using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            MoveToCurzor();
        }
    }

    void MoveToCurzor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if(hasHit == true)
        {
            GetComponent<Movement>().MoveTo(hit.point);
        }
    }
}
