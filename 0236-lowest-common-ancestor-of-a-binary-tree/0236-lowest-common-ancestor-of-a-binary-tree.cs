/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
          List<TreeNode> path1 = new List<TreeNode>();
        List<TreeNode> path2 = new List<TreeNode>();

        if (!checkpath(root, path1, p) || !checkpath(root, path2, q))
            return null;   // If either p or q not found

        int i = path1.Count - 1;
        int j = path2.Count - 1;

        while (i >= 0 && j >= 0 && path1[i] == path2[j]) {
            i--;
            j--;
        }

        return path1[i + 1];  // Last common node

    }

   public bool checkpath(TreeNode root, List<TreeNode> path, TreeNode target) {
        if (root == null)
            return false;

        if (root == target) {
            path.Add(root);
            return true;
        }

        if (checkpath(root.left, path, target) || checkpath(root.right, path, target)) {
            path.Add(root);
            return true;
        }

        return false;
    }


}