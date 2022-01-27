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
    public class DescribeEventTopResponseUnmarshaller
    {
        public static DescribeEventTopResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventTopResponse describeEventTopResponse = new DescribeEventTopResponse();

			describeEventTopResponse.HttpResponse = _ctx.HttpResponse;
			describeEventTopResponse.RequestId = _ctx.StringValue("DescribeEventTop.RequestId");

			List<DescribeEventTopResponse.DescribeEventTop_DataCount> describeEventTopResponse_dataCountList = new List<DescribeEventTopResponse.DescribeEventTop_DataCount>();
			for (int i = 0; i < _ctx.Length("DescribeEventTop.DataCountList.Length"); i++) {
				DescribeEventTopResponse.DescribeEventTop_DataCount dataCount = new DescribeEventTopResponse.DescribeEventTop_DataCount();
				dataCount.EventName = _ctx.StringValue("DescribeEventTop.DataCountList["+ i +"].EventName");
				dataCount.InstanceName = _ctx.StringValue("DescribeEventTop.DataCountList["+ i +"].InstanceName");
				dataCount.ProductCode = _ctx.StringValue("DescribeEventTop.DataCountList["+ i +"].ProductCode");
				dataCount.UserName = _ctx.StringValue("DescribeEventTop.DataCountList["+ i +"].UserName");
				dataCount.RemoteIp = _ctx.StringValue("DescribeEventTop.DataCountList["+ i +"].RemoteIp");
				dataCount.Id = _ctx.LongValue("DescribeEventTop.DataCountList["+ i +"].Id");

				describeEventTopResponse_dataCountList.Add(dataCount);
			}
			describeEventTopResponse.DataCountList = describeEventTopResponse_dataCountList;
        
			return describeEventTopResponse;
        }
    }
}
