using ToDoAPI.Models;

namespace ToDoAPI.Tests;

public class ToDoModelTests
{
    [Fact]
    public void CanChangeName()
    {
        var testToDo = new ToDoItem
        {
            Name = "Do something"
        };

        testToDo.Name = "Do nothing";

        Assert.Equal("Do nothing", testToDo.Name);
    }
}