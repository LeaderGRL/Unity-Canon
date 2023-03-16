using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject canonPivot;
    [SerializeField] private GameObject canon;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform roundShotSpawnPoint;
    [SerializeField] private GameObject roundShotPrefab;
    private Vector3 mousePosition;
    private float mouseX;
    private float mouseY;

    public float force = 1;
   
    
 
    // Start is called before the first frame update
    void Start()
    {
        //roundShotPrefab.transform.position = roundShotSpawnPoint.position;
        //roundShotPrefab.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        float normalizedMousePosition = Mathf.Clamp(-Input.GetAxis("Mouse Y"), -1, 1) / 10;

        if (Input.GetMouseButton(0))
        {
            canon.transform.rotation = new Quaternion(canon.transform.rotation.x + normalizedMousePosition, canon.transform.rotation.y, canon.transform.rotation.z, canon.transform.rotation.w);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        var roundShot = Instantiate(roundShotPrefab, roundShotSpawnPoint.position, roundShotSpawnPoint.rotation);
        roundShot.GetComponent<Rigidbody>().AddForce(canon.transform.up * force, ForceMode.Impulse);        
    }
}