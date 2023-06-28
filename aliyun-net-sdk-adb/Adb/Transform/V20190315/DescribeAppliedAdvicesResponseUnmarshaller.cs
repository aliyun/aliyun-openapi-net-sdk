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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeAppliedAdvicesResponseUnmarshaller
    {
        public static DescribeAppliedAdvicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppliedAdvicesResponse describeAppliedAdvicesResponse = new DescribeAppliedAdvicesResponse();

			describeAppliedAdvicesResponse.HttpResponse = _ctx.HttpResponse;
			describeAppliedAdvicesResponse.PageNumber = _ctx.LongValue("DescribeAppliedAdvices.PageNumber");
			describeAppliedAdvicesResponse.PageSize = _ctx.LongValue("DescribeAppliedAdvices.PageSize");
			describeAppliedAdvicesResponse.RequestId = _ctx.StringValue("DescribeAppliedAdvices.RequestId");
			describeAppliedAdvicesResponse.TotalCount = _ctx.LongValue("DescribeAppliedAdvices.TotalCount");

			List<DescribeAppliedAdvicesResponse.DescribeAppliedAdvices_ItemsItem> describeAppliedAdvicesResponse_items = new List<DescribeAppliedAdvicesResponse.DescribeAppliedAdvices_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeAppliedAdvices.Items.Length"); i++) {
				DescribeAppliedAdvicesResponse.DescribeAppliedAdvices_ItemsItem itemsItem = new DescribeAppliedAdvicesResponse.DescribeAppliedAdvices_ItemsItem();
				itemsItem.AdviceId = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].AdviceId");
				itemsItem.SubmitTime = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].SubmitTime");
				itemsItem.SubmitStatus = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].SubmitStatus");
				itemsItem.SQL = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].SQL");
				itemsItem.RollbackSQL = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].RollbackSQL");
				itemsItem.JobStatus = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].JobStatus");
				itemsItem.Benefit = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].Benefit");
				itemsItem.BuildSQL = _ctx.StringValue("DescribeAppliedAdvices.Items["+ i +"].BuildSQL");
				itemsItem.TotalCount = _ctx.LongValue("DescribeAppliedAdvices.Items["+ i +"].TotalCount");
				itemsItem.PageSize = _ctx.LongValue("DescribeAppliedAdvices.Items["+ i +"].PageSize");
				itemsItem.PageNumber = _ctx.LongValue("DescribeAppliedAdvices.Items["+ i +"].PageNumber");

				describeAppliedAdvicesResponse_items.Add(itemsItem);
			}
			describeAppliedAdvicesResponse.Items = describeAppliedAdvicesResponse_items;
        
			return describeAppliedAdvicesResponse;
        }
    }
}
