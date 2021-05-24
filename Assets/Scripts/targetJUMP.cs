using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetJUMP : MonoBehaviour
{
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == npc.name)
        {
            float x, z;
            x = Random.Range(-67 , 20);
            z = Random.Range(-35,32);
           
            this.transform.position = new Vector3(x, other.gameObject.transform.position.y, z);
        }
    }
}
