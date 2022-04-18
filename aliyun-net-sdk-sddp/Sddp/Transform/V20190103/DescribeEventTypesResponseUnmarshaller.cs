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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeEventTypesResponseUnmarshaller
    {
        public static DescribeEventTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventTypesResponse describeEventTypesResponse = new DescribeEventTypesResponse();

			describeEventTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeEventTypesResponse.RequestId = _ctx.StringValue("DescribeEventTypes.RequestId");

			List<DescribeEventTypesResponse.DescribeEventTypes_EventType> describeEventTypesResponse_eventTypeList = new List<DescribeEventTypesResponse.DescribeEventTypes_EventType>();
			for (int i = 0; i < _ctx.Length("DescribeEventTypes.EventTypeList.Length"); i++) {
				DescribeEventTypesResponse.DescribeEventTypes_EventType eventType = new DescribeEventTypesResponse.DescribeEventTypes_EventType();
				eventType.Code = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].Code");
				eventType.Description = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].Description");
				eventType.Name = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].Name");
				eventType.Id = _ctx.LongValue("DescribeEventTypes.EventTypeList["+ i +"].Id");

				List<DescribeEventTypesResponse.DescribeEventTypes_EventType.DescribeEventTypes_SubType> eventType_subTypeList = new List<DescribeEventTypesResponse.DescribeEventTypes_EventType.DescribeEventTypes_SubType>();
				for (int j = 0; j < _ctx.Length("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList.Length"); j++) {
					DescribeEventTypesResponse.DescribeEventTypes_EventType.DescribeEventTypes_SubType subType = new DescribeEventTypesResponse.DescribeEventTypes_EventType.DescribeEventTypes_SubType();
					subType.Status = _ctx.IntegerValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].Status");
					subType.Description = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].Description");
					subType.ConfigContentType = _ctx.IntegerValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].ConfigContentType");
					subType.EventHitCount = _ctx.IntegerValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].EventHitCount");
					subType.ConfigValue = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].ConfigValue");
					subType.ConfigCode = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].ConfigCode");
					subType.Code = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].Code");
					subType.ConfigDescription = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].ConfigDescription");
					subType.Name = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].Name");
					subType.AdaptedProduct = _ctx.StringValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].AdaptedProduct");
					subType.Id = _ctx.LongValue("DescribeEventTypes.EventTypeList["+ i +"].SubTypeList["+ j +"].Id");

					eventType_subTypeList.Add(subType);
				}
				eventType.SubTypeList = eventType_subTypeList;

				describeEventTypesResponse_eventTypeList.Add(eventType);
			}
			describeEventTypesResponse.EventTypeList = describeEventTypesResponse_eventTypeList;
        
			return describeEventTypesResponse;
        }
    }
}
