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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListCorpMetricsResponseUnmarshaller
    {
        public static ListCorpMetricsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCorpMetricsResponse listCorpMetricsResponse = new ListCorpMetricsResponse();

			listCorpMetricsResponse.HttpResponse = _ctx.HttpResponse;
			listCorpMetricsResponse.TotalCount = _ctx.IntegerValue("ListCorpMetrics.TotalCount");
			listCorpMetricsResponse.PageSize = _ctx.IntegerValue("ListCorpMetrics.PageSize");
			listCorpMetricsResponse.Message = _ctx.StringValue("ListCorpMetrics.Message");
			listCorpMetricsResponse.RequestId = _ctx.StringValue("ListCorpMetrics.RequestId");
			listCorpMetricsResponse.PageNumber = _ctx.IntegerValue("ListCorpMetrics.PageNumber");
			listCorpMetricsResponse.Code = _ctx.StringValue("ListCorpMetrics.Code");
			listCorpMetricsResponse.Success = _ctx.StringValue("ListCorpMetrics.Success");

			List<ListCorpMetricsResponse.ListCorpMetrics_DataItem> listCorpMetricsResponse_data = new List<ListCorpMetricsResponse.ListCorpMetrics_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCorpMetrics.Data.Length"); i++) {
				ListCorpMetricsResponse.ListCorpMetrics_DataItem dataItem = new ListCorpMetricsResponse.ListCorpMetrics_DataItem();
				dataItem.CorpId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].CorpId");
				dataItem.PersonId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].PersonId");
				dataItem.DeviceGroupId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].DeviceGroupId");
				dataItem.DeviceId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].DeviceId");
				dataItem.UserGroupId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].UserGroupId");
				dataItem.TagMetrics = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].TagMetrics");
				dataItem.TagCode = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].TagCode");
				dataItem.TagValue = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].TagValue");
				dataItem.DateId = _ctx.StringValue("ListCorpMetrics.Data["+ i +"].DateId");

				listCorpMetricsResponse_data.Add(dataItem);
			}
			listCorpMetricsResponse.Data = listCorpMetricsResponse_data;
        
			return listCorpMetricsResponse;
        }
    }
}
