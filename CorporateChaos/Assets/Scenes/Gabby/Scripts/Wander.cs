using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    private void Start()
    {
        
    }
    async void Update()
    {
        Vector3[] moveDirections = { Vector3.left, Vector3.up,Vector3.down, Vector3.zero, Vector3.zero, Vector3.right};
        transform.Translate(moveDirections[Mathf.FloorToInt(Random.Range(0, 6))] * Time.deltaTime * speed);

    }


}