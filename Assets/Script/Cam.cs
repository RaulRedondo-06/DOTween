using UnityEngine;

public class CameraPositionToggle : MonoBehaviour
{
    public Transform posicionA;
    public Transform posicionB;

    private bool isAtPositionA = true;

    public void PosCámara()
    {
        if (isAtPositionA)
            MoveTo(posicionB);
        else
            MoveTo(posicionA);

        isAtPositionA = !isAtPositionA;
    }

    private void MoveTo(Transform target)
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
