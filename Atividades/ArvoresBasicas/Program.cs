using ArvoresBasicas;

Tree<int> tree = new Tree<int>();
tree.root = new Node<int>() { Data = 100 };
// tree.root.Data = 100;

tree.root.Children =
    new List<Node<int>>{
        new Node<int>() { Data = 50, Parent = tree.root },
        new Node<int>() { Data = 1, Parent = tree.root},
        new Node<int>() { Data = 150, Parent = tree.root},
    };

Node<int> node12 = new Node<int>() { Data = 12, Parent= tree.root.Children[0]};
Node<int> node45 = new Node<int>() { Data = 45, Parent = node12 };
Node<int> node21 = new Node<int>() { Data = 21, Parent = node12 };
node12.Children!.Add(node45!);
node12.Children!.Add(node21!);
tree.root.Children[0].Children!.Add(node12);

tree.PrintTree(tree.root);