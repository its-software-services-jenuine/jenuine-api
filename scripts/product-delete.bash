#!/bin/bash

curl --header "Content-Type: application/json" \
--request DELETE \
-k -v \
https://localhost:5001/api/products/org/org-id-axssdd/action/DeleteProductById/60d883a9d827ec777d1462b6/
