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
    public class QueryDeviceGroupTagListResponseUnmarshaller
    {
        public static QueryDeviceGroupTagListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceGroupTagListResponse queryDeviceGroupTagListResponse = new QueryDeviceGroupTagListResponse();

			queryDeviceGroupTagListResponse.HttpResponse = context.HttpResponse;
			queryDeviceGroupTagListResponse.RequestId = context.StringValue("QueryDeviceGroupTagList.RequestId");
			queryDeviceGroupTagListResponse.Success = context.BooleanValue("QueryDeviceGroupTagList.Success");
			queryDeviceGroupTagListResponse.Code = context.StringValue("QueryDeviceGroupTagList.Code");
			queryDeviceGroupTagListResponse.ErrorMessage = context.StringValue("QueryDeviceGroupTagList.ErrorMessage");

			List<QueryDeviceGroupTagListResponse.QueryDeviceGroupTagList_GroupTagInfo> queryDeviceGroupTagListResponse_data = new List<QueryDeviceGroupTagListResponse.QueryDeviceGroupTagList_GroupTagInfo>();
			for (int i = 0; i < context.Length("QueryDeviceGroupTagList.Data.Length"); i++) {
				QueryDeviceGroupTagListResponse.QueryDeviceGroupTagList_GroupTagInfo groupTagInfo = new QueryDeviceGroupTagListResponse.QueryDeviceGroupTagList_GroupTagInfo();
				groupTagInfo.TagKey = context.StringValue("QueryDeviceGroupTagList.Data["+ i +"].TagKey");
				groupTagInfo.TagValue = context.StringValue("QueryDeviceGroupTagList.Data["+ i +"].TagValue");

				queryDeviceGroupTagListResponse_data.Add(groupTagInfo);
			}
			queryDeviceGroupTagListResponse.Data = queryDeviceGroupTagListResponse_data;
        
			return queryDeviceGroupTagListResponse;
        }
    }
}
