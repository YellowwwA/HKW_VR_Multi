using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameclear : MonoBehaviour
{
        public GameObject witchPrefab;
        public int candy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Candy"))
        {
            candy = candy + 1;
            if(candy >= 2)
            {
                Vector3 pos = gameObject.transform.position;
                //transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
                Instantiate(witchPrefab, new Vector3(pos.x, 0.5f, pos.z-4), Quaternion.Euler(0, 160, 0));
            }
        }
    }
}
