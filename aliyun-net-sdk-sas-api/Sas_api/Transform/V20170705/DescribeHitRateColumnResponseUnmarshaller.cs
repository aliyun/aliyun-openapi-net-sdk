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
using Aliyun.Acs.Sas_api.Model.V20170705;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class DescribeHitRateColumnResponseUnmarshaller
    {
        public static DescribeHitRateColumnResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHitRateColumnResponse describeHitRateColumnResponse = new DescribeHitRateColumnResponse();

			describeHitRateColumnResponse.HttpResponse = context.HttpResponse;
			describeHitRateColumnResponse.RequestId = context.StringValue("DescribeHitRateColumn.RequestId");

			DescribeHitRateColumnResponse.DescribeHitRateColumn_TimeScope timeScope = new DescribeHitRateColumnResponse.DescribeHitRateColumn_TimeScope();
			timeScope.Interval = context.LongValue("DescribeHitRateColumn.TimeScope.Interval");
			timeScope.Start = context.LongValue("DescribeHitRateColumn.TimeScope.Start");
			describeHitRateColumnResponse.TimeScope = timeScope;

			List<DescribeHitRateColumnResponse.DescribeHitRateColumn_Item> describeHitRateColumnResponse_items = new List<DescribeHitRateColumnResponse.DescribeHitRateColumn_Item>();
			for (int i = 0; i < context.Length("DescribeHitRateColumn.Items.Length"); i++) {
				DescribeHitRateColumnResponse.DescribeHitRateColumn_Item item = new DescribeHitRateColumnResponse.DescribeHitRateColumn_Item();
				item.Data = context.LongValue("DescribeHitRateColumn.Items["+ i +"].Data");
				item.Id = context.StringValue("DescribeHitRateColumn.Items["+ i +"].Id");
				item.Name = context.StringValue("DescribeHitRateColumn.Items["+ i +"].Name");

				describeHitRateColumnResponse_items.Add(item);
			}
			describeHitRateColumnResponse.Items = describeHitRateColumnResponse_items;
        
			return describeHitRateColumnResponse;
        }
    }
}
