using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 二叉树
{
    class Binary_tree
    {
        private class node
        {
            public int value;
            public node left;
            public node right;
            public node save_node;

            public node(int value)
            {
                this.value = value;
            }
            //添加节点
            public void add(int value)
            {
                if (value < this.value)
                {
                    if (this.left!=null)
                    {
                        this.left.add(value);
                    }
                    else
                    {
                        this.left = new node(value);
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
                    }
                }
            }
            public int Find(int value)
            {
                if (value==this.value)
                {
                    return this.value;
                }
                else if (value>this.value)
                {
                    if (this.right!=null)
                    {
                        return this.right.Find(value);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else if (value<this.value)
                {
                    if (this.left!=null)
                    {
                        return this.left.Find(value);
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            public string _delete(int value)
            {
                int delete_value;
                if (this.Find(value)==0)
                {
                    return "要删除的数据不存在";
                }
                else
                {
                    if (value>this.value)
                    {
                        if (this.right.value==value)
                        {
                            this.right = null;
                           return "该节点位于根节点的右节点，已删除该节点";
                        }
                        else
                        {
                            return this.right._delete(value);
                        }
                    }
                    else if (value<this.value)
                    {
                        if (this.left.value==value)
                        {
                            this.right = null;
                            return "该节点位于跟节点的左子节点，已删除该节点";
                        }
                        else
                        {
                            return this.left._delete(value);
                        }
                    }
                    else
                    {
                       return "该节点是根节点，已删除根节点";
                    }
                  
                }
            }
            ///修改节点Value值

            public string _modify(int value, int modify_value)
            {
                if (this.Find(value)!=null)
                {
                    this._delete(value);
                    this.add(modify_value);
                    return "修改节点完成，并重新排列";
                }
                else
                {
                    return "该节点不存在";
                }
            }

        }

        node root;

        public Binary_tree(int value)
        {
            root = new node(value);
        }
        public string add(int value)
        {
            if (root ==null)
            {
                root = new node(value);
                return "添加节点为第一个父节点";
            }
            else
            {
                root.add(value);
                return "添加节点成功";
            }
        }
        public string find(int value)
        {
            if (root == null)
            {

                return "该节点不存在";
            }
            else
            {
                if (root.Find(value)!=0)
                {
                    return "该节点存在";
                }
                else
                {
                    return "该节点不存在";
                }
            }
        }
        public string Delete(int value)
        {
            if (root==null)
            {
                return "没有该节点";
            }
            else
            {
                root._delete(value);
                return "已删除该节点";
            }
        }

        public string modify(int value, int modify_value)
        {
            if (root ==null)
            {
                return "没有该节点";
            }
            else
            {
                root._modify(value, modify_value);
                return "修改节点完毕";
            }
        }

        
       
        
    }
}
