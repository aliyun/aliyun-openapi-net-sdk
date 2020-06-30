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
    public class ListMetricsResponseUnmarshaller
    {
        public static ListMetricsResponse Unmarshall(UnmarshallerContext context)
        {
			ListMetricsResponse listMetricsResponse = new ListMetricsResponse();

			listMetricsResponse.HttpResponse = context.HttpResponse;
			listMetricsResponse.Code = context.StringValue("ListMetrics.Code");
			listMetricsResponse.Message = context.StringValue("ListMetrics.Message");
			listMetricsResponse.RequestId = context.StringValue("ListMetrics.RequestId");

			ListMetricsResponse.ListMetrics_Data data = new ListMetricsResponse.ListMetrics_Data();
			data.PageNumber = context.IntegerValue("ListMetrics.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListMetrics.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListMetrics.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListMetrics.Data.TotalPage");

			List<ListMetricsResponse.ListMetrics_Data.ListMetrics_RecordsItem> data_records = new List<ListMetricsResponse.ListMetrics_Data.ListMetrics_RecordsItem>();
			for (int i = 0; i < context.Length("ListMetrics.Data.Records.Length"); i++) {
				ListMetricsResponse.ListMetrics_Data.ListMetrics_RecordsItem recordsItem = new ListMetricsResponse.ListMetrics_Data.ListMetrics_RecordsItem();
				recordsItem.DateTime = context.StringValue("ListMetrics.Data.Records["+ i +"].DateTime");
				recordsItem.TagCode = context.StringValue("ListMetrics.Data.Records["+ i +"].TagCode");
				recordsItem.TagValue = context.StringValue("ListMetrics.Data.Records["+ i +"].TagValue");
				recordsItem.TagMetric = context.StringValue("ListMetrics.Data.Records["+ i +"].TagMetric");

				data_records.Add(recordsItem);
			}
			data.Records = data_records;
			listMetricsResponse.Data = data;
        
			return listMetricsResponse;
        }
    }
}
