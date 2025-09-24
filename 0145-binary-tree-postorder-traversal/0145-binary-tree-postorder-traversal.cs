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
    public IList<int> PostorderTraversal(TreeNode root) {
        var result=new List<int>();
        postorder(root,result);
        return result;
    }

    public void postorder(TreeNode root, List<int> result){
        if(root==null){
            return;
        }
postorder(root.left,result);
postorder(root.right,result);
result.Add(root.val);
        
    }
}