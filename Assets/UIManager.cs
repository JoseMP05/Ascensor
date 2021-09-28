using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI floorNumberText;
    // Start is called before the first frame update
    void Start()
    {
        //floorNumber.GetComponent<TextMeshProUGUI>().text = "hola";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeFloorNumber(int floorNumberIU)
    {
        floorNumberText.text = "Piso" + floorNumberIU.ToString();
    }

}
