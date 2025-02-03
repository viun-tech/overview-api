# CaptureClassificationResultInnerBlockClassificationClasses


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**label_name** | **str** | Classification label assigned to the ROI | [optional] 
**block_roi_inspection_type_params** | [**CaptureClassificationResultInnerBlockClassificationClassesBlockRoiInspectionTypeParams**](CaptureClassificationResultInnerBlockClassificationClassesBlockRoiInspectionTypeParams.md) |  | [optional] 

## Example

```python
from overview_client.models.capture_classification_result_inner_block_classification_classes import CaptureClassificationResultInnerBlockClassificationClasses

# TODO update the JSON string below
json = "{}"
# create an instance of CaptureClassificationResultInnerBlockClassificationClasses from a JSON string
capture_classification_result_inner_block_classification_classes_instance = CaptureClassificationResultInnerBlockClassificationClasses.from_json(json)
# print the JSON string representation of the object
print(CaptureClassificationResultInnerBlockClassificationClasses.to_json())

# convert the object into a dict
capture_classification_result_inner_block_classification_classes_dict = capture_classification_result_inner_block_classification_classes_instance.to_dict()
# create an instance of CaptureClassificationResultInnerBlockClassificationClasses from a dict
capture_classification_result_inner_block_classification_classes_from_dict = CaptureClassificationResultInnerBlockClassificationClasses.from_dict(capture_classification_result_inner_block_classification_classes_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


