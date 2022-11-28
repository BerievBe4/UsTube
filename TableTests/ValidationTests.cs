using TableBoi.Controllers.Helpers;
using Xunit;

namespace TableTests
{
    public class ValidationTests
    {
        [Fact]
        public void Validate_TaskNameDoesNotContainExclamationMark_Success()
        {
            // Arange
            var name = "TaskName";
            var descr = "TaskDescr";

            // Act
            var result = ValidationHelper.ValidateName(name, descr);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Validate_TaskNameContainsExclamationMark_Error()
        {
            // Arange
            var name = "Task!Name";
            var descr = "TaskDescr";

            // Act
            var result = ValidationHelper.ValidateName(name, descr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_TaskParamethersIsNotNull_Success()
        {
            // Arange
            var name = "TaskName";
            var descr = "TaskDescr";

            // Act
            var result = ValidationHelper.ValidateName(name, descr);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Validate_TaskParamethersAreNull_Error()
        {
            // Arange
            string name = null, descr = null;

            // Act
            var result = ValidationHelper.ValidateName(name, descr);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Validate_TaskParamethersAreEmpty_Error()
        {
            // Arange
            var name = "";
            var descr = "";

            // Act
            var result = ValidationHelper.ValidateName(name, descr);

            // Assert
            Assert.False(result);
        }
    }
}
