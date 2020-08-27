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

			List<ListCorpGroupMetricsResponse.ListCorpGroupMetrics_DataItem> listCorpGroupMetricsResponse_data = new List<ListCorpGroupMetricsResponse.ListCorpGroupMetrics_DataItem>();
			for (int i = 0; i < context.Length("ListCorpGroupMetrics.Data.Length"); i++) {
				ListCorpGroupMetricsResponse.ListCorpGroupMetrics_DataItem dataItem = new ListCorpGroupMetricsResponse.ListCorpGroupMetrics_DataItem();
				dataItem.DateId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].DateId");
				dataItem.TagMetrics = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagMetrics");
				dataItem.TagCode = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagCode");
				dataItem.TagValue = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].TagValue");
				dataItem.CorpGroupId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].CorpGroupId");
				dataItem.CorpId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].CorpId");
				dataItem.DeviceGroupId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].DeviceGroupId");
				dataItem.DeviceId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].DeviceId");
				dataItem.UserGroupId = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].UserGroupId");
				dataItem.PersonID = context.StringValue("ListCorpGroupMetrics.Data["+ i +"].PersonID");

				listCorpGroupMetricsResponse_data.Add(dataItem);
			}
			listCorpGroupMetricsResponse.Data = listCorpGroupMetricsResponse_data;
        
			return listCorpGroupMetricsResponse;
        }
    }
}
