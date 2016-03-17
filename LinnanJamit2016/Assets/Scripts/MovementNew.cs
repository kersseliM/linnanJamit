using UnityEngine;
using System.Collections;

public class MovementNew : MonoBehaviour
{
    new Transform transform;
    public Vector2 lookSpeed;
    public Vector2 mouseMultiplyer;

    public Transform xRotate;
    public Transform yRotate;

    private Vector2 lookAxis = new Vector2();
    private float trueRootYRotation = 0;

    void Start()
    {
        transform = gameObject.transform;
    }

    void Update()
    {
        Assorted();

        lookAxis.x = Input.GetAxis("HorizontalLook");
        lookAxis.x += Input.GetAxis("Mouse X") * mouseMultiplyer.x;
        xRotate.Rotate(new Vector3(0, lookAxis.x * lookSpeed.x * Time.deltaTime, 0));

        if (!UnityEngine.VR.VRDevice.isPresent)
        {
            lookAxis.y = Input.GetAxis("VerticalLook");
            lookAxis.y -= Input.GetAxis("Mouse Y") * mouseMultiplyer.y;
            yRotate.Rotate(new Vector3(lookAxis.y * lookSpeed.y * Time.deltaTime, 0, 0));
            trueRootYRotation += lookAxis.y * lookSpeed.y * Time.deltaTime;
            if (trueRootYRotation < -90)
            {
                yRotate.localEulerAngles = new Vector3(270, 0, 0);
                trueRootYRotation = -90;
            }
            else if (trueRootYRotation > 90)
            {
                yRotate.localEulerAngles = new Vector3(90, 0, 0);
                trueRootYRotation = 90;
            }
        }
    }
    private void Assorted()
    {
        if (Input.GetKeyUp(KeyCode.L))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
        if(Input.GetKeyUp(KeyCode.Escape) || Input.GetKeyUp(KeyCode.End))
        {
            Application.Quit();
        }
        if (Input.GetKeyUp(KeyCode.Home) || Input.GetKeyUp(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
