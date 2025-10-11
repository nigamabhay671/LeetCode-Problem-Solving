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
     int maxSum=int.MinValue;
    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return maxSum;
    }

    private int DFS(TreeNode node) {
         if (node == null) return 0;

        // Compute max path sum from left and right subtrees (ignore negatives)
        int left = Math.Max(DFS(node.left), 0);
        int right = Math.Max(DFS(node.right), 0);

        // Calculate the maximum path passing through this node
        int currentPathSum = node.val + left + right;

        // Update the global maximum path sum
        maxSum = Math.Max(maxSum, currentPathSum);

        // Return max sum from this node down to one child
        return node.val + Math.Max(left, right);
    }
}