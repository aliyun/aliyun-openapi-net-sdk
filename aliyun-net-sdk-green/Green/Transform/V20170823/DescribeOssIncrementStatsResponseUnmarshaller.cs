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
        public static DescribeOssIncrementStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssIncrementStatsResponse describeOssIncrementStatsResponse = new DescribeOssIncrementStatsResponse();

			describeOssIncrementStatsResponse.HttpResponse = _ctx.HttpResponse;
			describeOssIncrementStatsResponse.RequestId = _ctx.StringValue("DescribeOssIncrementStats.RequestId");
			describeOssIncrementStatsResponse.TotalCount = _ctx.IntegerValue("DescribeOssIncrementStats.TotalCount");

			List<DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat> describeOssIncrementStatsResponse_statList = new List<DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementStats.StatList.Length"); i++) {
				DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat stat = new DescribeOssIncrementStatsResponse.DescribeOssIncrementStats_Stat();
				stat.ResourceType = _ctx.StringValue("DescribeOssIncrementStats.StatList["+ i +"].ResourceType");
				stat.Scene = _ctx.StringValue("DescribeOssIncrementStats.StatList["+ i +"].Scene");
				stat.Date = _ctx.StringValue("DescribeOssIncrementStats.StatList["+ i +"].Date");
				stat.TotalCount = _ctx.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].TotalCount");
				stat.PassCount = _ctx.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].PassCount");
				stat.ReviewCount = _ctx.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].ReviewCount");
				stat.BlockCount = _ctx.IntegerValue("DescribeOssIncrementStats.StatList["+ i +"].BlockCount");

				describeOssIncrementStatsResponse_statList.Add(stat);
			}
			describeOssIncrementStatsResponse.StatList = describeOssIncrementStatsResponse_statList;
        
			return describeOssIncrementStatsResponse;
        }
    }
}
