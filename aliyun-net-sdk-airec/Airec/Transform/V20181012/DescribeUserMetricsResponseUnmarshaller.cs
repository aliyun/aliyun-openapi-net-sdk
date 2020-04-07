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
using Aliyun.Acs.Airec.Model.V20181012;

namespace Aliyun.Acs.Airec.Transform.V20181012
{
    public class DescribeUserMetricsResponseUnmarshaller
    {
        public static DescribeUserMetricsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserMetricsResponse describeUserMetricsResponse = new DescribeUserMetricsResponse();

			describeUserMetricsResponse.HttpResponse = context.HttpResponse;
			describeUserMetricsResponse.RequestId = context.StringValue("DescribeUserMetrics.RequestId");
			describeUserMetricsResponse.Code = context.StringValue("DescribeUserMetrics.Code");
			describeUserMetricsResponse.Message = context.StringValue("DescribeUserMetrics.Message");

			List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem> describeUserMetricsResponse_result = new List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem>();
			for (int i = 0; i < context.Length("DescribeUserMetrics.Result.Length"); i++) {
				DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem resultItem = new DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem();
				resultItem.SceneId = context.StringValue("DescribeUserMetrics.Result["+ i +"].SceneId");

				List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem> resultItem_dataPoints = new List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem>();
				for (int j = 0; j < context.Length("DescribeUserMetrics.Result["+ i +"].DataPoints.Length"); j++) {
					DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem dataPointsItem = new DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem();
					dataPointsItem.Val = context.FloatValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].Val");
					dataPointsItem.StartTime = context.LongValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].StartTime");
					dataPointsItem.EndTime = context.LongValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].EndTime");

					resultItem_dataPoints.Add(dataPointsItem);
				}
				resultItem.DataPoints = resultItem_dataPoints;

				describeUserMetricsResponse_result.Add(resultItem);
			}
			describeUserMetricsResponse.Result = describeUserMetricsResponse_result;
        
			return describeUserMetricsResponse;
        }
    }
}
