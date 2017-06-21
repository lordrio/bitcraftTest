using System;
using UnityEngine;

public static class ColorExtension
{
    public static int Convert(this Color cols)
    {
        var col = (Color32)cols;
        return ((int)col.r << 24) + ((int)col.g << 16) + ((int)col.b << 8) + ((int)col.a);
    }
}

public class ColorGenData
{
    public Color previousColor = Color.clear;
    public Color currentColor = Color.clear;
    public Root root = null;
}