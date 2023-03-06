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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class BatchJobCheckResponseUnmarshaller
    {
        public static BatchJobCheckResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchJobCheckResponse batchJobCheckResponse = new BatchJobCheckResponse();

			batchJobCheckResponse.HttpResponse = _ctx.HttpResponse;
			batchJobCheckResponse.Success = _ctx.BooleanValue("BatchJobCheck.Success");
			batchJobCheckResponse.Code = _ctx.IntegerValue("BatchJobCheck.Code");
			batchJobCheckResponse.Message = _ctx.StringValue("BatchJobCheck.Message");
			batchJobCheckResponse.ErrCode = _ctx.StringValue("BatchJobCheck.ErrCode");
			batchJobCheckResponse.RequestId = _ctx.StringValue("BatchJobCheck.RequestId");

			BatchJobCheckResponse.BatchJobCheck_Data data = new BatchJobCheckResponse.BatchJobCheck_Data();
			data.TaskCount = _ctx.IntegerValue("BatchJobCheck.Data.TaskCount");
			data.FinishCount = _ctx.IntegerValue("BatchJobCheck.Data.FinishCount");
			data.FailedCount = _ctx.IntegerValue("BatchJobCheck.Data.FailedCount");
			data.TaskStatus = _ctx.StringValue("BatchJobCheck.Data.TaskStatus");
			data.ConfigId = _ctx.StringValue("BatchJobCheck.Data.ConfigId");
			data.FolderId = _ctx.StringValue("BatchJobCheck.Data.FolderId");

			List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem> data_errTaskList = new List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem>();
			for (int i = 0; i < _ctx.Length("BatchJobCheck.Data.ErrTaskList.Length"); i++) {
				BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem errTaskListItem = new BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem();
				errTaskListItem.UserId = _ctx.LongValue("BatchJobCheck.Data.ErrTaskList["+ i +"].UserId");

				List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem> errTaskListItem_productList = new List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem>();
				for (int j = 0; j < _ctx.Length("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList.Length"); j++) {
					BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem productListItem = new BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem();
					productListItem.ProductCode = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].ProductCode");

					List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem.BatchJobCheck_LogListItem> productListItem_logList = new List<BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem.BatchJobCheck_LogListItem>();
					for (int k = 0; k < _ctx.Length("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList.Length"); k++) {
						BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem.BatchJobCheck_LogListItem logListItem = new BatchJobCheckResponse.BatchJobCheck_Data.BatchJobCheck_ErrTaskListItem.BatchJobCheck_ProductListItem.BatchJobCheck_LogListItem();
						logListItem.ProductCode = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProductCode");
						logListItem.LogCode = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogCode");
						logListItem.RegionCode = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].RegionCode");
						logListItem.ProjectNamePattern = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProjectNamePattern");
						logListItem.LogStoreNamePattern = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogStoreNamePattern");
						logListItem.ErrorCode = _ctx.StringValue("BatchJobCheck.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ErrorCode");

						productListItem_logList.Add(logListItem);
					}
					productListItem.LogList = productListItem_logList;

					errTaskListItem_productList.Add(productListItem);
				}
				errTaskListItem.ProductList = errTaskListItem_productList;

				data_errTaskList.Add(errTaskListItem);
			}
			data.ErrTaskList = data_errTaskList;
			batchJobCheckResponse.Data = data;
        
			return batchJobCheckResponse;
        }
    }
}
