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
    public bool IsSymmetric(TreeNode root) {
        return BST(root.left,root.right);
    }

    public bool BST(TreeNode root1,TreeNode root2)
    {
        if(root1==null && root2==null){
            return true;
        }
        if(root1 ==null || root2==null){
            return false;
        }
        if(root1.val != root2.val){
            return false;
        }
            // bool left=BST(root1.left,root2.right);
            // bool right=BST(root1.right,root2.left);

            //  return(left && right ) ? true : false;

             return BST(root1.left,root2.right) && BST(root1.right,root2.left);

    }
}