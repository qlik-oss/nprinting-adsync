# Qlik.NPrinting.Rest.Client.Model.FilterField
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionId** | **Guid?** | The unique identifier that represents a specific connection. | [optional] 
**Name** | **string** | The name of the filter field. | [optional] 
**OverrideValues** | **bool?** | Indicates whether the values of this filter field should override the values of the filter fields (with same name and connectionId) previously applied in the filter chain, if any. | [optional] 
**Values** | [**List&lt;FilterFieldValue&gt;**](FilterFieldValue.md) | The values of the filter field. If overrideValues flag is set to false the array must not be empty. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

