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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryDeviceFileListResponseUnmarshaller
    {
        public static QueryDeviceFileListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceFileListResponse queryDeviceFileListResponse = new QueryDeviceFileListResponse();

			queryDeviceFileListResponse.HttpResponse = context.HttpResponse;
			queryDeviceFileListResponse.RequestId = context.StringValue("QueryDeviceFileList.RequestId");
			queryDeviceFileListResponse.Success = context.BooleanValue("QueryDeviceFileList.Success");
			queryDeviceFileListResponse.Code = context.StringValue("QueryDeviceFileList.Code");
			queryDeviceFileListResponse.ErrorMessage = context.StringValue("QueryDeviceFileList.ErrorMessage");
			queryDeviceFileListResponse.CurrentPage = context.IntegerValue("QueryDeviceFileList.CurrentPage");
			queryDeviceFileListResponse.PageCount = context.IntegerValue("QueryDeviceFileList.PageCount");
			queryDeviceFileListResponse.PageSize = context.IntegerValue("QueryDeviceFileList.PageSize");
			queryDeviceFileListResponse.Total = context.IntegerValue("QueryDeviceFileList.Total");

			List<QueryDeviceFileListResponse.QueryDeviceFileList_FileSummary> queryDeviceFileListResponse_data = new List<QueryDeviceFileListResponse.QueryDeviceFileList_FileSummary>();
			for (int i = 0; i < context.Length("QueryDeviceFileList.Data.Length"); i++) {
				QueryDeviceFileListResponse.QueryDeviceFileList_FileSummary fileSummary = new QueryDeviceFileListResponse.QueryDeviceFileList_FileSummary();
				fileSummary.FileId = context.StringValue("QueryDeviceFileList.Data["+ i +"].FileId");
				fileSummary.Name = context.StringValue("QueryDeviceFileList.Data["+ i +"].Name");
				fileSummary.Size = context.StringValue("QueryDeviceFileList.Data["+ i +"].Size");
				fileSummary.UtcCreatedOn = context.StringValue("QueryDeviceFileList.Data["+ i +"].UtcCreatedOn");

				queryDeviceFileListResponse_data.Add(fileSummary);
			}
			queryDeviceFileListResponse.Data = queryDeviceFileListResponse_data;
        
			return queryDeviceFileListResponse;
        }
    }
}
