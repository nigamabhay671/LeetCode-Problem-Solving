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
    public bool IsBalanced(TreeNode root) {
         if(root==null){
            return true;
        }

        int l=height(root.left);
        int r=height(root.right);

        if(Math.Abs(l-r)<=1 && IsBalanced(root.left) && IsBalanced(root.right)){
            return true;
        }
        else
        {
        return false;
        }}
    public int height(TreeNode root){
        if(root==null){
            return 0;
        }
        int lt=height(root.left);
        int rt=height(root.right);
        int res=rt-lt;
        return 1+Math.Max(lt,rt);
    }
}