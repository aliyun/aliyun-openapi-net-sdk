/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.digitalstore.Model.V20200107;

namespace Aliyun.Acs.digitalstore.Transform.V20200107
{
    public class ListApplicationOrderCaseSKUResponseUnmarshaller
    {
        public static ListApplicationOrderCaseSKUResponse Unmarshall(UnmarshallerContext context)
        {
			ListApplicationOrderCaseSKUResponse listApplicationOrderCaseSKUResponse = new ListApplicationOrderCaseSKUResponse();

			listApplicationOrderCaseSKUResponse.HttpResponse = context.HttpResponse;
			listApplicationOrderCaseSKUResponse.PageSize = context.IntegerValue("ListApplicationOrderCaseSKU.PageSize");
			listApplicationOrderCaseSKUResponse.TotalCount = context.IntegerValue("ListApplicationOrderCaseSKU.TotalCount");
			listApplicationOrderCaseSKUResponse.PageNumber = context.IntegerValue("ListApplicationOrderCaseSKU.PageNumber");
			listApplicationOrderCaseSKUResponse.RequestId = context.StringValue("ListApplicationOrderCaseSKU.RequestId");
			listApplicationOrderCaseSKUResponse.Success = context.BooleanValue("ListApplicationOrderCaseSKU.Success");

			List<ListApplicationOrderCaseSKUResponse.ListApplicationOrderCaseSKU_ApplyOrderCaseSkuModel> listApplicationOrderCaseSKUResponse_applyOrderCaseSkus = new List<ListApplicationOrderCaseSKUResponse.ListApplicationOrderCaseSKU_ApplyOrderCaseSkuModel>();
			for (int i = 0; i < context.Length("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus.Length"); i++) {
				ListApplicationOrderCaseSKUResponse.ListApplicationOrderCaseSKU_ApplyOrderCaseSkuModel applyOrderCaseSkuModel = new ListApplicationOrderCaseSKUResponse.ListApplicationOrderCaseSKU_ApplyOrderCaseSkuModel();
				applyOrderCaseSkuModel.ProductSizeName = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductSizeName");
				applyOrderCaseSkuModel.CaseCode = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].CaseCode");
				applyOrderCaseSkuModel.BoxQuantity = context.IntegerValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].BoxQuantity");
				applyOrderCaseSkuModel.ProductId = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductId");
				applyOrderCaseSkuModel.ProductColorCode = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductColorCode");
				applyOrderCaseSkuModel.ProductName = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductName");
				applyOrderCaseSkuModel.ProductSizeCode = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductSizeCode");
				applyOrderCaseSkuModel.ProductCode = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductCode");
				applyOrderCaseSkuModel.ProductSizeId = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductSizeId");
				applyOrderCaseSkuModel.ProductColorId = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductColorId");
				applyOrderCaseSkuModel.CaseId = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].CaseId");
				applyOrderCaseSkuModel.ProductColorName = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].ProductColorName");
				applyOrderCaseSkuModel.BindingQuantity = context.IntegerValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].BindingQuantity");
				applyOrderCaseSkuModel.BarcodeId = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].BarcodeId");
				applyOrderCaseSkuModel.Barcode = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].Barcode");
				applyOrderCaseSkuModel.SKUName = context.StringValue("ListApplicationOrderCaseSKU.ApplyOrderCaseSkus["+ i +"].SKUName");

				listApplicationOrderCaseSKUResponse_applyOrderCaseSkus.Add(applyOrderCaseSkuModel);
			}
			listApplicationOrderCaseSKUResponse.ApplyOrderCaseSkus = listApplicationOrderCaseSKUResponse_applyOrderCaseSkus;
        
			return listApplicationOrderCaseSKUResponse;
        }
    }
}
