using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftController : MonoBehaviour
{   [SerializeField] Transform[] targets;
    public Transform target;
    public float _speed;

    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        target.position = new Vector3(0, targets[0].position.y, -7.58f);

        uiManager = FindObjectOfType<UIManager>();
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
                uiManager.ChangeFloorNumber(floorNumber);
            break;
            case 2:
                target.position = new Vector3(target.position.x, targets[1].position.y, target.position.z);
                uiManager.ChangeFloorNumber(floorNumber);
                break;
            case 3:
                target.position = new Vector3(target.position.x, targets[2].position.y, target.position.z);
                uiManager.ChangeFloorNumber(floorNumber);
                break;
            case 4:
                target.position = new Vector3(target.position.x, targets[3].position.y, target.position.z);
                uiManager.ChangeFloorNumber(floorNumber);
                break;
            case 5:
                target.position = new Vector3(target.position.x, targets[4].position.y, target.position.z);
                uiManager.ChangeFloorNumber(floorNumber);
                break;
            case 6:
                target.position = new Vector3(target.position.x, targets[5].position.y, target.position.z);
                uiManager.ChangeFloorNumber(floorNumber);
                break;
            default: 
                break;
        }
    }
}
