/* 
 * Accounts API
 *
 * Accounts API
 *
 * OpenAPI spec version: 1.0.4
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DevelopersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DevelopersApiTests
    {
        private DevelopersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DevelopersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DevelopersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DevelopersApi
            //Assert.IsInstanceOfType(typeof(DevelopersApi), instance, "instance is a DevelopersApi");
        }

        
        /// <summary>
        /// Test Searchaccounts
        /// </summary>
        [Test]
        public void SearchaccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? numberId = null;
            //int? numberId2 = null;
            //int? skip = null;
            //int? limit = null;
            //var response = instance.Searchaccounts(numberId, numberId2, skip, limit);
            //Assert.IsInstanceOf<List<AccountsItem>> (response, "response is List<AccountsItem>");
        }
        
    }

}
