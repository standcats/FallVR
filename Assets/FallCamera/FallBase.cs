using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StandCats
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class FallBase : MonoBehaviour
    {

        public FallEnvironment Environment;


        public void FixedUpdate()
        {
            Vector3 append = Vector3.zero;
            if (Environment.FallFlag)
            {
                append += Vector3.up * Environment.CurrentFallSpeed * Time.deltaTime;
            }
            if (append != Vector3.zero)
            {
                this.transform.position += append;
            }
        }

    }
}
