using UnityEngine;

namespace My2DGame
{
    /// <summary>
    /// HitBox에 충돌한 적에게 데미지를 주는 클래스
    /// </summary>
    public class Attack : MonoBehaviour
    {
        #region Variables
        //공격시 적에게 주는 데미지 량
        [SerializeField]
        private float attackDamage = 10f;
        #endregion

        #region Unity Event Method
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //Debug.Log($"적에게 {attackDamage} 데미지를 주었다");
            Damageable damageable = collision.GetComponent<Damageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(attackDamage);
            }
        }
        #endregion
    }
}
