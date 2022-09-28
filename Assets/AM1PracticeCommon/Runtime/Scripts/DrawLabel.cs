using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM1.UnityPackagePractice.PracticeCommon
{
    public class DrawLabel : MonoBehaviour
    {
        static float LineHeight = 40;

        string[] labelTextList = { "-", "-" };

        /// <summary>
        /// インデックスを指定して文字をせ設定
        /// </summary>
        /// <param name="index">インデックス。0 or 1</param>
        /// <param name="txt">設定文字列</param>
        public void SetLabelText(int idx, string txt)
        {
            int index = Mathf.Clamp(idx, 0, 1);
            labelTextList[index] = txt;
        }

        private void OnGUI()
        {
            GUI.color = Color.red;
            for (int i = 0; i < labelTextList.Length; i++)
            {
                GUI.Label(new Rect(20, 20 + i * LineHeight, 100, LineHeight), labelTextList[i]);
            }
        }
    }
}