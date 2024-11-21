using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool IsPlaceable;
    public bool isPlaceable {get {return IsPlaceable;}}
    
    [SerializeField] GameObject TowerPrefab;
   void OnMouseDown() 
   {
    if(IsPlaceable)
        {
            Instantiate(TowerPrefab, transform.position, Quaternion.identity);
            IsPlaceable = false;
        }
   }
}
