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
    ArrayList<Integer> res=new ArrayList<>();
    public boolean isValidBST(TreeNode root) 
    {
        if(root==null)
        {
            return false;
        }
        inorder(root);

        for(int i=0;i<res.size()-1;i++){
            if(res.get(i)<res.get(i+1))
            {
                continue;
            }
            else{
                return false;
            }
           

        }
         return true;
    }

    void inorder(TreeNode root){
        if(root==null){
            return;
        }
        inorder(root.left);
        res.add(root.val);
        inorder(root.right);
    }

}