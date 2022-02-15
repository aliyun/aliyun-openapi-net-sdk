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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetCopyrightHistoryListResponseUnmarshaller
    {
        public static GetCopyrightHistoryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCopyrightHistoryListResponse getCopyrightHistoryListResponse = new GetCopyrightHistoryListResponse();

			getCopyrightHistoryListResponse.HttpResponse = _ctx.HttpResponse;
			getCopyrightHistoryListResponse.RequestId = _ctx.StringValue("GetCopyrightHistoryList.RequestId");
			getCopyrightHistoryListResponse.Success = _ctx.BooleanValue("GetCopyrightHistoryList.Success");

			List<GetCopyrightHistoryListResponse.GetCopyrightHistoryList_DataItem> getCopyrightHistoryListResponse_data = new List<GetCopyrightHistoryListResponse.GetCopyrightHistoryList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetCopyrightHistoryList.Data.Length"); i++) {
				GetCopyrightHistoryListResponse.GetCopyrightHistoryList_DataItem dataItem = new GetCopyrightHistoryListResponse.GetCopyrightHistoryList_DataItem();
				dataItem.UserStatus = _ctx.StringValue("GetCopyrightHistoryList.Data["+ i +"].UserStatus");
				dataItem.CreateTime = _ctx.StringValue("GetCopyrightHistoryList.Data["+ i +"].CreateTime");
				dataItem.FileId = _ctx.StringValue("GetCopyrightHistoryList.Data["+ i +"].FileId");

				getCopyrightHistoryListResponse_data.Add(dataItem);
			}
			getCopyrightHistoryListResponse.Data = getCopyrightHistoryListResponse_data;
        
			return getCopyrightHistoryListResponse;
        }
    }
}
