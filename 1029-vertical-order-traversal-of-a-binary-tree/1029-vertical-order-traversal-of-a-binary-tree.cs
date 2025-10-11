/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
      private List<(int hd, int row, int val)> nodes = new List<(int, int, int)>();
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        DFS(root, 0, 0);

        // Sort: by hd, then row, then val
        var sorted = nodes
            .OrderBy(x => x.hd)
            .ThenBy(x => x.row)
            .ThenBy(x => x.val)
            .ToList();

        var result = new List<IList<int>>();
        int? prevHd = null;
        List<int> col = new List<int>();

        foreach (var (hd, row, val) in sorted) {
            if (prevHd != null && hd != prevHd) {
                result.Add(col);
                col = new List<int>();
            }
            col.Add(val);
            prevHd = hd;
        }

        if (col.Count > 0)
            result.Add(col);

        return result;
    }
    private void DFS(TreeNode node, int hd, int row) {
        if (node == null) return;

        nodes.Add((hd, row, node.val));

        // left child => hd - 1, row + 1
        DFS(node.left, hd - 1, row + 1);

        // right child => hd + 1, row + 1
        DFS(node.right, hd + 1, row + 1);
    }
}