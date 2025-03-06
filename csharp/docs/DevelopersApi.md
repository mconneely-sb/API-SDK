# IO.Swagger.Api.DevelopersApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/AccountsAPI/1.0.4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Searchaccounts**](DevelopersApi.md#searchaccounts) | **GET** /accounts | searches accounts


<a name="searchaccounts"></a>
# **Searchaccounts**
> List<AccountsItem> Searchaccounts (int? numberId = null, int? numberId2 = null, int? skip = null, int? limit = null)

searches accounts

By passing in the appropriate options, you can search for available accounts in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchaccountsExample
    {
        public void main()
        {
            var apiInstance = new DevelopersApi();
            var numberId = 56;  // int? | pass an optional search string for looking up accounts (optional) 
            var numberId2 = 56;  // int? | pass an optional search string for looking up accounts (optional) 
            var skip = 56;  // int? | number of records to skip for pagination (optional) 
            var limit = 56;  // int? | maximum number of records to return (optional) 

            try
            {
                // searches accounts
                List&lt;AccountsItem&gt; result = apiInstance.Searchaccounts(numberId, numberId2, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DevelopersApi.Searchaccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberId** | **int?**| pass an optional search string for looking up accounts | [optional] 
 **numberId2** | **int?**| pass an optional search string for looking up accounts | [optional] 
 **skip** | **int?**| number of records to skip for pagination | [optional] 
 **limit** | **int?**| maximum number of records to return | [optional] 

### Return type

[**List<AccountsItem>**](AccountsItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

