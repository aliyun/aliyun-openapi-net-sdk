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
    public class ListProduceOrderCaseSkusResponseUnmarshaller
    {
        public static ListProduceOrderCaseSkusResponse Unmarshall(UnmarshallerContext context)
        {
			ListProduceOrderCaseSkusResponse listProduceOrderCaseSkusResponse = new ListProduceOrderCaseSkusResponse();

			listProduceOrderCaseSkusResponse.HttpResponse = context.HttpResponse;
			listProduceOrderCaseSkusResponse.PageSize = context.IntegerValue("ListProduceOrderCaseSkus.PageSize");
			listProduceOrderCaseSkusResponse.TotalCount = context.IntegerValue("ListProduceOrderCaseSkus.TotalCount");
			listProduceOrderCaseSkusResponse.PageNumber = context.IntegerValue("ListProduceOrderCaseSkus.PageNumber");
			listProduceOrderCaseSkusResponse.RequestId = context.StringValue("ListProduceOrderCaseSkus.RequestId");
			listProduceOrderCaseSkusResponse.Success = context.BooleanValue("ListProduceOrderCaseSkus.Success");

			List<ListProduceOrderCaseSkusResponse.ListProduceOrderCaseSkus_ProduceOrderCaseSkuModel> listProduceOrderCaseSkusResponse_productionOrderCaseSkus = new List<ListProduceOrderCaseSkusResponse.ListProduceOrderCaseSkus_ProduceOrderCaseSkuModel>();
			for (int i = 0; i < context.Length("ListProduceOrderCaseSkus.ProductionOrderCaseSkus.Length"); i++) {
				ListProduceOrderCaseSkusResponse.ListProduceOrderCaseSkus_ProduceOrderCaseSkuModel produceOrderCaseSkuModel = new ListProduceOrderCaseSkusResponse.ListProduceOrderCaseSkus_ProduceOrderCaseSkuModel();
				produceOrderCaseSkuModel.ProductSizeName = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductSizeName");
				produceOrderCaseSkuModel.CaseCode = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].CaseCode");
				produceOrderCaseSkuModel.BoxQuantity = context.IntegerValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].BoxQuantity");
				produceOrderCaseSkuModel.ProductId = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductId");
				produceOrderCaseSkuModel.ProductColorCode = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductColorCode");
				produceOrderCaseSkuModel.ProductName = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductName");
				produceOrderCaseSkuModel.ProductSizeCode = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductSizeCode");
				produceOrderCaseSkuModel.ProductCode = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductCode");
				produceOrderCaseSkuModel.ProductSizeId = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductSizeId");
				produceOrderCaseSkuModel.ProductColorId = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductColorId");
				produceOrderCaseSkuModel.CaseId = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].CaseId");
				produceOrderCaseSkuModel.ProductColorName = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].ProductColorName");
				produceOrderCaseSkuModel.BindingQuantity = context.IntegerValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].BindingQuantity");
				produceOrderCaseSkuModel.BarcodeId = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].BarcodeId");
				produceOrderCaseSkuModel.Barcode = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].Barcode");
				produceOrderCaseSkuModel.SKUName = context.StringValue("ListProduceOrderCaseSkus.ProductionOrderCaseSkus["+ i +"].SKUName");

				listProduceOrderCaseSkusResponse_productionOrderCaseSkus.Add(produceOrderCaseSkuModel);
			}
			listProduceOrderCaseSkusResponse.ProductionOrderCaseSkus = listProduceOrderCaseSkusResponse_productionOrderCaseSkus;
        
			return listProduceOrderCaseSkusResponse;
        }
    }
}
