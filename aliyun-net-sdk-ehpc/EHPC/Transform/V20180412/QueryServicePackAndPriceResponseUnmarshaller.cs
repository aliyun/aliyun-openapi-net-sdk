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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class QueryServicePackAndPriceResponseUnmarshaller
    {
        public static QueryServicePackAndPriceResponse Unmarshall(UnmarshallerContext context)
        {
			QueryServicePackAndPriceResponse queryServicePackAndPriceResponse = new QueryServicePackAndPriceResponse();

			queryServicePackAndPriceResponse.HttpResponse = context.HttpResponse;
			queryServicePackAndPriceResponse.RequestId = context.StringValue("QueryServicePackAndPrice.RequestId");
			queryServicePackAndPriceResponse.RegionId = context.StringValue("QueryServicePackAndPrice.RegionId");
			queryServicePackAndPriceResponse.TradePrice = context.FloatValue("QueryServicePackAndPrice.TradePrice");
			queryServicePackAndPriceResponse.OriginalPrice = context.FloatValue("QueryServicePackAndPrice.OriginalPrice");
			queryServicePackAndPriceResponse.DiscountPrice = context.FloatValue("QueryServicePackAndPrice.DiscountPrice");
			queryServicePackAndPriceResponse.Currency = context.StringValue("QueryServicePackAndPrice.Currency");
			queryServicePackAndPriceResponse.OriginalAmount = context.IntegerValue("QueryServicePackAndPrice.OriginalAmount");
			queryServicePackAndPriceResponse.ChargeAmount = context.IntegerValue("QueryServicePackAndPrice.ChargeAmount");

			List<QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo> queryServicePackAndPriceResponse_servicePack = new List<QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo>();
			for (int i = 0; i < context.Length("QueryServicePackAndPrice.ServicePack.Length"); i++) {
				QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo servicePackInfo = new QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo();
				servicePackInfo.InstanceName = context.StringValue("QueryServicePackAndPrice.ServicePack["+ i +"].InstanceName");
				servicePackInfo.Capacity = context.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].Capacity");
				servicePackInfo.StartTime = context.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].StartTime");
				servicePackInfo.EndTime = context.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].EndTime");

				queryServicePackAndPriceResponse_servicePack.Add(servicePackInfo);
			}
			queryServicePackAndPriceResponse.ServicePack = queryServicePackAndPriceResponse_servicePack;
        
			return queryServicePackAndPriceResponse;
        }
    }
}
