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
    public class DescribeJobStatusResponseUnmarshaller
    {
        public static DescribeJobStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeJobStatusResponse describeJobStatusResponse = new DescribeJobStatusResponse();

			describeJobStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeJobStatusResponse.Success = _ctx.BooleanValue("DescribeJobStatus.Success");
			describeJobStatusResponse.Code = _ctx.IntegerValue("DescribeJobStatus.Code");
			describeJobStatusResponse.Message = _ctx.StringValue("DescribeJobStatus.Message");
			describeJobStatusResponse.ErrCode = _ctx.StringValue("DescribeJobStatus.ErrCode");
			describeJobStatusResponse.RequestId = _ctx.StringValue("DescribeJobStatus.RequestId");

			DescribeJobStatusResponse.DescribeJobStatus_Data data = new DescribeJobStatusResponse.DescribeJobStatus_Data();
			data.TaskCount = _ctx.IntegerValue("DescribeJobStatus.Data.TaskCount");
			data.FinishCount = _ctx.IntegerValue("DescribeJobStatus.Data.FinishCount");
			data.FailedCount = _ctx.IntegerValue("DescribeJobStatus.Data.FailedCount");
			data.TaskStatus = _ctx.StringValue("DescribeJobStatus.Data.TaskStatus");
			data.ConfigId = _ctx.StringValue("DescribeJobStatus.Data.ConfigId");
			data.FolderId = _ctx.StringValue("DescribeJobStatus.Data.FolderId");

			List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem> data_errTaskList = new List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem>();
			for (int i = 0; i < _ctx.Length("DescribeJobStatus.Data.ErrTaskList.Length"); i++) {
				DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem errTaskListItem = new DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem();
				errTaskListItem.UserId = _ctx.LongValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].UserId");

				List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem> errTaskListItem_productList = new List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem>();
				for (int j = 0; j < _ctx.Length("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList.Length"); j++) {
					DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem productListItem = new DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem();
					productListItem.ProductCode = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].ProductCode");

					List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem.DescribeJobStatus_LogListItem> productListItem_logList = new List<DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem.DescribeJobStatus_LogListItem>();
					for (int k = 0; k < _ctx.Length("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList.Length"); k++) {
						DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem.DescribeJobStatus_LogListItem logListItem = new DescribeJobStatusResponse.DescribeJobStatus_Data.DescribeJobStatus_ErrTaskListItem.DescribeJobStatus_ProductListItem.DescribeJobStatus_LogListItem();
						logListItem.ProductCode = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProductCode");
						logListItem.LogCode = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogCode");
						logListItem.RegionCode = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].RegionCode");
						logListItem.ProjectNamePattern = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ProjectNamePattern");
						logListItem.LogStoreNamePattern = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].LogStoreNamePattern");
						logListItem.ErrorCode = _ctx.StringValue("DescribeJobStatus.Data.ErrTaskList["+ i +"].ProductList["+ j +"].LogList["+ k +"].ErrorCode");

						productListItem_logList.Add(logListItem);
					}
					productListItem.LogList = productListItem_logList;

					errTaskListItem_productList.Add(productListItem);
				}
				errTaskListItem.ProductList = errTaskListItem_productList;

				data_errTaskList.Add(errTaskListItem);
			}
			data.ErrTaskList = data_errTaskList;
			describeJobStatusResponse.Data = data;
        
			return describeJobStatusResponse;
        }
    }
}
