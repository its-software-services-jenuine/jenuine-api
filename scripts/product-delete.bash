#!/bin/bash

curl --header "Content-Type: application/json" \
--request DELETE \
-k -v \
https://localhost:5001/api/products/org/org-id-axssdd/action/DeleteProductById/60e147d33d5a5e81ba177d08/
