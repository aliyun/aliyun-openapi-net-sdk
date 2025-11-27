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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeProcessTaskCountResponseUnmarshaller
    {
        public static DescribeProcessTaskCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProcessTaskCountResponse describeProcessTaskCountResponse = new DescribeProcessTaskCountResponse();

			describeProcessTaskCountResponse.HttpResponse = _ctx.HttpResponse;
			describeProcessTaskCountResponse.RequestId = _ctx.StringValue("DescribeProcessTaskCount.RequestId");

			List<DescribeProcessTaskCountResponse.DescribeProcessTaskCount_DataItem> describeProcessTaskCountResponse_data = new List<DescribeProcessTaskCountResponse.DescribeProcessTaskCount_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeProcessTaskCount.Data.Length"); i++) {
				DescribeProcessTaskCountResponse.DescribeProcessTaskCount_DataItem dataItem = new DescribeProcessTaskCountResponse.DescribeProcessTaskCount_DataItem();
				dataItem.EntityUuid = _ctx.StringValue("DescribeProcessTaskCount.Data["+ i +"].EntityUuid");
				dataItem.Count = _ctx.LongValue("DescribeProcessTaskCount.Data["+ i +"].Count");

				describeProcessTaskCountResponse_data.Add(dataItem);
			}
			describeProcessTaskCountResponse.Data = describeProcessTaskCountResponse_data;
        
			return describeProcessTaskCountResponse;
        }
    }
}
