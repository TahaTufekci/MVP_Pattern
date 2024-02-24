using Player;
using UnityEngine;

namespace Collectables
{
    public class DamageDealer : MonoBehaviour
    {
        private int _damageAmount = 1;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out HealthPresenter healthPresenter))
            {
                healthPresenter.TakeDamage(_damageAmount);
                Destroy(gameObject);
            }
        }
    }
}

