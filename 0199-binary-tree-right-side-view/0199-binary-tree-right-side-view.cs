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
    int maxlevel=0;
    public IList<int> RightSideView(TreeNode root) {
        var res=new List<int>();
        DFS(root,1,res);
        return res;
    }

    public void DFS(TreeNode root,int level,List<int> res){
        if(root==null){
            return;
        }
        if(level>maxlevel)
        {
            res.Add(root.val);
            maxlevel=level;
        }

       DFS(root.right,level+1,res);
       DFS(root.left,level+1,res);
    }
}