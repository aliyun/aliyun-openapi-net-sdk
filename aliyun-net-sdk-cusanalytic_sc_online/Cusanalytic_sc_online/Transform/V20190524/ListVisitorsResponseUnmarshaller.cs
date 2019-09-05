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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class ListVisitorsResponseUnmarshaller
    {
        public static ListVisitorsResponse Unmarshall(UnmarshallerContext context)
        {
			ListVisitorsResponse listVisitorsResponse = new ListVisitorsResponse();

			listVisitorsResponse.HttpResponse = context.HttpResponse;
			listVisitorsResponse.Total = context.LongValue("ListVisitors.Total");
			listVisitorsResponse.PageIndex = context.IntegerValue("ListVisitors.PageIndex");
			listVisitorsResponse.PageSize = context.IntegerValue("ListVisitors.PageSize");

			List<ListVisitorsResponse.ListVisitors_VisitorItem> listVisitorsResponse_visitorItems = new List<ListVisitorsResponse.ListVisitors_VisitorItem>();
			for (int i = 0; i < context.Length("ListVisitors.VisitorItems.Length"); i++) {
				ListVisitorsResponse.ListVisitors_VisitorItem visitorItem = new ListVisitorsResponse.ListVisitors_VisitorItem();
				visitorItem.Img = context.StringValue("ListVisitors.VisitorItems["+ i +"].Img");
				visitorItem.PkId = context.StringValue("ListVisitors.VisitorItems["+ i +"].PkId");
				visitorItem.LatelyTime = context.LongValue("ListVisitors.VisitorItems["+ i +"].LatelyTime");
				visitorItem.EarliestPlace = context.StringValue("ListVisitors.VisitorItems["+ i +"].EarliestPlace");
				visitorItem.UkId = context.StringValue("ListVisitors.VisitorItems["+ i +"].UkId");
				visitorItem.Gender = context.StringValue("ListVisitors.VisitorItems["+ i +"].Gender");
				visitorItem.EarliestTime = context.LongValue("ListVisitors.VisitorItems["+ i +"].EarliestTime");
				visitorItem.LatelyPlace = context.StringValue("ListVisitors.VisitorItems["+ i +"].LatelyPlace");
				visitorItem.Age = context.LongValue("ListVisitors.VisitorItems["+ i +"].Age");
				visitorItem.StoreId = context.LongValue("ListVisitors.VisitorItems["+ i +"].StoreId");
				visitorItem.EnterCount = context.LongValue("ListVisitors.VisitorItems["+ i +"].EnterCount");

				listVisitorsResponse_visitorItems.Add(visitorItem);
			}
			listVisitorsResponse.VisitorItems = listVisitorsResponse_visitorItems;
        
			return listVisitorsResponse;
        }
    }
}
