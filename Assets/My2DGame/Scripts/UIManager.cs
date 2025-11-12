using UnityEngine;

namespace My2DGame
{
    /// <summary>
    /// 플레이씬 UI를 관리하는 클래스
    /// 데미지 텍스트 연출,
    /// </summary>
    public class UIManager : MonoBehaviour
    {
        #region Variables
        //참조
        private Canvas gameCanvas;

        public GameObject damageTextPrefab;     //데미지 텍스트 연출 프리팹
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            gameCanvas = FindFirstObjectByType<Canvas>();
        }
        #endregion

        #region Custom Method
        //캐릭터가 데미지 입을때 호출되는 함수 - 데미지 텍스트 연출
        //매개변수로 캐릭터의 오브젝트, 데미지량 입력받아 처리
        public void CharacterTakeDamage(Transform character, float damageReceived)
        {
            //캐릭터 머리위 위치 가져오기
            Vector3 spawnPosition = Vector3.zero;

            Instantiate(damageTextPrefab, spawnPosition, Quaternion.identity, gameCanvas.transform);
        }
        #endregion
    }
}
