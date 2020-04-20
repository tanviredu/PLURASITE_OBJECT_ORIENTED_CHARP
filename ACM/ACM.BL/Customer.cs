using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {


        public Customer(int customerId){

            // customer id has  aprivate setter
            // so we need to set the CustomerId
            // in the constructor
            // so when the customer object is created
            // and id will automatically generated
            // if the field and the parameter are different
            // then you dont have to use the this key word

            CustomerId = customerId;

        }


        // bu the problem is we use our test case 
        // without the id 
        // so we nee dto overload this constructor too

        public Customer(){

        }

        // now you can init with parameter
        // or not a parameter at all















        // private property for setting 
        // the getter and setter
        // this variable called backing field
        private string _lastname;

        // setting a getter and setter
        // if you do not give the get
        // it is writeonly
        // if you do not give the set
        // it is readonly
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                // you dont have to pass the 'value' in anything
                // this will automatically work
            }
        }

        // now you can use auto implemetaded property

        public string FirstName { get; set; }

        // email address property
        public string EmailAddess { get; set;}

        // email customer id
        // any body can get it other class cant set it
        public int CustomerId { get; private set; }

        // make a full name property

        public string FullName
        {
            // only the get
            get
            {

                // add getter and setter 
                // logic

                /// check if the last exist
                /// if it exists then check if the first name
                /// if not lastname is full name
                /// but if there then add a comma and add the first name after lastname with a comma





                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        // remember upto this point full name is his lastname
                        fullname += ", ";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }



        // make a static method

        public static int InstanceCount { get; set; }


        // adding validation technique
        // this is public so other can access it
        public bool validate(){
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)){
                isValid = false;
            } 
            if(string.IsNullOrWhiteSpace(EmailAddess)){
                isValid = false;
            }

            return isValid;
        }

    // new method for retreving  aspecfic customes
    // using the Id
    // it will return a object of Customer
    // remember Customer is a type
    public Customer Retreve(int customerId){
        return new Customer();
    } 

    public bool Save(){
        return true;
    }



    // now this method will returnn a list of
    // Customer 
    // and it also return a List
    // remember same name 
    // so its method overloading
    public List<Customer> Retreve(){
        return new List<Customer>();
    }
    




    }
}
