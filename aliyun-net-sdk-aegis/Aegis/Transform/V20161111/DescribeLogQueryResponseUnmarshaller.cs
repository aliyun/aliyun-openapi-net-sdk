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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeLogQueryResponseUnmarshaller
    {
        public static DescribeLogQueryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogQueryResponse describeLogQueryResponse = new DescribeLogQueryResponse();

			describeLogQueryResponse.HttpResponse = context.HttpResponse;
			describeLogQueryResponse.RequestId = context.StringValue("DescribeLogQuery.RequestId");
			describeLogQueryResponse.ListTotal = context.IntegerValue("DescribeLogQuery.ListTotal");

			List<DescribeLogQueryResponse.DescribeLogQuery_QueryItemsItem> describeLogQueryResponse_queryItems = new List<DescribeLogQueryResponse.DescribeLogQuery_QueryItemsItem>();
			for (int i = 0; i < context.Length("DescribeLogQuery.QueryItems.Length"); i++) {
				DescribeLogQueryResponse.DescribeLogQuery_QueryItemsItem queryItemsItem = new DescribeLogQueryResponse.DescribeLogQuery_QueryItemsItem();
				queryItemsItem.QueryDetail = context.StringValue("DescribeLogQuery.QueryItems["+ i +"].QueryDetail");
				queryItemsItem.QueryName = context.StringValue("DescribeLogQuery.QueryItems["+ i +"].QueryName");
				queryItemsItem.Conditions = context.StringValue("DescribeLogQuery.QueryItems["+ i +"].Conditions");

				describeLogQueryResponse_queryItems.Add(queryItemsItem);
			}
			describeLogQueryResponse.QueryItems = describeLogQueryResponse_queryItems;
        
			return describeLogQueryResponse;
        }
    }
}
