using NUnit.Framework;

namespace RomanNumeralsConverter.Tests;

public class ConvertRomanNumeralsTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Given_Roman_numeral_I_Should_Return_1()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "I";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n1\n", output);
    }

    [Test]
    public void Given_Roman_numeral_II_Should_Return_2()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "II";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n2\n", output);
    }

    [Test]
    public void Given_Roman_numeral_IV_Should_Return_4()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "IV";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n4\n", output);
    }

    [Test]
    public void Given_Roman_numeral_VI_Should_Return_6()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "VI";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n6\n", output);
    }

    [Test]
    public void Given_Roman_numeral_VIII_Should_Return_8()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "VIII";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n8\n", output);
    }

    [Test]
    public void Given_Roman_numeral_XXXVI_Should_Return_36()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "XXXVI";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n36\n", output);
    }

    [Test]
    public void Given_Roman_numeral_MDCCCXXIX_Should_Return_1829()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "MDCCCXXIX";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n1829\n", output);
    }

    [Test]
    public void Given_Roman_numeral_MMCMXCVI_Should_Return_2996()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "MMCMXCVI";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\n2996\n", output);
    }

    [Test]
    public void Given_Empty_Roman_numeral_Should_Return_Error_Message()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\nRoman Numeral can not be empty.\n", output);
    }

    [Test]
    public void Given_Invalid_Roman_numeral_Should_Return_Error_Message()
    {
        //arrange
        var RomanConverter = new ConvertRomanNumerals();
        var romanNum = "MDEI";

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader(romanNum);
        Console.SetIn(stringReader);

        //act
        RomanConverter.ConvertRomanNum();

        //assert
        var output = stringWriter.ToString();
        Assert.AreEqual($"Please enter a Roman Numeral\nInvalid Roman Numerals.\n", output);
    }

}

