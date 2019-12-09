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
    }
}
