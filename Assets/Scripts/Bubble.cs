using UnityEngine;

public abstract class Bubble : MonoBehaviour
{
    [SerializeField] protected float speed, time;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move(1f); // Assuming the bubble moves to the right by default
    }

    protected virtual void Move(float direction)
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }

    protected virtual void Pop()
    {
        Destroy(gameObject, time);
    }
}