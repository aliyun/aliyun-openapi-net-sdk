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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class DescribeSubscriptionObjectModifyStatusResponseUnmarshaller
    {
        public static DescribeSubscriptionObjectModifyStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubscriptionObjectModifyStatusResponse describeSubscriptionObjectModifyStatusResponse = new DescribeSubscriptionObjectModifyStatusResponse();

			describeSubscriptionObjectModifyStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeSubscriptionObjectModifyStatusResponse.ErrCode = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.ErrCode");
			describeSubscriptionObjectModifyStatusResponse.ErrMessage = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.ErrMessage");
			describeSubscriptionObjectModifyStatusResponse.Percent = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Percent");
			describeSubscriptionObjectModifyStatusResponse.RequestId = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.RequestId");
			describeSubscriptionObjectModifyStatusResponse.Status = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Status");
			describeSubscriptionObjectModifyStatusResponse.Success = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Success");

			List<DescribeSubscriptionObjectModifyStatusResponse.DescribeSubscriptionObjectModifyStatus_CheckItem> describeSubscriptionObjectModifyStatusResponse_detail = new List<DescribeSubscriptionObjectModifyStatusResponse.DescribeSubscriptionObjectModifyStatus_CheckItem>();
			for (int i = 0; i < _ctx.Length("DescribeSubscriptionObjectModifyStatus.Detail.Length"); i++) {
				DescribeSubscriptionObjectModifyStatusResponse.DescribeSubscriptionObjectModifyStatus_CheckItem checkItem = new DescribeSubscriptionObjectModifyStatusResponse.DescribeSubscriptionObjectModifyStatus_CheckItem();
				checkItem.CheckStatus = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Detail["+ i +"].CheckStatus");
				checkItem.ErrorMessage = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Detail["+ i +"].ErrorMessage");
				checkItem.ItemName = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Detail["+ i +"].ItemName");
				checkItem.RepairMethod = _ctx.StringValue("DescribeSubscriptionObjectModifyStatus.Detail["+ i +"].RepairMethod");

				describeSubscriptionObjectModifyStatusResponse_detail.Add(checkItem);
			}
			describeSubscriptionObjectModifyStatusResponse.Detail = describeSubscriptionObjectModifyStatusResponse_detail;
        
			return describeSubscriptionObjectModifyStatusResponse;
        }
    }
}
