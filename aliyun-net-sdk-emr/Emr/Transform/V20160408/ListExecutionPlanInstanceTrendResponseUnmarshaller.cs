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
    public class ListExecutionPlanInstanceTrendResponseUnmarshaller
    {
        public static ListExecutionPlanInstanceTrendResponse Unmarshall(UnmarshallerContext context)
        {
			ListExecutionPlanInstanceTrendResponse listExecutionPlanInstanceTrendResponse = new ListExecutionPlanInstanceTrendResponse();

			listExecutionPlanInstanceTrendResponse.HttpResponse = context.HttpResponse;
			listExecutionPlanInstanceTrendResponse.RequestId = context.StringValue("ListExecutionPlanInstanceTrend.RequestId");

			List<ListExecutionPlanInstanceTrendResponse.ListExecutionPlanInstanceTrend_Trend> listExecutionPlanInstanceTrendResponse_trends = new List<ListExecutionPlanInstanceTrendResponse.ListExecutionPlanInstanceTrend_Trend>();
			for (int i = 0; i < context.Length("ListExecutionPlanInstanceTrend.Trends.Length"); i++) {
				ListExecutionPlanInstanceTrendResponse.ListExecutionPlanInstanceTrend_Trend trend = new ListExecutionPlanInstanceTrendResponse.ListExecutionPlanInstanceTrend_Trend();
				trend.Day = context.StringValue("ListExecutionPlanInstanceTrend.Trends["+ i +"].Day");
				trend.Count = context.IntegerValue("ListExecutionPlanInstanceTrend.Trends["+ i +"].Count");
				trend.Status = context.StringValue("ListExecutionPlanInstanceTrend.Trends["+ i +"].Status");

				listExecutionPlanInstanceTrendResponse_trends.Add(trend);
			}
			listExecutionPlanInstanceTrendResponse.Trends = listExecutionPlanInstanceTrendResponse_trends;
        
			return listExecutionPlanInstanceTrendResponse;
        }
    }
}
