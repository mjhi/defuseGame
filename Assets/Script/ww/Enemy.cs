using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int        wayPointCount; //이동 경로 개수(포인트 지점 개수)
    private Transform[] wayPoints; //이동 경로 정보(좌표값)
    private int currentIndex = 0; //현재 목표지점(가야할곳)
    private Movement2D movement2D;//오브젝트 이동 제어
    // Start is called before the first frame update

    public void Setup(Transform[] wayPoints)
    {
        movement2D =GetComponent<Movement2D>();

        //적 이동 경로 waypoints 정보 설정
        wayPointCount = wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = wayPoints;


        //적 위치를 첫번째 waypoint 위치로 설정
        transform.position = wayPoints[currentIndex].position;

        //코루틴 함수 시작
        StartCoroutine("OnMove");
    }

    private IEnumerator OnMove()
    {
        NextMoveTo();

        while(true)
        {
            //
            // transform.Rotate(Vector3.forward*10);

            //적의 현재위치와 목표위치의 거리가 0.02*movement2D.moveSpeed보다 작을때 if 조건문이 실행된다.
            //Tip. movement2D.moveSpeed 를 곱해주는 이유는 속도가 빠르면 한프레임에 0.02보다 크게 움직이기때문에 탈주하는 현상 방지~!
            if(Vector3.Distance(transform.position,wayPoints[currentIndex].position)<0.02f*movement2D.MoveSpeed){
                NextMoveTo();
            }

            yield return null;
        }

        
    }

    private void NextMoveTo()
    {
        //아직 포인트가 남아있다면
        if(currentIndex<wayPointCount-1)
        {

            //정확하게 목표위치로 설정
            transform.position = wayPoints[currentIndex].position;
            //이동방향 설정
            currentIndex++;

            Vector3 direction = (wayPoints[currentIndex].position-transform.position).normalized;

            movement2D.MoveTo(direction);
        }
        else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
