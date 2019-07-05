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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssIncrementStatsResponseUnmarshaller
    {
        public static DescribeOssIncrementStatsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssIncrementStatsResponse describeOssIncrementStatsResponse = new DescribeOssIncrementStatsResponse();

			describeOssIncrementStatsResponse.HttpResponse = context.HttpResponse;
			describeOssIncrementStatsResponse.RequestId = context.StringValue("DescribeOssIncrementStats.RequestId");
			describeOssIncrementStatsResponse.TotalCount = context.IntegerValue("DescribeOssIncrementStats.TotalCount");

			List<DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat> describeOssIncrementStatsResponse_statList = new List<DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat>();
			for (int i = 0; i < context.Length("DescribeOssIncrementStats.StatList.Length"); i++) {
				DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat stat = new DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat();
				stat.ResourceType = context.StringValue("DescribeOssIncrementStats.StatList["+ i +"].ResourceType");
				stat.Scene = context.StringValue("DescribeOssIncrementStats.StatList["+ i +"].Scene");
				stat.Date = context.StringValue("DescribeOssIncrementStats.StatList["+ i +"].Date");
				stat.TotalCount = context.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].TotalCount");
				stat.PassCount = context.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].PassCount");
				stat.ReviewCount = context.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].ReviewCount");
				stat.BlockCount = context.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].BlockCount");

				describeOssIncrementStatsResponse_statList.Add(stat);
			}
			describeOssIncrementStatsResponse.StatList = describeOssIncrementStatsResponse_statList;
        
			return describeOssIncrementStatsResponse;
        }
    }
}
