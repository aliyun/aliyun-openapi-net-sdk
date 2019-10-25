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
using Aliyun.Acs.aliyuncvc.Model.V20190919;

namespace Aliyun.Acs.aliyuncvc.Transform.V20190919
{
    public class ListCommoditiesResponseUnmarshaller
    {
        public static ListCommoditiesResponse Unmarshall(UnmarshallerContext context)
        {
			ListCommoditiesResponse listCommoditiesResponse = new ListCommoditiesResponse();

			listCommoditiesResponse.HttpResponse = context.HttpResponse;
			listCommoditiesResponse.ErrorCode = context.IntegerValue("ListCommodities.ErrorCode");
			listCommoditiesResponse.Message = context.StringValue("ListCommodities.Message");
			listCommoditiesResponse.Success = context.BooleanValue("ListCommodities.Success");
			listCommoditiesResponse.RequestId = context.StringValue("ListCommodities.RequestId");

			ListCommoditiesResponse.ListCommodities_Data data = new ListCommoditiesResponse.ListCommodities_Data();
			data.TotalCount = context.IntegerValue("ListCommodities.Data.TotalCount");
			data.PageSize = context.IntegerValue("ListCommodities.Data.PageSize");
			data.PageNumber = context.IntegerValue("ListCommodities.Data.PageNumber");

			List<ListCommoditiesResponse.ListCommodities_Data.ListCommodities_Commodity> data_commodities = new List<ListCommoditiesResponse.ListCommodities_Data.ListCommodities_Commodity>();
			for (int i = 0; i < context.Length("ListCommodities.Data.Commodities.Length"); i++) {
				ListCommoditiesResponse.ListCommodities_Data.ListCommodities_Commodity commodity = new ListCommoditiesResponse.ListCommodities_Data.ListCommodities_Commodity();
				commodity.EndTime = context.StringValue("ListCommodities.Data.Commodities["+ i +"].EndTime");
				commodity.Instancepropertyvalue = context.StringValue("ListCommodities.Data.Commodities["+ i +"].Instancepropertyvalue");
				commodity.StartTime = context.StringValue("ListCommodities.Data.Commodities["+ i +"].StartTime");

				data_commodities.Add(commodity);
			}
			data.Commodities = data_commodities;
			listCommoditiesResponse.Data = data;
        
			return listCommoditiesResponse;
        }
    }
}
