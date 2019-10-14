using System.IO;
using System.Linq;

public static class MultiPathCombine
{
    /// <summary>
    ///     3つ以上のパス元をCombineする
    /// </summary>
    /// <param name="paths">パスの配列</param>
    /// <returns></returns>
    public static string Combine(params string[] paths)
    {
        return paths.Aggregate((a, b) => Path.Combine(a, b));
    }
}