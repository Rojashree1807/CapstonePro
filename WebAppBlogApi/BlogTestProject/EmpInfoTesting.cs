using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppBlogApi.Models;

namespace BlogTestProject
{
    [TestFixture]
    public class EmpInfoTesting
    {
        [Test]
        public void EmpInfo_ValidData_ShouldPassValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                EmailId = "aishu12@gmail.com",
                Name = "Aishu",
                PassCode = 1234
            };

            // Act
            var validationResults = ValidateModel(empInfo);

            // Assert
            Assert.IsEmpty(validationResults, "Validation should pass");
        }

        [Test]
        public void EmpInfo_MissingEmail_ShouldFailValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                // Missing Email intentionally
                Name = "Aishu",
                PassCode = 1234
            };

            // Act
            var validationResults = ValidateModel(empInfo);

            // Assert
            Assert.IsNotEmpty(validationResults, "Validation should fail");
            Assert.IsTrue(HasErrorMessage(validationResults, "The Email field is required."));
        }
        private System.Collections.Generic.List<ValidationResult> ValidateModel(object model)
        {
            var validationContext = new ValidationContext(model, null, null);
            var validationResults = new System.Collections.Generic.List<ValidationResult>();

            Validator.TryValidateObject(model, validationContext, validationResults, true);

            return validationResults;
        }

        private bool HasErrorMessage(System.Collections.Generic.List<ValidationResult> validationResults, string errorMessage)
        {
            return validationResults.Any(result => result.ErrorMessage != null && result.ErrorMessage.Contains(errorMessage));
        }

    }

}

