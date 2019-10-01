using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
Quaternion rotation; 
Vector3 position;

public int height = 3;
 
void Awake(){
    rotation = transform.rotation;

    position.y = height;


}
void LateUpdate()
{
     transform.rotation = rotation; 
     
     position.y = height;
}
}
 
 