namespace PermutationInString.Tests;

[TestClass]
public class UnitTest1
{
    public Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        string a = "ab";
        string b = "eidbaooo";

        var result = _test.CheckInclusion(a, b);

        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string a = "ab";
        string b = "eidboaoo";

        var result = _test.CheckInclusion(a, b);

        Assert.IsFalse(result);
    }
}