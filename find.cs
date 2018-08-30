
#测试下 鼠标控制camera
void UpdateRotation ()
{
    horizontal = Input.GetAxis ("Mouse X") * mouseSensitivity;
    vertical -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
    vertical = Mathf.Clamp (vertical, -80, 80);

    controller.transform.Rotate (0, horizontal, 0);
    Camera.main.transform.localRotation = Quaternion.Euler(vertical, 0, 0);
}
