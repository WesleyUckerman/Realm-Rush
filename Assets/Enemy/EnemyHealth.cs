using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int MaxHitPoints = 5;
    int CurrentHitPoints = 0;
    void OnEnable()
    {
        CurrentHitPoints = MaxHitPoints;
    }

    void OnParticleCollision(GameObject other) 
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        CurrentHitPoints--;
        if(CurrentHitPoints<=0)
        {
            gameObject.SetActive(false);
        }
    }
    
}
