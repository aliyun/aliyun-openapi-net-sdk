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
    public class ListProduceOrderLinesResponseUnmarshaller
    {
        public static ListProduceOrderLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListProduceOrderLinesResponse listProduceOrderLinesResponse = new ListProduceOrderLinesResponse();

			listProduceOrderLinesResponse.HttpResponse = context.HttpResponse;
			listProduceOrderLinesResponse.PageSize = context.IntegerValue("ListProduceOrderLines.PageSize");
			listProduceOrderLinesResponse.TotalCount = context.IntegerValue("ListProduceOrderLines.TotalCount");
			listProduceOrderLinesResponse.PageNumber = context.IntegerValue("ListProduceOrderLines.PageNumber");
			listProduceOrderLinesResponse.RequestId = context.StringValue("ListProduceOrderLines.RequestId");
			listProduceOrderLinesResponse.Success = context.BooleanValue("ListProduceOrderLines.Success");

			List<ListProduceOrderLinesResponse.ListProduceOrderLines_ProduceOrderLineModel> listProduceOrderLinesResponse_produceOrderLines = new List<ListProduceOrderLinesResponse.ListProduceOrderLines_ProduceOrderLineModel>();
			for (int i = 0; i < context.Length("ListProduceOrderLines.ProduceOrderLines.Length"); i++) {
				ListProduceOrderLinesResponse.ListProduceOrderLines_ProduceOrderLineModel produceOrderLineModel = new ListProduceOrderLinesResponse.ListProduceOrderLines_ProduceOrderLineModel();
				produceOrderLineModel.ProductId = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductId");
				produceOrderLineModel.ProductColorCode = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductColorCode");
				produceOrderLineModel.OrderId = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].OrderId");
				produceOrderLineModel.UpdateDate = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].UpdateDate");
				produceOrderLineModel.ProductSizeName = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductSizeName");
				produceOrderLineModel.ProductName = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductName");
				produceOrderLineModel.ProductSizeCode = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductSizeCode");
				produceOrderLineModel.OperateQuantity = context.IntegerValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].OperateQuantity");
				produceOrderLineModel.CreateDate = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].CreateDate");
				produceOrderLineModel.InboundQuantity = context.IntegerValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].InboundQuantity");
				produceOrderLineModel.BoxedNum = context.IntegerValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].BoxedNum");
				produceOrderLineModel.Quantity = context.IntegerValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].Quantity");
				produceOrderLineModel.ProductColorName = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductColorName");
				produceOrderLineModel.ProductCode = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].ProductCode");
				produceOrderLineModel.BusinessPrice = context.IntegerValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].BusinessPrice");
				produceOrderLineModel.BarcodeId = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].BarcodeId");
				produceOrderLineModel.Barcode = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].Barcode");
				produceOrderLineModel.SKUName = context.StringValue("ListProduceOrderLines.ProduceOrderLines["+ i +"].SKUName");

				listProduceOrderLinesResponse_produceOrderLines.Add(produceOrderLineModel);
			}
			listProduceOrderLinesResponse.ProduceOrderLines = listProduceOrderLinesResponse_produceOrderLines;
        
			return listProduceOrderLinesResponse;
        }
    }
}
