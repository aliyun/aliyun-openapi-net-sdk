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
    public class QueryDeviceByTagsResponseUnmarshaller
    {
        public static QueryDeviceByTagsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceByTagsResponse queryDeviceByTagsResponse = new QueryDeviceByTagsResponse();

			queryDeviceByTagsResponse.HttpResponse = context.HttpResponse;
			queryDeviceByTagsResponse.RequestId = context.StringValue("QueryDeviceByTags.RequestId");
			queryDeviceByTagsResponse.Success = context.BooleanValue("QueryDeviceByTags.Success");
			queryDeviceByTagsResponse.Code = context.StringValue("QueryDeviceByTags.Code");
			queryDeviceByTagsResponse.ErrorMessage = context.StringValue("QueryDeviceByTags.ErrorMessage");
			queryDeviceByTagsResponse.Page = context.IntegerValue("QueryDeviceByTags.Page");
			queryDeviceByTagsResponse.PageSize = context.IntegerValue("QueryDeviceByTags.PageSize");
			queryDeviceByTagsResponse.PageCount = context.IntegerValue("QueryDeviceByTags.PageCount");
			queryDeviceByTagsResponse.Total = context.IntegerValue("QueryDeviceByTags.Total");

			List<QueryDeviceByTagsResponse.QueryDeviceByTags_SimpleDeviceInfo> queryDeviceByTagsResponse_data = new List<QueryDeviceByTagsResponse.QueryDeviceByTags_SimpleDeviceInfo>();
			for (int i = 0; i < context.Length("QueryDeviceByTags.Data.Length"); i++) {
				QueryDeviceByTagsResponse.QueryDeviceByTags_SimpleDeviceInfo simpleDeviceInfo = new QueryDeviceByTagsResponse.QueryDeviceByTags_SimpleDeviceInfo();
				simpleDeviceInfo.ProductName = context.StringValue("QueryDeviceByTags.Data["+ i +"].ProductName");
				simpleDeviceInfo.ProductKey = context.StringValue("QueryDeviceByTags.Data["+ i +"].ProductKey");
				simpleDeviceInfo.DeviceName = context.StringValue("QueryDeviceByTags.Data["+ i +"].DeviceName");
				simpleDeviceInfo.IotId = context.StringValue("QueryDeviceByTags.Data["+ i +"].IotId");

				queryDeviceByTagsResponse_data.Add(simpleDeviceInfo);
			}
			queryDeviceByTagsResponse.Data = queryDeviceByTagsResponse_data;
        
			return queryDeviceByTagsResponse;
        }
    }
}
