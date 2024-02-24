using Player;
using UnityEngine;

namespace Collectables
{
    public class Healer : MonoBehaviour
    {
        private int _healAmount = 1;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out HealthPresenter healthPresenter))
            {
                healthPresenter.Heal(_healAmount);
                Destroy(gameObject);
            }
        }
    }
}
