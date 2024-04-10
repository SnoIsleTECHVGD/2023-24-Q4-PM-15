using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.InputSystem;

public class Wander : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("moveRandomDirection", 0.5f, 0.1f);
    }
    async void Update()
    {
        //Vector3[] moveDirections = { Vector3.left, Vector3.up,Vector3.down, Vector3.right};
        //transform.Translate(moveDirections[Mathf.FloorToInt(Random.Range(0, 4))] * Time.deltaTime * speed);

        //get a direction

    }

    public void moveRandomDirection()
    {
        Vector2 direction = Random.insideUnitCircle;
        transform.Translate(Random.insideUnitCircle * speed);
    }


}
