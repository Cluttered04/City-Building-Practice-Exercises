using System;

namespace Planner {

    class Building {
        private string _designer {get; set;}
        private DateTime _dateConstructed {get; set;}
        private string _address {get; set;}
        private string _owner {get; set;}
        public int stories {get; set;}
        public double width {get; set;}
        public double depth {get; set;}
        public string private_owner {get; set;}
        public string designer {get; set;}
        public double volume {
            get {

                return width * depth * (3 * stories);
            }
        }
        public string address {get; set;}
        public string createAddress(string addressParam){
            return _address = addressParam;
        }
        public string publicAddress(string addressParam){
            return address = addressParam;
        }
        public DateTime constructionDate {get; set;}

        public void construct(){
            _dateConstructed = DateTime.Now;
        }
        public void purchase(string purchaser){
            private_owner = purchaser;
        }
        public DateTime setConstructionDate(){
            return constructionDate = DateTime.Now;
        }






    }


}
