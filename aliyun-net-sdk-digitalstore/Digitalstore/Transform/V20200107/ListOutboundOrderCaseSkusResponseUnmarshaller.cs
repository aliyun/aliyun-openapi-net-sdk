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
    public class ListOutboundOrderCaseSkusResponseUnmarshaller
    {
        public static ListOutboundOrderCaseSkusResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundOrderCaseSkusResponse listOutboundOrderCaseSkusResponse = new ListOutboundOrderCaseSkusResponse();

			listOutboundOrderCaseSkusResponse.HttpResponse = context.HttpResponse;
			listOutboundOrderCaseSkusResponse.PageSize = context.IntegerValue("ListOutboundOrderCaseSkus.PageSize");
			listOutboundOrderCaseSkusResponse.TotalCount = context.IntegerValue("ListOutboundOrderCaseSkus.TotalCount");
			listOutboundOrderCaseSkusResponse.OrderByField = context.StringValue("ListOutboundOrderCaseSkus.OrderByField");
			listOutboundOrderCaseSkusResponse.PageNumber = context.IntegerValue("ListOutboundOrderCaseSkus.PageNumber");
			listOutboundOrderCaseSkusResponse.OrderByMethod = context.StringValue("ListOutboundOrderCaseSkus.OrderByMethod");
			listOutboundOrderCaseSkusResponse.RequestId = context.StringValue("ListOutboundOrderCaseSkus.RequestId");
			listOutboundOrderCaseSkusResponse.Success = context.BooleanValue("ListOutboundOrderCaseSkus.Success");

			List<ListOutboundOrderCaseSkusResponse.ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel> listOutboundOrderCaseSkusResponse_skuTags = new List<ListOutboundOrderCaseSkusResponse.ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel>();
			for (int i = 0; i < context.Length("ListOutboundOrderCaseSkus.SkuTags.Length"); i++) {
				ListOutboundOrderCaseSkusResponse.ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel inOutOrderCaseSkuModel = new ListOutboundOrderCaseSkusResponse.ListOutboundOrderCaseSkus_InOutOrderCaseSkuModel();
				inOutOrderCaseSkuModel.BindingQuantity = context.IntegerValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].BindingQuantity");
				inOutOrderCaseSkuModel.BarcodeId = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].BarcodeId");
				inOutOrderCaseSkuModel.Barcode = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].Barcode");
				inOutOrderCaseSkuModel.ProductCode = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductCode");
				inOutOrderCaseSkuModel.ProductSizeId = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeId");
				inOutOrderCaseSkuModel.ProductColorId = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductColorId");
				inOutOrderCaseSkuModel.CaseId = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].CaseId");
				inOutOrderCaseSkuModel.ProductColorName = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductColorName");
				inOutOrderCaseSkuModel.ProductName = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductName");
				inOutOrderCaseSkuModel.ProductSizeCode = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeCode");
				inOutOrderCaseSkuModel.ProductSizeName = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductSizeName");
				inOutOrderCaseSkuModel.CaseCode = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].CaseCode");
				inOutOrderCaseSkuModel.ProductId = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductId");
				inOutOrderCaseSkuModel.ProductColorCode = context.StringValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].ProductColorCode");
				inOutOrderCaseSkuModel.BoxQuantity = context.IntegerValue("ListOutboundOrderCaseSkus.SkuTags["+ i +"].BoxQuantity");

				listOutboundOrderCaseSkusResponse_skuTags.Add(inOutOrderCaseSkuModel);
			}
			listOutboundOrderCaseSkusResponse.SkuTags = listOutboundOrderCaseSkusResponse_skuTags;
        
			return listOutboundOrderCaseSkusResponse;
        }
    }
}
