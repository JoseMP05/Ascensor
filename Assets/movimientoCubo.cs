using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCubo : MonoBehaviour
{
    //private UIManager _UIManager;
    //public GameObject floorValidator;

    public liftController liftController;

    public float speed;
    public float rotationSpeed;
    private float _movimientoHorizontal;
    private float _movimientoVertical;
    private Rigidbody rbs;
    public GameObject door;

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponent<Rigidbody>();
        speed = 10f;
        rotationSpeed = 100f;
        initialPosition = transform.position;

        liftController = GameObject.FindObjectOfType<liftController>();

}

    // Update is called once per frame
    void Update()
    {
        rbs.WakeUp();
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation  = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        //_movimientoHorizontal = Input.GetAxis("Horizontal");
        //_movimientoVertical = Input.GetAxis("Vertical");
        //rb.AddForce(new Vector3(_movimientoHorizontal, 0, _movimientoVertical) * speed);
        if(transform.position.y < -3f)
        {
            transform.position = initialPosition;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("OpenDoor"))
        {
            door.SetActive(false);
        }
        if (collider.CompareTag("CloseDoor"))
        {
            door.SetActive(true);
        }

        if (collider.gameObject.name == "1")
        {
            liftController.MoveLift(1);
        }


        if (collider.gameObject.name == "2")
        {
            liftController.MoveLift(2);
        }

        if (collider.gameObject.name == "3")
        {
            liftController.MoveLift(2);
        }


        if (collider.gameObject.name == "4")
        {
            liftController.MoveLift(2);
        }


        if (collider.gameObject.name == "5")
        {
            liftController.MoveLift(2);
        }


        if (collider.gameObject.name == "6")
        {
            liftController.MoveLift(2);
        }



        //if (collider.gameObject.name == "floor Validator")
        //{
        //    Debug.Log("hola");

        //    _UIManager.ChangeFloorNumber(1);
        //}


    }

}

