using System;
namespace ACM.BL
{

    // make test 

    // this class this used to make 
    // the abstracttion
    // make the code more orgranised 
    // this class is basically store the 
    // name of the product and its quantity
    public class OrderItem
    {
        // base constructor
        public OrderItem(){}
        
        public int OrderItemId{get;set;}
        // we need the product id 
        // it will come from product class
        public int ProductId{get;set;}

        public decimal? PurchasePrice{get;set;}
        public int Quantity{get;set;}
        public OrderItem(int orderItemId){
            OrderItemId = orderItemId; 
        }

        

        public bool Save(){

            return true;
        }


        // validate function

        public bool validate(){

            var isValid = true;
            if(Quantity<=0){isValid=false;}
            if(ProductId<=0){isValid=false;}
            if(PurchasePrice==null){isValid=false;}

            return isValid;
        }
    }
}