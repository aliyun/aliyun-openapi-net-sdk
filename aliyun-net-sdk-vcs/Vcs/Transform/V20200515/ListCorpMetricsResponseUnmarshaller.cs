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
    public class ListCorpMetricsResponseUnmarshaller
    {
        public static ListCorpMetricsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCorpMetricsResponse listCorpMetricsResponse = new ListCorpMetricsResponse();

			listCorpMetricsResponse.HttpResponse = context.HttpResponse;
			listCorpMetricsResponse.Code = context.StringValue("ListCorpMetrics.Code");
			listCorpMetricsResponse.Message = context.StringValue("ListCorpMetrics.Message");
			listCorpMetricsResponse.PageNumber = context.IntegerValue("ListCorpMetrics.PageNumber");
			listCorpMetricsResponse.PageSize = context.IntegerValue("ListCorpMetrics.PageSize");
			listCorpMetricsResponse.RequestId = context.StringValue("ListCorpMetrics.RequestId");
			listCorpMetricsResponse.Success = context.StringValue("ListCorpMetrics.Success");
			listCorpMetricsResponse.TotalCount = context.IntegerValue("ListCorpMetrics.TotalCount");

			List<ListCorpMetricsResponse.ListCorpMetrics_DataItem> listCorpMetricsResponse_data = new List<ListCorpMetricsResponse.ListCorpMetrics_DataItem>();
			for (int i = 0; i < context.Length("ListCorpMetrics.Data.Length"); i++) {
				ListCorpMetricsResponse.ListCorpMetrics_DataItem dataItem = new ListCorpMetricsResponse.ListCorpMetrics_DataItem();
				dataItem.CorpId = context.StringValue("ListCorpMetrics.Data["+ i +"].CorpId");
				dataItem.TagCode = context.StringValue("ListCorpMetrics.Data["+ i +"].TagCode");
				dataItem.TagMetrics = context.StringValue("ListCorpMetrics.Data["+ i +"].TagMetrics");
				dataItem.TagValue = context.StringValue("ListCorpMetrics.Data["+ i +"].TagValue");
				dataItem.DeviceGroupId = context.StringValue("ListCorpMetrics.Data["+ i +"].DeviceGroupId");
				dataItem.DeviceId = context.StringValue("ListCorpMetrics.Data["+ i +"].DeviceId");
				dataItem.UserGroupId = context.StringValue("ListCorpMetrics.Data["+ i +"].UserGroupId");
				dataItem.PersonId = context.StringValue("ListCorpMetrics.Data["+ i +"].PersonId");
				dataItem.DateId = context.StringValue("ListCorpMetrics.Data["+ i +"].DateId");

				listCorpMetricsResponse_data.Add(dataItem);
			}
			listCorpMetricsResponse.Data = listCorpMetricsResponse_data;
        
			return listCorpMetricsResponse;
        }
    }
}
