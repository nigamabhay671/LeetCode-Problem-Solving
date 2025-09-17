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
    public bool IsCousins(TreeNode root, int x, int y) {
          Dictionary<int, (int p, int d)> dict = new Dictionary<int, (int, int)>();
        DFS(root, dict, 0, 0);
        
        return ((dict[x].d == dict[y].d) && (dict[x].p != dict[y].p));

    }
    private void DFS(TreeNode node, Dictionary<int, (int p, int d)> dict, int parent, int curDepth)
    {
        if (node != null)
        {
            dict.Add(node.val, (parent, curDepth));
            DFS(node.left, dict, node.val, curDepth + 1);
            DFS(node.right, dict, node.val, curDepth + 1);
        }
    }
}