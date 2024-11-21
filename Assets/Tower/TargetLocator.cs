using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform Weapon;
    Transform Target;

   
    void Start()
    {
        Target = FindObjectOfType<EnemyMover>().transform;
    }

    
    void Update()
    {
        Aimweapon();
    }

    void Aimweapon()
    {
        Weapon.LookAt(Target);
    }
}
