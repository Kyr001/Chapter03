using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer characterRenderer2;
    public GameObject lightSource;

    private TopDownController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }


    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }
    

    private void RotateArm(Vector2 direction)
    {
 
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        characterRenderer2.flipX = Mathf.Abs(rotZ) > 90f;
        if(Mathf.Abs(rotZ) > 90f)
            lightSource.transform.localPosition = new Vector3(-1, -0.8f, 0);
        else
            lightSource.transform.localPosition = new Vector3(1, -0.8f, 0);
    }
}