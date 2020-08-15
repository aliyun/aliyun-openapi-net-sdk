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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListCorpGroupMetricsResponseUnmarshaller
    {
        public static ListCorpGroupMetricsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCorpGroupMetricsResponse listCorpGroupMetricsResponse = new ListCorpGroupMetricsResponse();

			listCorpGroupMetricsResponse.HttpResponse = context.HttpResponse;
			listCorpGroupMetricsResponse.Code = context.StringValue("ListCorpGroupMetrics.Code");
			listCorpGroupMetricsResponse.Message = context.StringValue("ListCorpGroupMetrics.Message");
			listCorpGroupMetricsResponse.RequestId = context.StringValue("ListCorpGroupMetrics.RequestId");
			listCorpGroupMetricsResponse.PageNumber = context.IntegerValue("ListCorpGroupMetrics.PageNumber");
			listCorpGroupMetricsResponse.PageSize = context.IntegerValue("ListCorpGroupMetrics.PageSize");
			listCorpGroupMetricsResponse.TotalCount = context.IntegerValue("ListCorpGroupMetrics.TotalCount");
			listCorpGroupMetricsResponse.Success = context.StringValue("ListCorpGroupMetrics.Success");

			List<ListCorpGroupMetricsResponse.ListCorpGroupMetrics_Day> listCorpGroupMetricsResponse_data = new List<ListCorpGroupMetricsResponse.ListCorpGroupMetrics_Day>();
			for (int i = 0; i < context.Length("ListCorpGroupMetrics.Data.Length"); i++) {
				ListCorpGroupMetricsResponse.ListCorpGroupMetrics_Day day = new ListCorpGroupMetricsResponse.ListCorpGroupMetrics_Day();
				day.CheckedTime = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].CheckedTime");
				day.TagMetrics = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagMetrics");
				day.TagCode = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagCode");
				day.TagValue = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagValue");
				day.GroupId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].GroupId");

				listCorpGroupMetricsResponse_data.Add(day);
			}
			listCorpGroupMetricsResponse.Data = listCorpGroupMetricsResponse_data;
        
			return listCorpGroupMetricsResponse;
        }
    }
}
