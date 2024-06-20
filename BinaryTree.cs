public class BinaryTree{
    Node? root;
    public BinaryTree(Node? node=null){
        this.root=node;
    }
    public void InOrderSearch(Node? node){
        if(node==null)
        node=root;

        if(node.left != null)
            InOrderSearch(node.left);

        Console.WriteLine(node.value);

        if(node.right!=null){
            InOrderSearch(node.right);
        }    

    }
}