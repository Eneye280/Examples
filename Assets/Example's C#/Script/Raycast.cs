using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(NavMeshAgent))]
public class Raycast : MonoBehaviour 
{
    /*El objeto se movera donde se haga click, debe agregar desde el inspector el nav */
    public NavMeshAgent nav;
    public Gradient gradit;

    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit Rpoint;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out Rpoint,100))
            {
                nav.SetDestination(Rpoint.point);
            }

        }
    }


    
}
