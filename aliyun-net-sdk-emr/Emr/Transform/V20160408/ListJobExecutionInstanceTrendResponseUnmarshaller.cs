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
    public class ListJobExecutionInstanceTrendResponseUnmarshaller
    {
        public static ListJobExecutionInstanceTrendResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobExecutionInstanceTrendResponse listJobExecutionInstanceTrendResponse = new ListJobExecutionInstanceTrendResponse();

			listJobExecutionInstanceTrendResponse.HttpResponse = context.HttpResponse;
			listJobExecutionInstanceTrendResponse.RequestId = context.StringValue("ListJobExecutionInstanceTrend.RequestId");

			List<ListJobExecutionInstanceTrendResponse.ListJobExecutionInstanceTrend_Trend> listJobExecutionInstanceTrendResponse_trends = new List<ListJobExecutionInstanceTrendResponse.ListJobExecutionInstanceTrend_Trend>();
			for (int i = 0; i < context.Length("ListJobExecutionInstanceTrend.Trends.Length"); i++) {
				ListJobExecutionInstanceTrendResponse.ListJobExecutionInstanceTrend_Trend trend = new ListJobExecutionInstanceTrendResponse.ListJobExecutionInstanceTrend_Trend();
				trend.Day = context.StringValue("ListJobExecutionInstanceTrend.Trends["+ i +"].Day");
				trend.Count = context.IntegerValue("ListJobExecutionInstanceTrend.Trends["+ i +"].Count");
				trend.Status = context.StringValue("ListJobExecutionInstanceTrend.Trends["+ i +"].Status");

				listJobExecutionInstanceTrendResponse_trends.Add(trend);
			}
			listJobExecutionInstanceTrendResponse.Trends = listJobExecutionInstanceTrendResponse_trends;
        
			return listJobExecutionInstanceTrendResponse;
        }
    }
}
