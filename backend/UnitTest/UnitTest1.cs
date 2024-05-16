using filter.cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using backend.Config;
using System;
using System.Collections.Generic;
namespace UnitTest
{

[TestClass]
public class UnitTest1s
{
    public class TestItem
    {
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }

    [TestMethod]
    public void TestMethod1()
    { 
        List<Forum> list = List<Forum>{
            new Forum { content = "content", title = "title", id = 1 },
            new Forum { content = "content", title = "title", id = 2 },
            new Forum { content = "content", title = "title", id = 3 }
        }
        Forum f = Filter<Forum>.filter(list, "id", 1);
        if (f != null)
        {
            Assert.AreEqual(1, f.id);
        }
        else
        {
            Assert.Fail();
        }
    }

    [TestMethod]
    public void Filter_Returns_Correct_Item()
    {
        var data = new List<TestItem>
        {
            new TestItem { Id = 1, Name = "Item1" },
            new TestItem { Id = 2, Name = "Item2" }
        };
        string key = "Id";
        int value = 2;
        
        var result = Filter<TestItem>.filter(data, key, value);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Id);
    }
}
}

       