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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribePropertyUsageNewestResponseUnmarshaller
    {
        public static DescribePropertyUsageNewestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyUsageNewestResponse describePropertyUsageNewestResponse = new DescribePropertyUsageNewestResponse();

			describePropertyUsageNewestResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyUsageNewestResponse.RequestId = _ctx.StringValue("DescribePropertyUsageNewest.RequestId");
			describePropertyUsageNewestResponse.ItemCount = _ctx.IntegerValue("DescribePropertyUsageNewest.ItemCount");
			describePropertyUsageNewestResponse.Type = _ctx.StringValue("DescribePropertyUsageNewest.Type");

			List<DescribePropertyUsageNewestResponse.DescribePropertyUsageNewest_NewestStatisticItem> describePropertyUsageNewestResponse_newestStatisticItems = new List<DescribePropertyUsageNewestResponse.DescribePropertyUsageNewest_NewestStatisticItem>();
			for (int i = 0; i < _ctx.Length("DescribePropertyUsageNewest.NewestStatisticItems.Length"); i++) {
				DescribePropertyUsageNewestResponse.DescribePropertyUsageNewest_NewestStatisticItem newestStatisticItem = new DescribePropertyUsageNewestResponse.DescribePropertyUsageNewest_NewestStatisticItem();
				newestStatisticItem.Name = _ctx.StringValue("DescribePropertyUsageNewest.NewestStatisticItems["+ i +"].Name");
				newestStatisticItem.Create = _ctx.LongValue("DescribePropertyUsageNewest.NewestStatisticItems["+ i +"].Create");

				describePropertyUsageNewestResponse_newestStatisticItems.Add(newestStatisticItem);
			}
			describePropertyUsageNewestResponse.NewestStatisticItems = describePropertyUsageNewestResponse_newestStatisticItems;
        
			return describePropertyUsageNewestResponse;
        }
    }
}
