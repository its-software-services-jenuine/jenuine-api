#!/bin/bash

curl --header "Content-Type: application/json" \
--request PUT \
-k -v \
--data '{"ProductId":"abc1234-modified", "ProductName":"name-0001-modified", "Description": "Seubpong modified"}' \
https://localhost:5001/api/products/org/org-id-axssdd/action/UpdateProductById/60e15b472931e2426b24a3b8
