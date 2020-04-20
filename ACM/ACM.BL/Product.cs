namespace ACM.BL
{
    public class Product
    {

        // make a empty constructor

        public Product(){

        }

        // make a overloaded constructor

        public Product(int productId){
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName{get;set;}
        public string ProductDescription{get;set;}
        // this ? means i can be null to
        public decimal? CurrentPrice {get;set;}


        // return a  produvt object using th eproduct Id

        public Product Retreve(int productId){
            return new Product();
        }

        public bool Save(){
            return true;
        }



        // now again the validate method


        public bool vaidate(){
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName)){
                isValid = false;
            }
            if (CurrentPrice == null){
                isValid = false;
            }
            return isValid;
        }


    }
}