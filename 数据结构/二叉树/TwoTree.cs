using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树
{
    
     class TwoTree
    {

        //子树为空,判断大于或小于,子树不为空新的value对比root子树,大于左边既可走右边,反之.
        

      public class node
        {
           public int value;
           public node left;
           public node right;
           public static  node save_node; 


           public node(int value)
           {
               this.value = value;
           }

           public void add(int value)
           {
               if (value<this.value)
               {
                   if (this.left!=null)
                   {
                       this.left.add(value);
                   }
                   else
                   {
                       this.left = new node(value);
                       Console.WriteLine("left:{0}  ", left.value);
                   }
                  
               }
               else
               {
                   if (this.right!=null)
                   {
                       this.right.add(value);
                   }
                   else
                   {
                       this.right = new node(value);
                       Console.WriteLine("right:{0}  ", right.value);
                   }
                   
               }

              
           }


           public node Fina(int value)
           {
               if (value==this.value)
               {
                  return save_node = this;
                   
               }
               else if (value>this.value)
               {
                   if (this.right!=null)
                   {
                       return this.right.Fina(value);
                   }
                   else
                   {
                       return null;
                   }
                   
               }
               else if (value<this.value)
               {
                   if (this.left!=null)
                   {
                       return this.left.Fina(value);    
                   }
                   else
                   {
                       return null;
                   }
                   
               }
               else
               {
                   return null;
               }
               
           }
           
     
           public bool Delete(int value)
           {
              return _delete(value,Fina(value));
           }
           private bool _delete(int value, node n)
           {

               //node delete_left;
               //node delete_right;
               node delete_node = this;

               if (n.right ==null && n.left==null)
               {
                   nodedelete(value);
                   return false;
               }

               else if (n.right!=null)
               {
                  
                   node minNode = min(n.right);

                   n.value = minNode.value;

                   minNode = null;
                   return true;
               }
               else if (n.left!=null)
               {
                  
                   node maxNode = max(n.left);
                   n.value = maxNode.value;
                   maxNode = null;
                   return true;
               }
               else
               {
                   return false;
               }
               
               
                

           }

           public node nodedelete(int value)
           {
               if (value>this.value)
               {
                   if (this.right.value==value)
                   {
                       return this.right = null;
                   }
                   else
                   {
                       return this.right.nodedelete(value);
                   }
                   
               }
               else if (value<this.value)
               {
                   if (this.left.value==value)
                   {
                      return this.left = null;

                   }
                   else
                   {
                       return this.left.nodedelete(value);     
                   }
                   
               }
               else
               {
                   return null;
               }
               
             
           }



           public node min(node n)
           {
               if (n.left==null)
               {
                   return n;
               }
               else
               {
                   return min(n.left);
               }

           }
           public node max(node n)
           {
               if (n.right ==null)
               {
                   return n;
               }
               else
               {
                   return max(n.right);
               } 
           }

           public bool modify(int value,int modify_value)
           {
               if (this.Fina(value)!=null)
               {
                   this.Delete(value);
                   this.add(modify_value);
                   return true;   
               }
               else
               {
                   return false;
               }
               
           }
        }
      
        node root;

        public TwoTree(int value)
        {
            root = new node(value);
            Console.WriteLine("root{0}", value);
        }
        public bool add(int value)
        {
            if (root ==null)
            {
                root = new node(value);
                return true;
            }
            else
            {
                 root.add(value);
                 return true;
            }
        }
        public node Find(int value)
        {
            if (root ==null)
            {
                return null;
            }
            else
            {
                Console.WriteLine("节点为空");
                return  root.Fina(value);
                
            }
        }
        public bool Delete(int value)
        {
            if (root==null)
            {
                return false;
            }
            else
            {
                root.nodedelete(value);
                return true;
            }
        }
        public bool modify(int value,int modify_value)
        {
            if (root == null)
            {
                return false;
            }
            else
            {
                return root.modify(value,modify_value);

            }
        }


    }
}

