using UnityEngine;

public class CollectiblesAnimation : MonoBehaviour
{

    public Vector3 rotationAngle;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * rotationAngle);
    }
}
