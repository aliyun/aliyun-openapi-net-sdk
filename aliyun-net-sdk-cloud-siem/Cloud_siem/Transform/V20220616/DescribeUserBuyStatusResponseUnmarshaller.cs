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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeUserBuyStatusResponseUnmarshaller
    {
        public static DescribeUserBuyStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserBuyStatusResponse describeUserBuyStatusResponse = new DescribeUserBuyStatusResponse();

			describeUserBuyStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeUserBuyStatusResponse.RequestId = _ctx.StringValue("DescribeUserBuyStatus.RequestId");

			DescribeUserBuyStatusResponse.DescribeUserBuyStatus_Data data = new DescribeUserBuyStatusResponse.DescribeUserBuyStatus_Data();
			data.MasterUserId = _ctx.LongValue("DescribeUserBuyStatus.Data.MasterUserId");
			data.MasterUserName = _ctx.StringValue("DescribeUserBuyStatus.Data.MasterUserName");
			data.MainUserId = _ctx.LongValue("DescribeUserBuyStatus.Data.MainUserId");
			data.MainUserName = _ctx.StringValue("DescribeUserBuyStatus.Data.MainUserName");
			data.SubUserId = _ctx.LongValue("DescribeUserBuyStatus.Data.SubUserId");
			data.SubUserName = _ctx.StringValue("DescribeUserBuyStatus.Data.SubUserName");
			data.Capacity = _ctx.IntegerValue("DescribeUserBuyStatus.Data.Capacity");
			data.SasInstanceId = _ctx.StringValue("DescribeUserBuyStatus.Data.SasInstanceId");
			data.CanBuy = _ctx.BooleanValue("DescribeUserBuyStatus.Data.CanBuy");
			data.EndTime = _ctx.LongValue("DescribeUserBuyStatus.Data.EndTime");
			data.DurationDays = _ctx.LongValue("DescribeUserBuyStatus.Data.DurationDays");
			data.RdOrder = _ctx.IntegerValue("DescribeUserBuyStatus.Data.RdOrder");
			describeUserBuyStatusResponse.Data = data;
        
			return describeUserBuyStatusResponse;
        }
    }
}
