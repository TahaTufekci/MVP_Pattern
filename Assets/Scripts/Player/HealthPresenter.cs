using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class HealthPresenter : MonoBehaviour
    {
        public HealthModel healthModel;
        public Slider healthSlider;

        private void Start()
        {
            healthModel.ResetHealth();
            healthSlider.maxValue = 3;
            healthSlider.value = 3;
            UpdateView();
        }
        public void Heal(int healAmount)
        {
            healthModel.HealIncrement(healAmount);
        }
        public void TakeDamage(int damageAmount)
        {
            healthModel.HealDecrement(damageAmount);
        }
    
        public void UpdateView()
        {
            healthModel.OnHealthChanged = () =>
            {
                healthSlider.value = healthModel.RemainingHealth;
            };
        }
    }
}
