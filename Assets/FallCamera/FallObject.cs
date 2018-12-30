using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace StandCats
{
    public class FallObject : MonoBehaviour
    {

        public FallEnvironment Environment;
        public float SphereCastSize = 1.0f;
        public float SphereCastLength = 2.0f;

        private void FixedUpdate()
        {//地面判定
            if (SphereCastLength > 0 && SphereCastSize > 0)
            {
                Vector3 start = this.transform.position;
                Vector3 end = this.transform.position;
                RaycastHit[] hit = new RaycastHit[3];
                var count = Physics.SphereCastNonAlloc(start, SphereCastSize, Vector3.down, hit, SphereCastLength);
                if (count > 0)
                {
                    var name = hit[0].transform.gameObject.name;
                    Environment.FallFlag = false;
                }
                else
                {
                    Environment.FallFlag = true;//ぶつかるものがなければ上昇する
                }
            }
        }
#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (SphereCastLength > 0 && SphereCastSize > 0)
            {
                var color = Gizmos.color;
                Vector3 start = this.transform.position;
                Gizmos.DrawLine(start, start + (Vector3.down * SphereCastLength));
                RaycastHit[] hit = new RaycastHit[3];
                var count = Physics.SphereCastNonAlloc(start, SphereCastSize, Vector3.down, hit, SphereCastLength);
                if (count > 0)
                {
                    Gizmos.DrawWireSphere(hit[0].point + (Vector3.up * SphereCastSize ), SphereCastSize);
                }
            }
        }
#endif
    }

}