using AM1.UnityPackagePractice.PracticeCommon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM1.UnityPackagePractice.PracticeA
{
    public class PackageA : MonoBehaviour
    {
        DrawLabel drawLabel;

        void Update()
        {
            if (drawLabel == null)
            {
                drawLabel = GetComponent<DrawLabel>();
            }
            drawLabel.SetLabelText(0, $"Package A {Time.frameCount}");
        }
    }
}