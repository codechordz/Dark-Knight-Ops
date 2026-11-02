Using UnityEngine;
[RequireComponent(typeof(CharacterController))]
  public class FpsController : MonoBehaviour
{
    [Header("Camera")]
    public Transform cameraPivot;
    public float mouseSensitivity = 2f;
    public float maxLookAngle = 85f;

    [Header("Movement")]
    public float jumpSpeed = 4f;
    void Awake()
{
    controller = GetComponent<CharacterController>();
    controller.height = standingHeight;
    controller.center = Vector3.up * (standingHeight / 2f);
  
