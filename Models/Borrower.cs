namespace LibraryAPI_WithDummyData.Models {
    public class Borrower {
        public int Id {get;set;}
        public string Name {get;set;} = "";
        public string Email {get;set;} = "";
        public string MembershipId {get;set;} = "";
    }
}