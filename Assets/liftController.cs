using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftController : MonoBehaviour
{   [SerializeField] Transform[] targets;
    public Transform target;
    public float _speed;
    // Start is called before the first frame update
    void Start()
    {
        target.position = new Vector3(0, targets[0].position.y, -7.58f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void MoveLift(int floorNumber)
    {
        switch (floorNumber)
        {
            case 1:
                target.position = new Vector3(target.position.x, targets[0].position.y, target.position.z);
                Debug.Log("piso 1");
            break;
            case 2:
                Debug.Log("piso 2");
                target.position = new Vector3(target.position.x, targets[1].position.y, target.position.z);
                break;
            case 3:
                Debug.Log("piso 3");
                target.position = new Vector3(target.position.x, targets[2].position.y, target.position.z);
                break;
            case 4:
                Debug.Log("piso 4");
                target.position = new Vector3(target.position.x, targets[3].position.y, target.position.z);
                break;
            case 5:
                Debug.Log("piso 5");
                target.position = new Vector3(target.position.x, targets[4].position.y, target.position.z);
                break;
            case 6:
                Debug.Log("piso 6");
                target.position = new Vector3(target.position.x, targets[5].position.y, target.position.z);
                break;
            default: 
                break;
        }
    }
}
