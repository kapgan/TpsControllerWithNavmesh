using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Hareket : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nMesh;
  

    private float _animationBlend;
    // Start is called before the first frame update
    void Start()
    {
         nMesh = GetComponent<NavMeshAgent>();
  
    }

    // Update is called once per frame
    void Update()
    {
        nMesh.destination = player.position;

    }
}
