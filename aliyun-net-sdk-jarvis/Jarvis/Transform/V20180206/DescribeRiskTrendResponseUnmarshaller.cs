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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeRiskTrendResponseUnmarshaller
    {
        public static DescribeRiskTrendResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiskTrendResponse describeRiskTrendResponse = new DescribeRiskTrendResponse();

			describeRiskTrendResponse.HttpResponse = context.HttpResponse;
			describeRiskTrendResponse.RequestId = context.StringValue("DescribeRiskTrend.RequestId");
			describeRiskTrendResponse.TotalCount = context.StringValue("DescribeRiskTrend.TotalCount");
			describeRiskTrendResponse.Module = context.StringValue("DescribeRiskTrend.Module");

			List<DescribeRiskTrendResponse.DescribeRiskTrend_DataItem> describeRiskTrendResponse_dataList = new List<DescribeRiskTrendResponse.DescribeRiskTrend_DataItem>();
			for (int i = 0; i < context.Length("DescribeRiskTrend.DataList.Length"); i++) {
				DescribeRiskTrendResponse.DescribeRiskTrend_DataItem dataItem = new DescribeRiskTrendResponse.DescribeRiskTrend_DataItem();
				dataItem.UpdateTime = context.StringValue("DescribeRiskTrend.DataList["+ i +"].UpdateTime");
				dataItem.NewRiskCount = context.IntegerValue("DescribeRiskTrend.DataList["+ i +"].NewRiskCount");
				dataItem.TotalRiskCount = context.IntegerValue("DescribeRiskTrend.DataList["+ i +"].TotalRiskCount");

				describeRiskTrendResponse_dataList.Add(dataItem);
			}
			describeRiskTrendResponse.DataList = describeRiskTrendResponse_dataList;
        
			return describeRiskTrendResponse;
        }
    }
}
