# CaptureClassificationResultInner


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**created_at** | **datetime** | Timestamp when the classification was performed | [optional] 
**confidence** | **float** | Confidence score of the classification result | [optional] 
**block_classification_classes** | [**CaptureClassificationResultInnerBlockClassificationClasses**](CaptureClassificationResultInnerBlockClassificationClasses.md) |  | [optional] 
**roi_result** | [**CaptureClassificationResultInnerRoiResult**](CaptureClassificationResultInnerRoiResult.md) |  | [optional] 

## Example

```python
from overview_client.models.capture_classification_result_inner import CaptureClassificationResultInner

# TODO update the JSON string below
json = "{}"
# create an instance of CaptureClassificationResultInner from a JSON string
capture_classification_result_inner_instance = CaptureClassificationResultInner.from_json(json)
# print the JSON string representation of the object
print(CaptureClassificationResultInner.to_json())

# convert the object into a dict
capture_classification_result_inner_dict = capture_classification_result_inner_instance.to_dict()
# create an instance of CaptureClassificationResultInner from a dict
capture_classification_result_inner_from_dict = CaptureClassificationResultInner.from_dict(capture_classification_result_inner_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


