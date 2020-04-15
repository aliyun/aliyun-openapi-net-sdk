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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class SearchTmOnsalesResponseUnmarshaller
    {
        public static SearchTmOnsalesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTmOnsalesResponse searchTmOnsalesResponse = new SearchTmOnsalesResponse();

			searchTmOnsalesResponse.HttpResponse = context.HttpResponse;
			searchTmOnsalesResponse.RequestId = context.StringValue("SearchTmOnsales.RequestId");
			searchTmOnsalesResponse.TotalCount = context.IntegerValue("SearchTmOnsales.TotalCount");
			searchTmOnsalesResponse.PageNumber = context.IntegerValue("SearchTmOnsales.PageNumber");
			searchTmOnsalesResponse.PageSize = context.IntegerValue("SearchTmOnsales.PageSize");
			searchTmOnsalesResponse.TotalPageNumber = context.IntegerValue("SearchTmOnsales.TotalPageNumber");

			List<SearchTmOnsalesResponse.SearchTmOnsales_Trademark> searchTmOnsalesResponse_trademarks = new List<SearchTmOnsalesResponse.SearchTmOnsales_Trademark>();
			for (int i = 0; i < context.Length("SearchTmOnsales.Trademarks.Length"); i++) {
				SearchTmOnsalesResponse.SearchTmOnsales_Trademark trademark = new SearchTmOnsalesResponse.SearchTmOnsales_Trademark();
				trademark.Uid = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].Uid");
				trademark.TrademarkName = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].TrademarkName");
				trademark.RegistrationNumber = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].RegistrationNumber");
				trademark.Classification = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].Classification");
				trademark.Icon = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].Icon");
				trademark.ProductCode = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].ProductCode");
				trademark.OrderPrice = context.LongValue("SearchTmOnsales.Trademarks["+ i +"].OrderPrice");
				trademark.ProductDesc = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].ProductDesc");
				trademark.PartnerCode = context.StringValue("SearchTmOnsales.Trademarks["+ i +"].PartnerCode");
				trademark.Status = context.LongValue("SearchTmOnsales.Trademarks["+ i +"].Status");

				searchTmOnsalesResponse_trademarks.Add(trademark);
			}
			searchTmOnsalesResponse.Trademarks = searchTmOnsalesResponse_trademarks;
        
			return searchTmOnsalesResponse;
        }
    }
}
