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
using Aliyun.Acs.Httpdns.Model.V20160201;

namespace Aliyun.Acs.Httpdns.Transform.V20160201
{
    public class GetResolveStatisticsResponseUnmarshaller
    {
        public static GetResolveStatisticsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResolveStatisticsResponse getResolveStatisticsResponse = new GetResolveStatisticsResponse();

			getResolveStatisticsResponse.HttpResponse = _ctx.HttpResponse;
			getResolveStatisticsResponse.RequestId = _ctx.StringValue("GetResolveStatistics.RequestId");

			List<GetResolveStatisticsResponse.GetResolveStatistics_DataPoint> getResolveStatisticsResponse_dataPoints = new List<GetResolveStatisticsResponse.GetResolveStatistics_DataPoint>();
			for (int i = 0; i < _ctx.Length("GetResolveStatistics.DataPoints.Length"); i++) {
				GetResolveStatisticsResponse.GetResolveStatistics_DataPoint dataPoint = new GetResolveStatisticsResponse.GetResolveStatistics_DataPoint();
				dataPoint.Time = _ctx.IntegerValue("GetResolveStatistics.DataPoints["+ i +"].Time");
				dataPoint.Count = _ctx.IntegerValue("GetResolveStatistics.DataPoints["+ i +"].Count");

				getResolveStatisticsResponse_dataPoints.Add(dataPoint);
			}
			getResolveStatisticsResponse.DataPoints = getResolveStatisticsResponse_dataPoints;
        
			return getResolveStatisticsResponse;
        }
    }
}
