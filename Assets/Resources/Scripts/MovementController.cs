using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    
    
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject bottom;

    public float rotate = 0;
    public float yaw = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Input.GetAxisRaw("Vertical") *2 * Time.deltaTime));
        transform.Translate(Vector3.right * (Input.GetAxisRaw("Horizontal") *2 * Time.deltaTime));

        if(Input.GetButtonDown("Jump")) GetComponent<Rigidbody>().AddForce(Vector3.up * 7, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.W) && rotate < 45f) rotate += 2;
        if (Input.GetKey(KeyCode.S) && rotate > -45f) rotate -= 2;
        if (Input.GetKey(KeyCode.A) && yaw > -45f) yaw -= 2f;
        if (Input.GetKey(KeyCode.D) && yaw < 45f) yaw += 2f;
        
        Debug.Log(yaw);
        
        if (Input.GetButton("Fire1"))
        {
            GameObject pan = Instantiate(panel, bottom.transform.position, Quaternion.identity);
            pan.transform.Rotate(yaw,90,rotate);
            
        }
        
    }
}
