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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEventDetailResponseUnmarshaller
    {
        public static DescribeEventDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventDetailResponse describeEventDetailResponse = new DescribeEventDetailResponse();

			describeEventDetailResponse.HttpResponse = context.HttpResponse;
			describeEventDetailResponse.RequestId = context.StringValue("DescribeEventDetail.RequestId");
			describeEventDetailResponse.ResourceId = context.StringValue("DescribeEventDetail.ResourceId");
			describeEventDetailResponse.EventType = context.StringValue("DescribeEventDetail.EventType");
			describeEventDetailResponse.EventCategory = context.StringValue("DescribeEventDetail.EventCategory");
			describeEventDetailResponse.Status = context.StringValue("DescribeEventDetail.Status");
			describeEventDetailResponse.SupportModify = context.StringValue("DescribeEventDetail.SupportModify");
			describeEventDetailResponse.PlanTime = context.StringValue("DescribeEventDetail.PlanTime");
			describeEventDetailResponse.ExpireTime = context.StringValue("DescribeEventDetail.ExpireTime");
			describeEventDetailResponse.EventId = context.StringValue("DescribeEventDetail.EventId");
			describeEventDetailResponse.StartTime = context.StringValue("DescribeEventDetail.StartTime");
			describeEventDetailResponse.EndTime = context.StringValue("DescribeEventDetail.EndTime");
			describeEventDetailResponse.EffectTime = context.StringValue("DescribeEventDetail.EffectTime");
			describeEventDetailResponse.LimitTime = context.StringValue("DescribeEventDetail.LimitTime");
			describeEventDetailResponse.Mark = context.StringValue("DescribeEventDetail.Mark");
        
			return describeEventDetailResponse;
        }
    }
}