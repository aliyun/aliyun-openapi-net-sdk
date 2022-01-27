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
        public static QueryServicePackAndPriceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryServicePackAndPriceResponse queryServicePackAndPriceResponse = new QueryServicePackAndPriceResponse();

			queryServicePackAndPriceResponse.HttpResponse = _ctx.HttpResponse;
			queryServicePackAndPriceResponse.RequestId = _ctx.StringValue("QueryServicePackAndPrice.RequestId");
			queryServicePackAndPriceResponse.RegionId = _ctx.StringValue("QueryServicePackAndPrice.RegionId");
			queryServicePackAndPriceResponse.TradePrice = _ctx.FloatValue("QueryServicePackAndPrice.TradePrice");
			queryServicePackAndPriceResponse.OriginalPrice = _ctx.FloatValue("QueryServicePackAndPrice.OriginalPrice");
			queryServicePackAndPriceResponse.DiscountPrice = _ctx.FloatValue("QueryServicePackAndPrice.DiscountPrice");
			queryServicePackAndPriceResponse.Currency = _ctx.StringValue("QueryServicePackAndPrice.Currency");
			queryServicePackAndPriceResponse.OriginalAmount = _ctx.IntegerValue("QueryServicePackAndPrice.OriginalAmount");
			queryServicePackAndPriceResponse.ChargeAmount = _ctx.IntegerValue("QueryServicePackAndPrice.ChargeAmount");

			List<QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo> queryServicePackAndPriceResponse_servicePack = new List<QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo>();
			for (int i = 0; i < _ctx.Length("QueryServicePackAndPrice.ServicePack.Length"); i++) {
				QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo servicePackInfo = new QueryServicePackAndPriceResponse.QueryServicePackAndPrice_ServicePackInfo();
				servicePackInfo.InstanceName = _ctx.StringValue("QueryServicePackAndPrice.ServicePack["+ i +"].InstanceName");
				servicePackInfo.Capacity = _ctx.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].Capacity");
				servicePackInfo.StartTime = _ctx.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].StartTime");
				servicePackInfo.EndTime = _ctx.IntegerValue("QueryServicePackAndPrice.ServicePack["+ i +"].EndTime");

				queryServicePackAndPriceResponse_servicePack.Add(servicePackInfo);
			}
			queryServicePackAndPriceResponse.ServicePack = queryServicePackAndPriceResponse_servicePack;
        
			return queryServicePackAndPriceResponse;
        }
    }
}
