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
using Aliyun.Acs.idaas_doraemon.Model.V20210520;

namespace Aliyun.Acs.idaas_doraemon.Transform.V20210520
{
    public class ListOrderConsumeStatisticRecordsResponseUnmarshaller
    {
        public static ListOrderConsumeStatisticRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOrderConsumeStatisticRecordsResponse listOrderConsumeStatisticRecordsResponse = new ListOrderConsumeStatisticRecordsResponse();

			listOrderConsumeStatisticRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listOrderConsumeStatisticRecordsResponse.RequestId = _ctx.StringValue("ListOrderConsumeStatisticRecords.RequestId");
			listOrderConsumeStatisticRecordsResponse.TotalPages = _ctx.LongValue("ListOrderConsumeStatisticRecords.TotalPages");
			listOrderConsumeStatisticRecordsResponse.TotalElements = _ctx.LongValue("ListOrderConsumeStatisticRecords.TotalElements");
			listOrderConsumeStatisticRecordsResponse.PageSize = _ctx.LongValue("ListOrderConsumeStatisticRecords.PageSize");

			List<ListOrderConsumeStatisticRecordsResponse.ListOrderConsumeStatisticRecords_Item> listOrderConsumeStatisticRecordsResponse_items = new List<ListOrderConsumeStatisticRecordsResponse.ListOrderConsumeStatisticRecords_Item>();
			for (int i = 0; i < _ctx.Length("ListOrderConsumeStatisticRecords.Items.Length"); i++) {
				ListOrderConsumeStatisticRecordsResponse.ListOrderConsumeStatisticRecords_Item item = new ListOrderConsumeStatisticRecordsResponse.ListOrderConsumeStatisticRecords_Item();
				item.AliOrderCode = _ctx.StringValue("ListOrderConsumeStatisticRecords.Items["+ i +"].AliOrderCode");
				item.StatisticTime = _ctx.LongValue("ListOrderConsumeStatisticRecords.Items["+ i +"].StatisticTime");
				item.ApplicationExternalId = _ctx.StringValue("ListOrderConsumeStatisticRecords.Items["+ i +"].ApplicationExternalId");
				item.ServiceCode = _ctx.StringValue("ListOrderConsumeStatisticRecords.Items["+ i +"].ServiceCode");
				item.UnitPrice = _ctx.LongValue("ListOrderConsumeStatisticRecords.Items["+ i +"].UnitPrice");
				item.ChargedCount = _ctx.LongValue("ListOrderConsumeStatisticRecords.Items["+ i +"].ChargedCount");
				item.TotalPrice = _ctx.LongValue("ListOrderConsumeStatisticRecords.Items["+ i +"].TotalPrice");

				listOrderConsumeStatisticRecordsResponse_items.Add(item);
			}
			listOrderConsumeStatisticRecordsResponse.Items = listOrderConsumeStatisticRecordsResponse_items;
        
			return listOrderConsumeStatisticRecordsResponse;
        }
    }
}
