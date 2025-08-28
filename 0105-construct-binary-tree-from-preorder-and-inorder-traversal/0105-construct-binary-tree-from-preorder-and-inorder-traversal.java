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
    Map<Integer,Integer> mp=new HashMap<>();
    int index=0;
    public TreeNode buildTree(int[] preorder, int[] inorder) 
    {
    for(int i=0;i<inorder.length;i++)
    {        
        mp.put(inorder[i],i);      
    }
      return buildTree(preorder,inorder,0,inorder.length-1);  }

      public TreeNode buildTree(int[] preorder, int[] inorder,int start,int end){

        if(start>end){
            return null;
        }

        int rootVal=preorder[index++];
        TreeNode node=new TreeNode(rootVal);
        int inindex=mp.get(rootVal);
        node.left = buildTree(preorder, inorder, start, inindex - 1);
node.right = buildTree(preorder, inorder, inindex + 1, end);
        return node;
      }
}