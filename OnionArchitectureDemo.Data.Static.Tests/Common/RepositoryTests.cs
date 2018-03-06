using OnionArchitectureDemo.Data.Static.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnionArchitectureDemo.Domain.Common;
using Xunit;

namespace OnionArchitectureDemo.Data.Static.Tests.Common
{
    public class TestData : IDomainEntity
    {
        public string Value { get; set; }

        public TestData(string value)
        {
            Value = value;
        }
    }

    public class RepositoryTests
    {
        private readonly Repository<TestData> _subject;

        public RepositoryTests()
        {
            _subject = new Repository<TestData>();
        }

        [Fact]
        public void Constructor_InstansiatesStaticData_WithoutPopulating()
        {
            Assert.NotNull(_subject.StaticData);
            Assert.Empty(_subject.StaticData);
        }

        [Fact]
        public void Add_AddsToStaticData()
        {
            var dataToAdd = new TestData("test");

            Assert.DoesNotContain(dataToAdd, _subject.StaticData);

            _subject.Add(dataToAdd);

            Assert.Contains(dataToAdd, _subject.StaticData);
        }

        [Fact]
        public void Delete_RemovesFromStaticData()
        {
            var dataToAdd = new TestData("test");
            _subject.StaticData.Add(dataToAdd);

            Assert.Contains(dataToAdd, _subject.StaticData);

            _subject.Delete(dataToAdd);

            Assert.DoesNotContain(dataToAdd, _subject.StaticData);
        }

        [Fact]
        public void GetAll_ReturnsEveryItemInStaticData()
        {
            _subject.StaticData.Add(new TestData("test"));
            _subject.StaticData.Add(new TestData("test2"));
            _subject.StaticData.Add(new TestData("test3"));
            
            var result = _subject.GetAll();
            Assert.Equal(3, result.Count());
        }


        [Fact]
        public void Single_WhenSingleMatchingItemExists_ReturnsItem()
        {
            var expected = new TestData("test");
            _subject.StaticData.Add(expected);

            var result = _subject.Single(c => c.Value == "test");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Single_WhenSingleMatchingItemExists_ThrowsInvalidOperationException()
        {
            // add twice so that single will not work
            _subject.StaticData.Add(new TestData("test"));
            _subject.StaticData.Add(new TestData("test"));

            Assert.Throws<InvalidOperationException>(() => _subject.Single(c => c.Value == "test"));
        }

        [Fact]
        public void Single_WhenItemCannotBeFound_ReturnsNull()
        {
            _subject.StaticData.Add(new TestData("test"));

            var result = _subject.Single(c => c.Value == "DOES NOT EXIST");

            Assert.Null(result);
        }
    }
}
