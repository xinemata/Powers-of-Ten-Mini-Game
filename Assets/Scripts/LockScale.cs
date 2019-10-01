using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScale : MonoBehaviour
{
Vector3 scale; 
 
void Awake(){
    scale = transform.localScale;

}
void LateUpdate()
{
     transform.localScale = scale; 
}
}
 
