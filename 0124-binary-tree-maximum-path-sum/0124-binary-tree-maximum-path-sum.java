/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
     private int max_sum = Integer.MIN_VALUE;
    public int maxPathSum(TreeNode root) {
      

         MaxPathSumCore(root);
     return max_sum;


    }

  public int MaxPathSumCore(TreeNode root)
 {
     if (root == null) return 0;

     var leftSum = Math.max(MaxPathSumCore(root.left), 0);
     var rightSum = Math.max(MaxPathSumCore(root.right), 0);

     max_sum = Math.max(max_sum, root.val + leftSum + rightSum);

     return root.val + Math.max(leftSum, rightSum);
 }
}