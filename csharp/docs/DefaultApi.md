# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/AccountsAPI/1.0.4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountByID**](DefaultApi.md#getaccountbyid) | **GET** /accounts/{id} | Find account by ID


<a name="getaccountbyid"></a>
# **GetAccountByID**
> AccountsItem GetAccountByID (string id)

Find account by ID

Returns a single account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAccountByIDExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var id = id_example;  // string | ID of account to get

            try
            {
                // Find account by ID
                AccountsItem result = apiInstance.GetAccountByID(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAccountByID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| ID of account to get | 

### Return type

[**AccountsItem**](AccountsItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

