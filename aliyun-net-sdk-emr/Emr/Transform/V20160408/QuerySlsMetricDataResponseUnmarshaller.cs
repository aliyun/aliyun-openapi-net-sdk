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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class QuerySlsMetricDataResponseUnmarshaller
    {
        public static QuerySlsMetricDataResponse Unmarshall(UnmarshallerContext context)
        {
			QuerySlsMetricDataResponse querySlsMetricDataResponse = new QuerySlsMetricDataResponse();

			querySlsMetricDataResponse.HttpResponse = context.HttpResponse;
			querySlsMetricDataResponse.RequestId = context.StringValue("QuerySlsMetricData.RequestId");

			List<QuerySlsMetricDataResponse.QuerySlsMetricData_SlsDataPoint> querySlsMetricDataResponse_datapoints = new List<QuerySlsMetricDataResponse.QuerySlsMetricData_SlsDataPoint>();
			for (int i = 0; i < context.Length("QuerySlsMetricData.Datapoints.Length"); i++) {
				QuerySlsMetricDataResponse.QuerySlsMetricData_SlsDataPoint slsDataPoint = new QuerySlsMetricDataResponse.QuerySlsMetricData_SlsDataPoint();
				slsDataPoint.Role = context.StringValue("QuerySlsMetricData.Datapoints["+ i +"].Role");
				slsDataPoint._Value = context.StringValue("QuerySlsMetricData.Datapoints["+ i +"].Value");
				slsDataPoint.Timestamp = context.LongValue("QuerySlsMetricData.Datapoints["+ i +"].Timestamp");

				querySlsMetricDataResponse_datapoints.Add(slsDataPoint);
			}
			querySlsMetricDataResponse.Datapoints = querySlsMetricDataResponse_datapoints;
        
			return querySlsMetricDataResponse;
        }
    }
}
