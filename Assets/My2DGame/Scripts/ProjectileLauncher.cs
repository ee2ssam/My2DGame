using UnityEngine;

namespace My2DGame
{
    /// <summary>
    /// 발사체를 발사기
    /// </summary>
    public class ProjectileLauncher : MonoBehaviour
    {
        #region Variablse
        //발사체 프리팹
        public GameObject projectilePrefab;
        //발사 지점
        public Transform firePoint;
        #endregion

        #region Custom Method
        //발사체 발사
        public void FireProjectile()
        {
            Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        }
        #endregion
    }
}