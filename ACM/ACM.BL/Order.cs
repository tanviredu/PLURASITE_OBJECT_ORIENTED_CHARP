using System;

namespace ACM.BL
{
    public class Order
    {
        public Order(){}




        public int OrderId{get;private set;}
        public DateTimeOffset? OrderDate{get;set;}
        // overloaded constructor
        public Order(int orderId){
            OrderId = orderId; 
        }    

        // retreve the order
        // and it will be  a order object
        // remember object is a type
        // so you can use it as a return type
        public Order Retrive(int OrderId){
            return new Order();

        }

        public bool Save(){
            return true;
        }


        public bool validate(){
            var isValid = true;
            if(OrderDate == null){
                isValid = false;
            }

            return isValid;
        }

    }


}