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
    public IList<int> PreorderTraversal(TreeNode root) {
          var result=new List<int>();
           if(root==null){        return result;      }

            Stack<TreeNode> myStack = new Stack<TreeNode>();
         myStack.Push(root);
        while(myStack.Count>0)
        {
           TreeNode no= myStack.Pop();
            result.Add(no.val);
            if(no.right!=null)
            {
                 myStack.Push(no.right);
            }
             if(no.left!=null)
             {
                 myStack.Push(no.left);
            }
        }
        return result;
    }
}