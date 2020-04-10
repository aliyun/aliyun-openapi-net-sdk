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
    public class ListTakeStockOrderTaskSkuTagsResponseUnmarshaller
    {
        public static ListTakeStockOrderTaskSkuTagsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTakeStockOrderTaskSkuTagsResponse listTakeStockOrderTaskSkuTagsResponse = new ListTakeStockOrderTaskSkuTagsResponse();

			listTakeStockOrderTaskSkuTagsResponse.HttpResponse = context.HttpResponse;
			listTakeStockOrderTaskSkuTagsResponse.PageSize = context.IntegerValue("ListTakeStockOrderTaskSkuTags.PageSize");
			listTakeStockOrderTaskSkuTagsResponse.TotalCount = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TotalCount");
			listTakeStockOrderTaskSkuTagsResponse.PageNumber = context.IntegerValue("ListTakeStockOrderTaskSkuTags.PageNumber");
			listTakeStockOrderTaskSkuTagsResponse.RequestId = context.StringValue("ListTakeStockOrderTaskSkuTags.RequestId");
			listTakeStockOrderTaskSkuTagsResponse.Success = context.BooleanValue("ListTakeStockOrderTaskSkuTags.Success");

			List<ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TakeStockOrderTaskSkuTagModel> listTakeStockOrderTaskSkuTagsResponse_takeStockOrderTaskSkuTags = new List<ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TakeStockOrderTaskSkuTagModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags.Length"); i++) {
				ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TakeStockOrderTaskSkuTagModel takeStockOrderTaskSkuTagModel = new ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TakeStockOrderTaskSkuTagModel();
				takeStockOrderTaskSkuTagModel.BError = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].BError");
				takeStockOrderTaskSkuTagModel.Epc = context.StringValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].Epc");
				takeStockOrderTaskSkuTagModel.OperateQuantity = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].OperateQuantity");
				takeStockOrderTaskSkuTagModel.BarcodeId = context.StringValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].BarcodeId");
				takeStockOrderTaskSkuTagModel.Barcode = context.StringValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].Barcode");
				takeStockOrderTaskSkuTagModel.TakeStockOrderId = context.StringValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].TakeStockOrderId");
				takeStockOrderTaskSkuTagModel.TakeStockTaskId = context.StringValue("ListTakeStockOrderTaskSkuTags.TakeStockOrderTaskSkuTags["+ i +"].TakeStockTaskId");

				listTakeStockOrderTaskSkuTagsResponse_takeStockOrderTaskSkuTags.Add(takeStockOrderTaskSkuTagModel);
			}
			listTakeStockOrderTaskSkuTagsResponse.TakeStockOrderTaskSkuTags = listTakeStockOrderTaskSkuTagsResponse_takeStockOrderTaskSkuTags;

			List<ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TaskSkuTagSummaryModel> listTakeStockOrderTaskSkuTagsResponse_taskSkuTagSummarys = new List<ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TaskSkuTagSummaryModel>();
			for (int i = 0; i < context.Length("ListTakeStockOrderTaskSkuTags.TaskSkuTagSummarys.Length"); i++) {
				ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TaskSkuTagSummaryModel taskSkuTagSummaryModel = new ListTakeStockOrderTaskSkuTagsResponse.ListTakeStockOrderTaskSkuTags_TaskSkuTagSummaryModel();
				taskSkuTagSummaryModel.ScanQuantity = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TaskSkuTagSummarys["+ i +"].ScanQuantity");
				taskSkuTagSummaryModel.RfidQuantity = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TaskSkuTagSummarys["+ i +"].RfidQuantity");
				taskSkuTagSummaryModel.TotalQuantity = context.IntegerValue("ListTakeStockOrderTaskSkuTags.TaskSkuTagSummarys["+ i +"].TotalQuantity");

				listTakeStockOrderTaskSkuTagsResponse_taskSkuTagSummarys.Add(taskSkuTagSummaryModel);
			}
			listTakeStockOrderTaskSkuTagsResponse.TaskSkuTagSummarys = listTakeStockOrderTaskSkuTagsResponse_taskSkuTagSummarys;
        
			return listTakeStockOrderTaskSkuTagsResponse;
        }
    }
}
