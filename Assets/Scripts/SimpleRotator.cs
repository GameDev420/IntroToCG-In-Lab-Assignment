using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    [SerializeField] Vector3 rotationPerSecond = Vector3.zero;
    [SerializeField] Space spaceMode = Space.Self;

    private void Update()
    {
        transform.Rotate(rotationPerSecond * Time.deltaTime, spaceMode);
    }
}
