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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeEventsResponseUnmarshaller
    {
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeEventsResponse.RequestId = _ctx.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.ErrorMessage = _ctx.StringValue("DescribeEvents.ErrorMessage");
			describeEventsResponse.Success = _ctx.BooleanValue("DescribeEvents.Success");
			describeEventsResponse.ErrorCode = _ctx.StringValue("DescribeEvents.ErrorCode");
			describeEventsResponse.Code = _ctx.StringValue("DescribeEvents.Code");
			describeEventsResponse.Message = _ctx.StringValue("DescribeEvents.Message");
			describeEventsResponse.DynamicMessage = _ctx.StringValue("DescribeEvents.DynamicMessage");
			describeEventsResponse.DynamicCode = _ctx.StringValue("DescribeEvents.DynamicCode");
			describeEventsResponse.TotalCount = _ctx.IntegerValue("DescribeEvents.TotalCount");
			describeEventsResponse.PageSize = _ctx.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.PageNumber = _ctx.IntegerValue("DescribeEvents.PageNumber");

			List<DescribeEventsResponse.DescribeEvents_EventInfoVO> describeEventsResponse_items = new List<DescribeEventsResponse.DescribeEvents_EventInfoVO>();
			for (int i = 0; i < _ctx.Length("DescribeEvents.Items.Length"); i++) {
				DescribeEventsResponse.DescribeEvents_EventInfoVO eventInfoVO = new DescribeEventsResponse.DescribeEvents_EventInfoVO();
				eventInfoVO.EventId = _ctx.StringValue("DescribeEvents.Items["+ i +"].EventId");
				eventInfoVO.EventTime = _ctx.StringValue("DescribeEvents.Items["+ i +"].EventTime");
				eventInfoVO.Category = _ctx.StringValue("DescribeEvents.Items["+ i +"].Category");
				eventInfoVO.EslBarCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].EslBarCode");
				eventInfoVO.ApMac = _ctx.StringValue("DescribeEvents.Items["+ i +"].ApMac");
				eventInfoVO.StoreId = _ctx.StringValue("DescribeEvents.Items["+ i +"].StoreId");
				eventInfoVO.ItemBarCode = _ctx.StringValue("DescribeEvents.Items["+ i +"].ItemBarCode");
				eventInfoVO.ItemId = _ctx.StringValue("DescribeEvents.Items["+ i +"].ItemId");
				eventInfoVO.ItemTitle = _ctx.StringValue("DescribeEvents.Items["+ i +"].ItemTitle");
				eventInfoVO.Content = _ctx.StringValue("DescribeEvents.Items["+ i +"].Content");
				eventInfoVO.Status = _ctx.StringValue("DescribeEvents.Items["+ i +"].Status");
				eventInfoVO.Staff = _ctx.StringValue("DescribeEvents.Items["+ i +"].Staff");
				eventInfoVO.ProcessTime = _ctx.StringValue("DescribeEvents.Items["+ i +"].ProcessTime");
				eventInfoVO.Reason = _ctx.StringValue("DescribeEvents.Items["+ i +"].Reason");

				describeEventsResponse_items.Add(eventInfoVO);
			}
			describeEventsResponse.Items = describeEventsResponse_items;
        
			return describeEventsResponse;
        }
    }
}
