using AM1.UnityPackagePractice.PracticeCommon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM1.UnityPackagePractice.PracticeB
{
    public class PackageB : MonoBehaviour
    {
        DrawLabel drawLabel;

        void Update()
        {
            if (drawLabel == null)
            {
                drawLabel = GetComponent<DrawLabel>();
            }
            drawLabel.SetLabelText(1, $"Package B {Time.frameCount}");
        }
    }
}