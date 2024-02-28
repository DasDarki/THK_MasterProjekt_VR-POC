using UnityEngine;

public class CompassPowerUp : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject playerForRot;
    public GameObject playerForPos;
    public GameObject[] compassUIElements;

    private void Update()
    {
        foreach (var compassUIElement in compassUIElements)
        {
            compassUIElement.SetActive(false);
        }

        Vector3 playerPosition = playerForPos.transform.position;
        Quaternion playerRotation = playerForRot.transform.rotation;
        Transform target = targetObject.transform;

        Vector3 toTarget = (target.position - playerPosition).normalized;
        Vector3 toTargetLocal = Quaternion.Inverse(playerRotation) * toTarget;
        toTargetLocal.y = 0;

        float angle = Vector3.SignedAngle(Vector3.forward, toTargetLocal, Vector3.up);

        RenderCompassElements(angle);
    }

    private void RenderCompassElements(float angle)
    {
        if (angle < 22.5f && angle >= -22.5f)
        {
            NorthActive();
        }
        else if (angle < 67.5f && angle >= 22.5f)
        {
            NorthActive();
            EastActive();
        }
        else if (angle < 112.5f && angle >= 67.5f)
        {
            EastActive();
        }
        else if (angle < 157.5f && angle >= 112.5f)
        {
            EastActive();
            SouthActive();
        }
        else if (angle >= 157.5f || angle < -157.5f)
        {
            SouthActive();
        }
        else if (angle < -112.5f && angle >= -157.5f)
        {
            SouthActive();
            WestActive();
        }
        else if (angle < -67.5f && angle >= -112.5f)
        {
            WestActive();
        }
        else if (angle < -22.5f && angle >= -67.5f)
        {
            WestActive();
            NorthActive();
        }
    }

    private void NorthActive()
    {
        compassUIElements[2].SetActive(true);
    }

    private void EastActive()
    {
        compassUIElements[1].SetActive(true);
    }

    private void SouthActive()
    {
        compassUIElements[3].SetActive(true);
    }

    private void WestActive()
    {
        compassUIElements[0].SetActive(true);
    }
}
