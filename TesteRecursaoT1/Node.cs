using System;

namespace TesteRecursaoT1
{
    // Classe do nó
    public class Node
    {
        private object info;
        private Node next, prior;
        public bool marca;


        public object Info
        {
            get { return info; }
            set { info = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node Prior
        {
            get { return prior; }
            set { prior = value; }
        }

        public Node(object info, Node prior, Node next)
        {
            this.info = info;
            this.prior = prior;
            this.next = next;
        }
        
        public Node(object info) : this(info, null, null)
        {
        }
        
        public Node()
            : this(null, null, null)
        {
        }
    }
}
