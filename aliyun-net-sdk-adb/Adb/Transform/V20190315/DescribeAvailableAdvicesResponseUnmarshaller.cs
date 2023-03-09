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
    public class DescribeAvailableAdvicesResponseUnmarshaller
    {
        public static DescribeAvailableAdvicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableAdvicesResponse describeAvailableAdvicesResponse = new DescribeAvailableAdvicesResponse();

			describeAvailableAdvicesResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableAdvicesResponse.PageNumber = _ctx.LongValue("DescribeAvailableAdvices.PageNumber");
			describeAvailableAdvicesResponse.PageSize = _ctx.LongValue("DescribeAvailableAdvices.PageSize");
			describeAvailableAdvicesResponse.RequestId = _ctx.StringValue("DescribeAvailableAdvices.RequestId");
			describeAvailableAdvicesResponse.TotalCount = _ctx.LongValue("DescribeAvailableAdvices.TotalCount");

			List<DescribeAvailableAdvicesResponse.DescribeAvailableAdvices_ItemsItem> describeAvailableAdvicesResponse_items = new List<DescribeAvailableAdvicesResponse.DescribeAvailableAdvices_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableAdvices.Items.Length"); i++) {
				DescribeAvailableAdvicesResponse.DescribeAvailableAdvices_ItemsItem itemsItem = new DescribeAvailableAdvicesResponse.DescribeAvailableAdvices_ItemsItem();
				itemsItem.AdviceId = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].AdviceId");
				itemsItem.AdviceDate = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].AdviceDate");
				itemsItem.AdviceType = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].AdviceType");
				itemsItem.SQL = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].SQL");
				itemsItem.Reason = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].Reason");
				itemsItem.Benefit = _ctx.StringValue("DescribeAvailableAdvices.Items["+ i +"].Benefit");
				itemsItem.TotalCount = _ctx.LongValue("DescribeAvailableAdvices.Items["+ i +"].TotalCount");
				itemsItem.PageSize = _ctx.LongValue("DescribeAvailableAdvices.Items["+ i +"].PageSize");
				itemsItem.PageNumber = _ctx.LongValue("DescribeAvailableAdvices.Items["+ i +"].PageNumber");

				describeAvailableAdvicesResponse_items.Add(itemsItem);
			}
			describeAvailableAdvicesResponse.Items = describeAvailableAdvicesResponse_items;
        
			return describeAvailableAdvicesResponse;
        }
    }
}
