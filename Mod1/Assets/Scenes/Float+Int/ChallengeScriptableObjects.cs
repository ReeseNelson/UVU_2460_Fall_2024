using UnityEngine;

namespace Scenes.Float_Int
{
    [CreateAssetMenu]
    public class ScriptableObjects : ScriptableObject
    {
        public float value;
        public int intValue;
        public void UpdateValue(ref int number)
        {
            number += intValue;
        }

        public void ReplaceValue(int number, out int hereValue)
        {
            hereValue = 8;
            hereValue += number;
        }
    
        public void UpdateValue(float num, out float fl)
        {
            fl = num;
            fl += num;
        }

        public void DisplayImage(ref string img)
        {
            string love = img.ToString();
            img = love;
        }


    }
}