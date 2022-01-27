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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DescribeUserMetricsResponseUnmarshaller
    {
        public static DescribeUserMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserMetricsResponse describeUserMetricsResponse = new DescribeUserMetricsResponse();

			describeUserMetricsResponse.HttpResponse = _ctx.HttpResponse;
			describeUserMetricsResponse.Code = _ctx.StringValue("DescribeUserMetrics.code");
			describeUserMetricsResponse.Message = _ctx.StringValue("DescribeUserMetrics.message");
			describeUserMetricsResponse.RequestId = _ctx.StringValue("DescribeUserMetrics.requestId");

			List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem> describeUserMetricsResponse_result = new List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeUserMetrics.Result.Length"); i++) {
				DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem resultItem = new DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem();
				resultItem.SceneId = _ctx.StringValue("DescribeUserMetrics.Result["+ i +"].sceneId");

				List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem> resultItem_dataPoints = new List<DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem>();
				for (int j = 0; j < _ctx.Length("DescribeUserMetrics.Result["+ i +"].DataPoints.Length"); j++) {
					DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem dataPointsItem = new DescribeUserMetricsResponse.DescribeUserMetrics_ResultItem.DescribeUserMetrics_DataPointsItem();
					dataPointsItem.EndTime = _ctx.LongValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].endTime");
					dataPointsItem.StartTime = _ctx.LongValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].startTime");
					dataPointsItem.Val = _ctx.FloatValue("DescribeUserMetrics.Result["+ i +"].DataPoints["+ j +"].val");

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
