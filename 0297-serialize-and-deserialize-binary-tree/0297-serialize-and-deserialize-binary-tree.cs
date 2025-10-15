/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
public static int t;
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> res=new List<string>();

        Stack<TreeNode> st=new  Stack<TreeNode>();
        st.Push(root);

        while(st.Count>0){
            TreeNode curr=st.Pop();
             if(curr==null){
                res.Add("#");
            }
            else
            {
               res.Add(curr.val+"");
            st.Push(curr.right);
            st.Push(curr.left);
            }
        }
return String.Join(",", res);

    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) 
    {       
        if(data==null)
        {
            return null;
        }
       string[] arr = data.Split(',');
        t=0;
        return helper(arr);
    }
    public TreeNode helper(string[] arr)
    {        
        if(arr[t].Equals("#"))
        {
            return null;
        }

        TreeNode root=new TreeNode(int.Parse(arr[t]));
        t++;
        root.left=helper(arr);
        t++;
        root.right=helper(arr);
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));