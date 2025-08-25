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
    public int deepHeight(TreeNode root){
        if(root==null){
            return 0;
        }

        return 1+Math.max(deepHeight(root.left),deepHeight(root.right));
    }

    public int deepestLeavesSum(TreeNode root) {
        if(root==null){
            return 0;
        }
        int height=deepHeight(root);
        return printf(root,1,height);
       
    }

    public int printf(TreeNode root,int level,int height)
    {      if (root == null) return 0;

        if(root.left==null || root.right==null)
        {
            if(level==height)
            {
                return root.val;
            }
        }

      return  printf(root.left,level+1,height) + printf(root.right,level+1,height);

    }
}