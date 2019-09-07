using UnityEngine;  
using System.Collections;  
using UnityEngine.AI;
  
//Author:ken@iamcoding.com  
public class PlayerController : MonoBehaviour  
{  
    private NavMeshAgent agent;  
  
  
    void Start()  
    {  
        //获取组件  
        agent = GetComponent<NavMeshAgent>();  
    }  
  
  
    void Update()  
    {  
        //鼠标左键点击  
        if (Input.GetMouseButtonDown(0))  
        {  
            //摄像机到点击位置的的射线  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit))  
            {  
            
                //点击位置坐标  
                Vector3 point = hit.point;  
                //转向  
      
                //设置寻路的目标点  
                agent.SetDestination(point);  
            }  
        }  
  

          
    }  
}  
