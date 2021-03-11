#include <bits/stdc++.h>

using namespace std;

class Node {
    public:
        int data;
        Node *left;
        Node *right;
        Node(int d) {
            data = d;
            left = NULL;
            right = NULL;
        }
};

class Solution {
    public:
  		Node* insert(Node* root, int data) {
            if(root == NULL) {
                return new Node(data);
            } else {
                Node* cur;
                if(data <= root->data) {
                    cur = insert(root->left, data);
                    root->left = cur;
                } else {
                    cur = insert(root->right, data);
                    root->right = cur;
               }

               return root;
           }
        }
/*The tree node has data, left child and right child 
class Node {
    int data;
    Node* left;
    Node* right;
};

*/
    int height(Node* root) {
        // Write your code here.
        int height = 0;
        
        if(root->left || root->right){
            height++;
        }
        
        int leftHeight = internalGetHeight(root->left, height);
        int rightHeight = internalGetHeight(root->right, height);
        
        if(leftHeight > rightHeight){
            height = leftHeight;
        } else{
            height = rightHeight;
        }
        
        return height;
    }
    
    int internalGetHeight(Node* node, int height){
        if(!node){
            return height;
        }
        
        if(node->left || node->right){
            height++;
        }
        
        int leftHeight = internalGetHeight(node->left, height);
        int rightHeight = internalGetHeight(node->right, height);
        
        if(leftHeight > rightHeight){
            height = leftHeight;
        } else{
            height = rightHeight;
        }
        
        return height;             
    }

}; //End of Solution