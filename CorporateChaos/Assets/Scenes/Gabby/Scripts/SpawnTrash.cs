using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    public GameObject trashPrefab;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        Instantiate(trashPrefab, this.transform.position, Quaternion.identity, parent);
    }

}
