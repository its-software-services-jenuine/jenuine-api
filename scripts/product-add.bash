#!/bin/bash

#--request POST \

curl --header "Content-Type: application/json" \
-k -v \
--data '{"ProductId":"abc1234-def", "ProductName":"name-0001-abc", "Description": "Seubpong Test BSON"}' \
https://localhost:5001/api/products/org/org-id-axssdd/action/AddProduct/
