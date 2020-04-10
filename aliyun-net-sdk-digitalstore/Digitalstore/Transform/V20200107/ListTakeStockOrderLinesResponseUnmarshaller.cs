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
    public class ListTakeStockOrderLinesResponseUnmarshaller
    {
        public static ListTakeStockOrderLinesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTakeStockOrderLinesResponse listTakeStockOrderLinesResponse = new ListTakeStockOrderLinesResponse();

			listTakeStockOrderLinesResponse.HttpResponse = context.HttpResponse;
			listTakeStockOrderLinesResponse.PageSize = context.IntegerValue("ListTakeStockOrderLines.PageSize");
			listTakeStockOrderLinesResponse.TotalCount = context.IntegerValue("ListTakeStockOrderLines.TotalCount");
			listTakeStockOrderLinesResponse.PageNumber = context.IntegerValue("ListTakeStockOrderLines.PageNumber");
			listTakeStockOrderLinesResponse.RequestId = context.StringValue("ListTakeStockOrderLines.RequestId");
			listTakeStockOrderLinesResponse.Success = context.BooleanValue("ListTakeStockOrderLines.Success");

			List<ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_TakeStockOrderLineModel> listTakeStockOrderLinesResponse_takeStockOrderLines = new List<ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_TakeStockOrderLineModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrderLines.TakeStockOrderLines.Length"); i++) {
				ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_TakeStockOrderLineModel takeStockOrderLineModel = new ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_TakeStockOrderLineModel();
				takeStockOrderLineModel.DifferenceAmount = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].DifferenceAmount");
				takeStockOrderLineModel.ProductName = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductName");
				takeStockOrderLineModel.ProductSizeCode = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductSizeCode");
				takeStockOrderLineModel.OperateQuantity = context.IntegerValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].OperateQuantity");
				takeStockOrderLineModel.CreateDate = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].CreateDate");
				takeStockOrderLineModel.UpdateDate = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].UpdateDate");
				takeStockOrderLineModel.ConfirmQuantity = context.IntegerValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ConfirmQuantity");
				takeStockOrderLineModel.ProductSizeName = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductSizeName");
				takeStockOrderLineModel.SnapQuantity = context.IntegerValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].SnapQuantity");
				takeStockOrderLineModel.ConfirmAmount = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ConfirmAmount");
				takeStockOrderLineModel.SkuCurrentPrice = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].SkuCurrentPrice");
				takeStockOrderLineModel.ProductColorCode = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductColorCode");
				takeStockOrderLineModel.DifferenceQuantity = context.IntegerValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].DifferenceQuantity");
				takeStockOrderLineModel.BarcodeId = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].BarcodeId");
				takeStockOrderLineModel.OperateAmount = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].OperateAmount");
				takeStockOrderLineModel.OrderLineId = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].OrderLineId");
				takeStockOrderLineModel.Barcode = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].Barcode");
				takeStockOrderLineModel.SkuRetailPrice = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].SkuRetailPrice");
				takeStockOrderLineModel.SnapAmount = context.FloatValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].SnapAmount");
				takeStockOrderLineModel.ProductCode = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductCode");
				takeStockOrderLineModel.TakeStockOrderId = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].TakeStockOrderId");
				takeStockOrderLineModel.ProductColorName = context.StringValue("ListTakeStockOrderLines.TakeStockOrderLines["+ i +"].ProductColorName");

				listTakeStockOrderLinesResponse_takeStockOrderLines.Add(takeStockOrderLineModel);
			}
			listTakeStockOrderLinesResponse.TakeStockOrderLines = listTakeStockOrderLinesResponse_takeStockOrderLines;

			List<ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_SummaryModel> listTakeStockOrderLinesResponse_summarys = new List<ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_SummaryModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrderLines.Summarys.Length"); i++) {
				ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_SummaryModel summaryModel = new ListTakeStockOrderLinesResponse.ListTakeStockOrderLines_SummaryModel();
				summaryModel.DifferenceQuantity = context.IntegerValue("ListTakeStockOrderLines.Summarys["+ i +"].DifferenceQuantity");
				summaryModel.SnapRetailAmount = context.FloatValue("ListTakeStockOrderLines.Summarys["+ i +"].SnapRetailAmount");
				summaryModel.OperateQuantity = context.IntegerValue("ListTakeStockOrderLines.Summarys["+ i +"].OperateQuantity");
				summaryModel.DifferenceRetailAmount = context.FloatValue("ListTakeStockOrderLines.Summarys["+ i +"].DifferenceRetailAmount");
				summaryModel.OperateAmount = context.FloatValue("ListTakeStockOrderLines.Summarys["+ i +"].OperateAmount");
				summaryModel.ConfirmQuantity = context.IntegerValue("ListTakeStockOrderLines.Summarys["+ i +"].ConfirmQuantity");
				summaryModel.SnapQuantity = context.IntegerValue("ListTakeStockOrderLines.Summarys["+ i +"].SnapQuantity");
				summaryModel.ConfirmRetailAmount = context.FloatValue("ListTakeStockOrderLines.Summarys["+ i +"].ConfirmRetailAmount");

				listTakeStockOrderLinesResponse_summarys.Add(summaryModel);
			}
			listTakeStockOrderLinesResponse.Summarys = listTakeStockOrderLinesResponse_summarys;
        
			return listTakeStockOrderLinesResponse;
        }
    }
}
