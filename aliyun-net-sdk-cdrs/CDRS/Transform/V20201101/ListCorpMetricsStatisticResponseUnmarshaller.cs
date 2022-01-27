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
    public class ListCorpMetricsStatisticResponseUnmarshaller
    {
        public static ListCorpMetricsStatisticResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCorpMetricsStatisticResponse listCorpMetricsStatisticResponse = new ListCorpMetricsStatisticResponse();

			listCorpMetricsStatisticResponse.HttpResponse = _ctx.HttpResponse;
			listCorpMetricsStatisticResponse.TotalCount = _ctx.IntegerValue("ListCorpMetricsStatistic.TotalCount");
			listCorpMetricsStatisticResponse.PageSize = _ctx.IntegerValue("ListCorpMetricsStatistic.PageSize");
			listCorpMetricsStatisticResponse.Message = _ctx.StringValue("ListCorpMetricsStatistic.Message");
			listCorpMetricsStatisticResponse.RequestId = _ctx.StringValue("ListCorpMetricsStatistic.RequestId");
			listCorpMetricsStatisticResponse.PageNumber = _ctx.IntegerValue("ListCorpMetricsStatistic.PageNumber");
			listCorpMetricsStatisticResponse.Code = _ctx.StringValue("ListCorpMetricsStatistic.Code");
			listCorpMetricsStatisticResponse.Success = _ctx.StringValue("ListCorpMetricsStatistic.Success");

			List<ListCorpMetricsStatisticResponse.ListCorpMetricsStatistic_DataItem> listCorpMetricsStatisticResponse_data = new List<ListCorpMetricsStatisticResponse.ListCorpMetricsStatistic_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCorpMetricsStatistic.Data.Length"); i++) {
				ListCorpMetricsStatisticResponse.ListCorpMetricsStatistic_DataItem dataItem = new ListCorpMetricsStatisticResponse.ListCorpMetricsStatistic_DataItem();
				dataItem.CorpId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].CorpId");
				dataItem.PersonId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].PersonId");
				dataItem.DeviceGroupId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].DeviceGroupId");
				dataItem.DeviceId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].DeviceId");
				dataItem.UserGroupId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].UserGroupId");
				dataItem.TagMetrics = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].TagMetrics");
				dataItem.TagCode = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].TagCode");
				dataItem.TagValue = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].TagValue");
				dataItem.DateId = _ctx.StringValue("ListCorpMetricsStatistic.Data["+ i +"].DateId");

				listCorpMetricsStatisticResponse_data.Add(dataItem);
			}
			listCorpMetricsStatisticResponse.Data = listCorpMetricsStatisticResponse_data;
        
			return listCorpMetricsStatisticResponse;
        }
    }
}
