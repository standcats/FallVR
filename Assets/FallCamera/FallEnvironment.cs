using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StandCats
{
    public class FallEnvironment : MonoBehaviour
    {

        /// <summary>
        /// 落下加速度
        /// </summary>
        public float FallSpeed = 9.8f;
        public float CurrentFallSpeed = 0;
        public bool FallFlag = false;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (FallFlag)
            {
                CurrentFallSpeed += FallSpeed * Time.deltaTime;
            }
            else
            {
                CurrentFallSpeed = 0;
            }
        }

    }
}