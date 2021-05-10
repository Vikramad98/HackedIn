using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    //float HorizontalInput;
    /*float VerticalInput;*/
    public float speed=25;

    public Transform playerTransform;
    private bool isMoving;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.3f;

    private void Awake()
    {
        

    }

    // Start is called before the first frame update
    void Start()
    {
    }
    /*
    // Update is called once per frame
    void Update()
    {
         HorizontalInput = Input.GetAxis("Horizontal");
        *//* VerticalInput = Input.GetAxis("Vertical");*//*
        //transform.Translate(Time.deltaTime * speed, 0, 0);

        *//*transform.Translate(0, VerticalInput * Time.deltaTime * speed, 0);*//*
        Vector3 oldPos = playerTransform.position;
        if (Input.GetKey(KeyCode.W) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.up));
            //transform.Translate(0,Time.deltaTime * speed, 0);

        if (Input.GetKey(KeyCode.A) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.left));
            //transform.Translate(Time.deltaTime * (-speed), 0, 0);

        if (Input.GetKey(KeyCode.D) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.right));
            //transform.Translate(Time.deltaTime * speed, 0, 0);

        if (Input.GetKey(KeyCode.S) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.down));
            //transform.Translate(0, Time.deltaTime * (-speed), 0);





    }*/

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;
        float elapsedTime = 0;
        origPos = transform.position;
        targetPos = origPos + direction;

        while (elapsedTime < timeToMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPos;

        isMoving = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, -GridGenerator.gridGenerator.ySpace * Time.deltaTime*speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, GridGenerator.gridGenerator.ySpace * Time.deltaTime*speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-GridGenerator.gridGenerator.xSpace * Time.deltaTime*speed, 0,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate((4.5f/GridGenerator.gridGenerator.columnLength)*Time.deltaTime*speed,0, 0);
        }


       
    }


}
