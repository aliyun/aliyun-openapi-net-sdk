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
    public class QueryDeviceGroupByTagsResponseUnmarshaller
    {
        public static QueryDeviceGroupByTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceGroupByTagsResponse queryDeviceGroupByTagsResponse = new QueryDeviceGroupByTagsResponse();

			queryDeviceGroupByTagsResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceGroupByTagsResponse.RequestId = _ctx.StringValue("QueryDeviceGroupByTags.RequestId");
			queryDeviceGroupByTagsResponse.Success = _ctx.BooleanValue("QueryDeviceGroupByTags.Success");
			queryDeviceGroupByTagsResponse.Code = _ctx.StringValue("QueryDeviceGroupByTags.Code");
			queryDeviceGroupByTagsResponse.ErrorMessage = _ctx.StringValue("QueryDeviceGroupByTags.ErrorMessage");
			queryDeviceGroupByTagsResponse.Page = _ctx.IntegerValue("QueryDeviceGroupByTags.Page");
			queryDeviceGroupByTagsResponse.PageSize = _ctx.IntegerValue("QueryDeviceGroupByTags.PageSize");
			queryDeviceGroupByTagsResponse.PageCount = _ctx.IntegerValue("QueryDeviceGroupByTags.PageCount");
			queryDeviceGroupByTagsResponse.Total = _ctx.IntegerValue("QueryDeviceGroupByTags.Total");

			List<QueryDeviceGroupByTagsResponse.QueryDeviceGroupByTags_DeviceGroup> queryDeviceGroupByTagsResponse_data = new List<QueryDeviceGroupByTagsResponse.QueryDeviceGroupByTags_DeviceGroup>();
			for (int i = 0; i < _ctx.Length("QueryDeviceGroupByTags.Data.Length"); i++) {
				QueryDeviceGroupByTagsResponse.QueryDeviceGroupByTags_DeviceGroup deviceGroup = new QueryDeviceGroupByTagsResponse.QueryDeviceGroupByTags_DeviceGroup();
				deviceGroup.GroupId = _ctx.StringValue("QueryDeviceGroupByTags.Data["+ i +"].GroupId");
				deviceGroup.GroupName = _ctx.StringValue("QueryDeviceGroupByTags.Data["+ i +"].GroupName");

				queryDeviceGroupByTagsResponse_data.Add(deviceGroup);
			}
			queryDeviceGroupByTagsResponse.Data = queryDeviceGroupByTagsResponse_data;
        
			return queryDeviceGroupByTagsResponse;
        }
    }
}
