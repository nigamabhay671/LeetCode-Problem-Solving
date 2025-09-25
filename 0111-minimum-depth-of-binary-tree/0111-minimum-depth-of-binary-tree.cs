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
    public int MinDepth(TreeNode root) {
        int count=1;
        if(root==null){
            return 0;
        }
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count()>0){
            int size=q.Count();
            
            for(int i =0;i<size;i++){
                TreeNode node=q.Dequeue();
                
                if (node.left == null && node.right == null) {
                    return count;
                }
                if(node.left!=null){
                    q.Enqueue(node.left);
                }
                if(node.right!=null){
                    q.Enqueue(node.right);
                }
            }
          count++;
        }
        
        return count;
    }
}