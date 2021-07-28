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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeEventMonitorListResponseUnmarshaller
    {
        public static DescribeEventMonitorListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventMonitorListResponse describeEventMonitorListResponse = new DescribeEventMonitorListResponse();

			describeEventMonitorListResponse.HttpResponse = _ctx.HttpResponse;
			describeEventMonitorListResponse.Code = _ctx.IntegerValue("DescribeEventMonitorList.Code");
			describeEventMonitorListResponse.ErrorMsg = _ctx.StringValue("DescribeEventMonitorList.ErrorMsg");
			describeEventMonitorListResponse.PageNumber = _ctx.IntegerValue("DescribeEventMonitorList.PageNumber");
			describeEventMonitorListResponse.PageSize = _ctx.IntegerValue("DescribeEventMonitorList.PageSize");
			describeEventMonitorListResponse.RequestId = _ctx.StringValue("DescribeEventMonitorList.RequestId");
			describeEventMonitorListResponse.TotalCount = _ctx.LongValue("DescribeEventMonitorList.TotalCount");

			List<DescribeEventMonitorListResponse.DescribeEventMonitorList_EventInfo> describeEventMonitorListResponse_data = new List<DescribeEventMonitorListResponse.DescribeEventMonitorList_EventInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEventMonitorList.Data.Length"); i++) {
				DescribeEventMonitorListResponse.DescribeEventMonitorList_EventInfo eventInfo = new DescribeEventMonitorListResponse.DescribeEventMonitorList_EventInfo();
				eventInfo.Count = _ctx.IntegerValue("DescribeEventMonitorList.Data["+ i +"].Count");
				eventInfo.EventTime = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].EventTime");
				eventInfo.HostName = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].HostName");
				eventInfo.Kind = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].Kind");
				eventInfo.Level = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].Level");
				eventInfo.Message = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].Message");
				eventInfo._NameSpace = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].NameSpace");
				eventInfo.PodName = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].PodName");
				eventInfo.Reason = _ctx.StringValue("DescribeEventMonitorList.Data["+ i +"].Reason");

				describeEventMonitorListResponse_data.Add(eventInfo);
			}
			describeEventMonitorListResponse.Data = describeEventMonitorListResponse_data;
        
			return describeEventMonitorListResponse;
        }
    }
}
