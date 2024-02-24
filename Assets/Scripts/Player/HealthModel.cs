using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Player
{
    public class HealthModel : MonoBehaviour
    {
        public Action OnHealthChanged = null;
        private int _remainingHealth;
        private const int MaxHealth = 3;
        public int RemainingHealth => _remainingHealth;

        public void HealDecrement(int damageAmount)
        {
            _remainingHealth -= damageAmount;
            if (_remainingHealth <= 0) SceneManager.LoadScene(0);
            UpdateHealth();
        }
        public void HealIncrement(int healAmount)
        {
            if (_remainingHealth >= 3) return;
            _remainingHealth += healAmount;
            UpdateHealth();
        }

        public void ResetHealth()
        {
            _remainingHealth = MaxHealth;
        }
    
        public void UpdateHealth()
        {
            OnHealthChanged?.Invoke();
        }
    }
}
