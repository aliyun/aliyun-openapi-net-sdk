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
    public class ListInboundOrderCaseSkusResponseUnmarshaller
    {
        public static ListInboundOrderCaseSkusResponse Unmarshall(UnmarshallerContext context)
        {
			ListInboundOrderCaseSkusResponse listInboundOrderCaseSkusResponse = new ListInboundOrderCaseSkusResponse();

			listInboundOrderCaseSkusResponse.HttpResponse = context.HttpResponse;
			listInboundOrderCaseSkusResponse.PageSize = context.IntegerValue("ListInboundOrderCaseSkus.PageSize");
			listInboundOrderCaseSkusResponse.TotalCount = context.IntegerValue("ListInboundOrderCaseSkus.TotalCount");
			listInboundOrderCaseSkusResponse.OrderByField = context.StringValue("ListInboundOrderCaseSkus.OrderByField");
			listInboundOrderCaseSkusResponse.PageNumber = context.IntegerValue("ListInboundOrderCaseSkus.PageNumber");
			listInboundOrderCaseSkusResponse.OrderByMethod = context.StringValue("ListInboundOrderCaseSkus.OrderByMethod");
			listInboundOrderCaseSkusResponse.RequestId = context.StringValue("ListInboundOrderCaseSkus.RequestId");
			listInboundOrderCaseSkusResponse.Success = context.BooleanValue("ListInboundOrderCaseSkus.Success");

			List<ListInboundOrderCaseSkusResponse.ListInboundOrderCaseSkus_InOutOrderCaseSkuModel> listInboundOrderCaseSkusResponse_skuTags = new List<ListInboundOrderCaseSkusResponse.ListInboundOrderCaseSkus_InOutOrderCaseSkuModel>();
			for (int i = 0; i < context.Length("ListInboundOrderCaseSkus.SkuTags.Length"); i++) {
				ListInboundOrderCaseSkusResponse.ListInboundOrderCaseSkus_InOutOrderCaseSkuModel inOutOrderCaseSkuModel = new ListInboundOrderCaseSkusResponse.ListInboundOrderCaseSkus_InOutOrderCaseSkuModel();
				inOutOrderCaseSkuModel.BindingQuantity = context.IntegerValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].BindingQuantity");
				inOutOrderCaseSkuModel.BarcodeId = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].BarcodeId");
				inOutOrderCaseSkuModel.Barcode = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].Barcode");
				inOutOrderCaseSkuModel.ProductCode = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductCode");
				inOutOrderCaseSkuModel.ProductSizeId = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeId");
				inOutOrderCaseSkuModel.ProductColorId = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductColorId");
				inOutOrderCaseSkuModel.CaseId = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].CaseId");
				inOutOrderCaseSkuModel.ProductColorName = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductColorName");
				inOutOrderCaseSkuModel.ProductName = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductName");
				inOutOrderCaseSkuModel.ProductSizeCode = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeCode");
				inOutOrderCaseSkuModel.ProductSizeName = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeName");
				inOutOrderCaseSkuModel.CaseCode = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].CaseCode");
				inOutOrderCaseSkuModel.ProductId = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductId");
				inOutOrderCaseSkuModel.ProductColorCode = context.StringValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].ProductColorCode");
				inOutOrderCaseSkuModel.BoxQuantity = context.IntegerValue("ListInboundOrderCaseSkus.SkuTags["+ i +"].BoxQuantity");

				listInboundOrderCaseSkusResponse_skuTags.Add(inOutOrderCaseSkuModel);
			}
			listInboundOrderCaseSkusResponse.SkuTags = listInboundOrderCaseSkusResponse_skuTags;
        
			return listInboundOrderCaseSkusResponse;
        }
    }
}
