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
    public IList<int> RightSideView(TreeNode root) {
        var res=new List<int>();
        if(root==null)
        {
            return res;
        }
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count>0)
        {
            int size=q.Count;
           TreeNode rightMost=null;
           
            for(int i=0;i<size;i++)
            {
                var tre=q.Dequeue();
                rightMost=tre;
               

                if(tre.left!=null) { q.Enqueue(tre.left);  }
                if(tre.right!=null){  q.Enqueue(tre.right);}              
                
            }
              if (rightMost != null)
                res.Add(rightMost.val);
        }
        return res;
    }
}