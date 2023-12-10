using UnityEngine;

public class EnemyAmmoScript : MonoBehaviour
{
    public float _speed;
    public float _time;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * _speed * Time.fixedDeltaTime);
        _time -= Time.deltaTime;
        if (_time <= 0) { Destroy(gameObject); }
    }
}
