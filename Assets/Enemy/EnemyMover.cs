using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0,10)]float Speed = 1f;
    // Start is called before the first frame update
    void OnEnable()
    {
       FindPath();
       ReturnToStart();
       StartCoroutine (FollowPath());
    }

    void FindPath()
    {
        path.Clear();

        GameObject[] waypoints = GameObject.FindGameObjectsWithTag("Path");

        foreach(GameObject waypoint in waypoints)
        {
            path.Add(waypoint.GetComponent<Waypoint>());
        }
    }
    
    void ReturnToStart()
    {
        transform.position = path[0].transform.position;
    }

   IEnumerator FollowPath()
   {
    foreach(Waypoint waypoint in path)
    {
        Vector3 Startposition = transform.position;
        Vector3 Endposition = waypoint.transform.position;
        float Travelpercentage = 0f;

        transform.LookAt(Endposition);

        while(Travelpercentage < 1)
        {
            Travelpercentage += Time.deltaTime * Speed;
            transform.position = Vector3.Lerp(Startposition,Endposition,Travelpercentage);
            yield return new WaitForEndOfFrame();
            

        }
    }
    gameObject.SetActive(false);
   }
}
