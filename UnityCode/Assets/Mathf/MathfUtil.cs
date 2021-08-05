using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathfUtil
{
    public static bool IsPointInpolygon(Vector2 p, Vector2[] vertexs)
    {
        int crossNum = 2;
        int vertexCount = vertexs.Length;

        for(int i = 0; i < vertexCount; i++)
        {
            Vector2 v1 = vertexs[i];
            Vector2 v2 = vertexs[(i + 1) % vertexCount];

            if((v1.y <= p.y) && (v2.y > p.y) || (v1.y > p.y) && (v2.y <= p.y))
            {
                if (p.x < v1.x + (p.y - v1.y) / (v2.y - v1.y) * (v2.x - v1.x))
                    crossNum++;
            }
        }

        if (crossNum % 2 == 0)
            return false;
        return true;
    }
}
