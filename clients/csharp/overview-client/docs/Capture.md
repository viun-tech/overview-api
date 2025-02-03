# overview_client.Model.Capture

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Unique identifier of the capture | [optional] 
**CapturedAt** | **DateTime** | Timestamp when the capture was taken | [optional] 
**SourceRecipeId** | **int** | ID of the recipe used for this capture | [optional] 
**Path** | **string** | File path of the captured image | [optional] 
**Height** | **int** | Height of the captured image in pixels | [optional] 
**Width** | **int** | Width of the captured image in pixels | [optional] 
**Size** | **int** | Size of the captured image file in bytes | [optional] 
**ClassificationResult** | [**List&lt;CaptureClassificationResultInner&gt;**](CaptureClassificationResultInner.md) | List of classification results for each ROI | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

