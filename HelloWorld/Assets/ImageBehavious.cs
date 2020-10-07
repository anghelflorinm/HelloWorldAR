using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class ImageBehavious : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTransform;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform transform = GetComponent<Transform>();
        float dist = Vector3.Distance(transform.position, cameraTransform.position);
        UnityEngine.Debug.Log(dist);
        if (dist < 0.5)
        {
            animator.SetTrigger("AnimationTrigger");
        }
        else
        {
            animator.ResetTrigger("AnimationTrigger");
        }
    }
}
