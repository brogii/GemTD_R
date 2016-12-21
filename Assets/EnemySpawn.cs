using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour {
    public Transform[] WayPoints;

	public GameObject enemy;
	private GameObject enemy1;
	private int index = 1;

	private NavMeshAgent nav;
	// Use this for initialization
	void Start () {
		
       
       enemy1 =  GameObject.Instantiate(enemy,WayPoints[0].position,Quaternion.identity);
	   nav = enemy1.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
if(!enemy1){
	return;

}

		if(Vector3.Distance(enemy1.transform.position,WayPoints[index].position)>0.1f){
             nav.SetDestination(WayPoints[index].position);
			 
			//enemy1.transform.Translate((WayPoints[index].position-enemy1.transform.position).normalized*0.1f);
		}
		else{
         index++;
		}
		if(index>WayPoints.Length-1){
         Destroy(enemy1);

		}
	}
	 
}
