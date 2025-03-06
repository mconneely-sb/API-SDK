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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// Find account by ID
        /// </summary>
        /// <remarks>Returns a single account</remarks>
        /// <param name="id">ID of account to get</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Product not found</response>
        [HttpGet]
        [Route("/MConneely/AccountsAPI/1.0.4/accounts/{id}")]
        [ValidateModelState]
        [SwaggerOperation("GetAccountByID")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountsItem), description: "successful operation")]
        public virtual IActionResult GetAccountByID([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountsItem));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            string exampleJson = null;
            exampleJson = "{\"empty\": false}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<AccountsItem>(exampleJson)
            : default(AccountsItem);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
