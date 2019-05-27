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
    public class DescribeDataLimitsResponseUnmarshaller
    {
        public static DescribeDataLimitsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataLimitsResponse describeDataLimitsResponse = new DescribeDataLimitsResponse();

			describeDataLimitsResponse.HttpResponse = context.HttpResponse;
			describeDataLimitsResponse.RequestId = context.StringValue("DescribeDataLimits.RequestId");

			List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit> describeDataLimitsResponse_dataLimitList = new List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit>();
			for (int i = 0; i < context.Length("DescribeDataLimits.DataLimitList.Length"); i++) {
				DescribeDataLimitsResponse.DescribeDataLimits_DataLimit dataLimit = new DescribeDataLimitsResponse.DescribeDataLimits_DataLimit();
				dataLimit.RegionId = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].RegionId");
				dataLimit.LocalName = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].LocalName");
				dataLimit.ParentId = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].ParentId");
				dataLimit.Id = context.LongValue("DescribeDataLimits.DataLimitList["+ i +"].Id");
				dataLimit.UserName = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].UserName");
				dataLimit.GmtCreate = context.LongValue("DescribeDataLimits.DataLimitList["+ i +"].GmtCreate");
				dataLimit.Connector = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].Connector");
				dataLimit.CheckStatus = context.IntegerValue("DescribeDataLimits.DataLimitList["+ i +"].CheckStatus");
				dataLimit.CheckStatusName = context.StringValue("DescribeDataLimits.DataLimitList["+ i +"].CheckStatusName");

				describeDataLimitsResponse_dataLimitList.Add(dataLimit);
			}
			describeDataLimitsResponse.DataLimitList = describeDataLimitsResponse_dataLimitList;
        
			return describeDataLimitsResponse;
        }
    }
}
