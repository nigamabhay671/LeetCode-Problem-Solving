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
        // if(root==null){
        //     return 0;
        // }

        // int left=MaxPathSum(root.left);
        // int right=MaxPathSum(root.right);       

        // maxResult = Math.Max(maxResult,(root.val+left+right));

        // return maxResult;
    }

    private int DFS(TreeNode node) {
        if (node == null) return 0;

        // Max sum from left and right, ignore negative sums
        int left = Math.Max(DFS(node.left), 0);
        int right = Math.Max(DFS(node.right), 0);

        // Update global max if current path (node + left + right) is higher
        maxSum = Math.Max(maxSum, node.val + left + right);

        // Return max path sum going down (node + one child)
        return node.val + Math.Max(left, right);
    }
}