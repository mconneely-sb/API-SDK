# IO.Swagger.Api.AdminsApi

All URIs are relative to *https://virtserver.swaggerhub.com/MConneely/AccountsAPI/1.0.4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Addaccounts**](AdminsApi.md#addaccounts) | **POST** /accounts | adds an accounts item


<a name="addaccounts"></a>
# **Addaccounts**
> List<AccountsItem> Addaccounts (AccountsItem accountsItem = null)

adds an accounts item

Adds an item to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddaccountsExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var accountsItem = new AccountsItem(); // AccountsItem | accounts item to add (optional) 

            try
            {
                // adds an accounts item
                List&lt;AccountsItem&gt; result = apiInstance.Addaccounts(accountsItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.Addaccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountsItem** | [**AccountsItem**](AccountsItem.md)| accounts item to add | [optional] 

### Return type

[**List<AccountsItem>**](AccountsItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

