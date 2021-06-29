using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Hareket1 : MonoBehaviour
{
    public Transform player;
    NavMeshAgent nMesh;
    private Animator _animator;
    private float mesafe;

    private float _animationBlend;
    // Start is called before the first frame update
    void Start()
    {
         nMesh = GetComponent<NavMeshAgent>();
        _animator = gameObject.GetComponent<Animator>();
        _animator.SetFloat("Speed", 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
   
       
       
        mesafe=Vector3.Distance(transform.position,player.position);
        if (mesafe > 3f && mesafe <20f)
        {
         
         _animator.SetFloat("Speed",mesafe*2);
         _animator.SetFloat("MotionSpeed", mesafe/10);
            nMesh.speed = 3.5f;
            nMesh.destination = player.position;
        }
           
        else if (mesafe<3f)
        {
            _animator.SetFloat("MotionSpeed", 1f);
            _animator.SetFloat("Speed", 1f);
            nMesh.speed = 3.5f;
            nMesh.destination = player.position;
        }
        else
        {
            _animator.SetFloat("MotionSpeed", 1f);
            _animator.SetFloat("Speed", 0f);
        }
    }
}
