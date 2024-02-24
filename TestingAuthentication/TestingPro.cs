using AuthLibrary;

namespace TestingAuthentication;

public class TestingPro
{
    [Fact]
    public void ItemsTesting()
    {
var product = new ItemModel(){
  Id = 1,
  Name ="Fido Mobile" ,
  Description = "Fido"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Fido Mobile", Item.Name);
Assert.Equal("Fido", Item.Description);
  }
  [Fact]
    public void ItemTesting_2()
    {
var product = new ItemModel(){
  Id = 1,
  Name = "Samsung"
  Description = "Samsung Galaxy"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Samsung", Item.Name)
Assert.Equal("Samsung Galaxy", Item.Description);
  }
 [Fact]
    public void ItemTesting_3()
    {
var product = new ItemModel(){
  Id = 1,
  Name ="Asus"
  Description = "Asus Gaming"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Asus", Item.Name)
Assert.Equal("Asus Gaming", Item.Description);
  }
    [Fact]
    public void ItemTesting_4()
    {
var product = new ItemModel(){
  Id = 1,
  Name = "Vespa"
  Description = "Vespa"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Vespa", Item.Name);
Assert.Equal("Vespa", Item.Description);
  }

//Testing Categories
   [Fact]
    public void Category_testing1()
    {
var product = new CategoryModel(){
  Id = 1,
  Description = "Motorola"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Motorola", Item.Description);
  }

     [Fact]
    public void Category_testing2()
    {
var product = new CategoryModel(){
  Id = 1,
  Description = "Nokia"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Nokia", Item.Description);
  }

 [Fact]
    public void Category_testing3()
    {
var product = new CategoryModel(){
  Id = 1,
  Description = "Mountain wear"
};
Assert.Equal(1, Item.Id);
Assert.Equal("Mountain Wear", Item.Description);
  }

     [Fact]
    public void Category_testing4()
    {
var product = new CategoryModel(){
  Id = 1,
  Description = "North Face"
};
Assert.Equal(1, Item.Id);
Assert.Equal("North Face", Item.Description);
  }

  //Cart Testing
     [Fact]
    public void Cart_testing1()
    {
var product = new ShoppingCart(){
  Id = 1,
  User = "JD"
};
Assert.Equal(1, Item.Id);
Assert.Equal("JD", Item.User);
 }

       [Fact]
    public void Cart_testing2()
    {
var product = new ShoppingCart(){
  Id = 2,
  User = "JP"
};
Assert.Equal(2, Item.Id);
Assert.Equal("JP", Item.User);

}
     [Fact]
    public void Cart_testing3()
    {
var product = new ShoppingCart(){
  Id = 3,
  User = "Jamerson"
};
Assert.Equal(3, Item.Id);
Assert.Equal("Jamerson", Item.User);
}

     [Fact]
    public void Cart_testing4()
    {
var product = new ShoppingCart(){
  Id = 4,
  User = "Black level"
};
Assert.Equal(4, Item.Id);
Assert.Equal("Black level", Item.User);
}
}