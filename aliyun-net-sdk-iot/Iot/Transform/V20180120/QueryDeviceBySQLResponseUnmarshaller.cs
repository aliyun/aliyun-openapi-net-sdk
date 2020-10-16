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
    public class QueryDeviceBySQLResponseUnmarshaller
    {
        public static QueryDeviceBySQLResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceBySQLResponse queryDeviceBySQLResponse = new QueryDeviceBySQLResponse();

			queryDeviceBySQLResponse.HttpResponse = context.HttpResponse;
			queryDeviceBySQLResponse.RequestId = context.StringValue("QueryDeviceBySQL.RequestId");
			queryDeviceBySQLResponse.Success = context.BooleanValue("QueryDeviceBySQL.Success");
			queryDeviceBySQLResponse.Code = context.StringValue("QueryDeviceBySQL.Code");
			queryDeviceBySQLResponse.ErrorMessage = context.StringValue("QueryDeviceBySQL.ErrorMessage");
			queryDeviceBySQLResponse.TotalCount = context.LongValue("QueryDeviceBySQL.TotalCount");

			List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo> queryDeviceBySQLResponse_data = new List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo>();
			for (int i = 0; i < context.Length("QueryDeviceBySQL.Data.Length"); i++) {
				QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo simpleDeviceSearchInfo = new QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo();
				simpleDeviceSearchInfo.ProductKey = context.StringValue("QueryDeviceBySQL.Data["+ i +"].ProductKey");
				simpleDeviceSearchInfo.DeviceName = context.StringValue("QueryDeviceBySQL.Data["+ i +"].DeviceName");
				simpleDeviceSearchInfo.Nickname = context.StringValue("QueryDeviceBySQL.Data["+ i +"].Nickname");
				simpleDeviceSearchInfo.Status = context.StringValue("QueryDeviceBySQL.Data["+ i +"].Status");
				simpleDeviceSearchInfo.ActiveTime = context.StringValue("QueryDeviceBySQL.Data["+ i +"].ActiveTime");
				simpleDeviceSearchInfo.IotId = context.StringValue("QueryDeviceBySQL.Data["+ i +"].IotId");
				simpleDeviceSearchInfo.GmtCreate = context.StringValue("QueryDeviceBySQL.Data["+ i +"].GmtCreate");
				simpleDeviceSearchInfo.GmtModified = context.StringValue("QueryDeviceBySQL.Data["+ i +"].GmtModified");

				List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_SimpleDeviceGroupInfo> simpleDeviceSearchInfo_groups = new List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_SimpleDeviceGroupInfo>();
				for (int j = 0; j < context.Length("QueryDeviceBySQL.Data["+ i +"].Groups.Length"); j++) {
					QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_SimpleDeviceGroupInfo simpleDeviceGroupInfo = new QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_SimpleDeviceGroupInfo();
					simpleDeviceGroupInfo.GroupId = context.StringValue("QueryDeviceBySQL.Data["+ i +"].Groups["+ j +"].GroupId");

					simpleDeviceSearchInfo_groups.Add(simpleDeviceGroupInfo);
				}
				simpleDeviceSearchInfo.Groups = simpleDeviceSearchInfo_groups;

				List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_TagInfo> simpleDeviceSearchInfo_tags = new List<QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_TagInfo>();
				for (int j = 0; j < context.Length("QueryDeviceBySQL.Data["+ i +"].Tags.Length"); j++) {
					QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_TagInfo tagInfo = new QueryDeviceBySQLResponse.QueryDeviceBySQL_SimpleDeviceSearchInfo.QueryDeviceBySQL_TagInfo();
					tagInfo.TagName = context.StringValue("QueryDeviceBySQL.Data["+ i +"].Tags["+ j +"].TagName");
					tagInfo.TagValue = context.StringValue("QueryDeviceBySQL.Data["+ i +"].Tags["+ j +"].TagValue");

					simpleDeviceSearchInfo_tags.Add(tagInfo);
				}
				simpleDeviceSearchInfo.Tags = simpleDeviceSearchInfo_tags;

				queryDeviceBySQLResponse_data.Add(simpleDeviceSearchInfo);
			}
			queryDeviceBySQLResponse.Data = queryDeviceBySQLResponse_data;
        
			return queryDeviceBySQLResponse;
        }
    }
}
