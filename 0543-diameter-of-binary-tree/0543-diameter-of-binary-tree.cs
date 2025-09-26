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

    public int diameter=0;
    public int DiameterOfBinaryTree(TreeNode root) {       
        height(root);
        return diameter;        
    }

    public int height(TreeNode root){
            if(root==null){
            return 0;
        }

        int lt=height(root.left);
        int rt=height(root.right);

        diameter=Math.Max(diameter,rt+lt);

        return Math.Max(rt,lt)+1;

    }
}