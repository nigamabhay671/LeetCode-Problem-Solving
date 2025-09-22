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
    public IList<string> BinaryTreePaths(TreeNode root) {
         List<string> result = new List<string>();
        List<int> path = new List<int>();
        DFS(root, path, result);
        return result;
    }
    private void DFS(TreeNode node, List<int> path, List<string> result) {
        if (node == null) return;
        path.Add(node.val);
        if (node.left == null && node.right == null) {
            result.Add(string.Join("->", path));
        } else {
            DFS(node.left, path, result);
            DFS(node.right, path, result);
        }
        path.RemoveAt(path.Count - 1);
    }
}