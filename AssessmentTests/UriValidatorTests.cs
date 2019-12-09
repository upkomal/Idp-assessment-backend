using System;
using System.Collections.Generic;
using Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssessmentTests
{
    [TestClass]
    public class UriValidatorTests
    {
        [TestMethod]
        public void AbsoluteURISuccess()
        {
            //setup
            bool expected = true;
            string uri = "https://app.confirmit.com/auth/logincallback";
            IEnumerable<string> rules = new List<string>(new[] {
        "https://app.confirmit.com/auth/logincallback"
      });

            //action
            bool result = UriValidators.Validate(uri, rules);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AbsoluteURIFail()
        {
            //setup
            bool not_expected = true;
            string uri = "https://app.test.com/auth/logincallback";
            IEnumerable<string> rules = new List<string>(new[] {
        "https://app.confirmit.com/auth/logincallback"
      });

            bool result = UriValidators.Validate(uri, rules);

            Assert.AreNotEqual(not_expected, result);
        }

        [TestMethod]
        public void WildcardURISuccess1()
        {
            bool expected = true;
            string uri = "https://www.confirmit.com/www/logincallback";
            IEnumerable<string> rules = new List<string>(new[] {
        "https://*.confirmit.com/*/logincallback"
      });

            bool result = UriValidators.Validate(uri, rules);

            Assert.AreEqual(expected, result);
        }
    }
}
