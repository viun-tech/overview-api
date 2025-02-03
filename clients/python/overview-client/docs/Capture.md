# Capture


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **int** | Unique identifier of the capture | [optional] 
**captured_at** | **datetime** | Timestamp when the capture was taken | [optional] 
**source_recipe_id** | **int** | ID of the recipe used for this capture | [optional] 
**path** | **str** | File path of the captured image | [optional] 
**height** | **int** | Height of the captured image in pixels | [optional] 
**width** | **int** | Width of the captured image in pixels | [optional] 
**size** | **int** | Size of the captured image file in bytes | [optional] 
**classification_result** | [**List[CaptureClassificationResultInner]**](CaptureClassificationResultInner.md) | List of classification results for each ROI | [optional] 

## Example

```python
from overview_client.models.capture import Capture

# TODO update the JSON string below
json = "{}"
# create an instance of Capture from a JSON string
capture_instance = Capture.from_json(json)
# print the JSON string representation of the object
print(Capture.to_json())

# convert the object into a dict
capture_dict = capture_instance.to_dict()
# create an instance of Capture from a dict
capture_from_dict = Capture.from_dict(capture_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


