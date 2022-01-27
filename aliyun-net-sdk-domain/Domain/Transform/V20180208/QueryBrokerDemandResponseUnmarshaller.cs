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
using Aliyun.Acs.Domain.Model.V20180208;

namespace Aliyun.Acs.Domain.Transform.V20180208
{
    public class QueryBrokerDemandResponseUnmarshaller
    {
        public static QueryBrokerDemandResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryBrokerDemandResponse queryBrokerDemandResponse = new QueryBrokerDemandResponse();

			queryBrokerDemandResponse.HttpResponse = _ctx.HttpResponse;
			queryBrokerDemandResponse.CurrentPageNum = _ctx.IntegerValue("QueryBrokerDemand.CurrentPageNum");
			queryBrokerDemandResponse.TotalPageNum = _ctx.IntegerValue("QueryBrokerDemand.TotalPageNum");
			queryBrokerDemandResponse.PageSize = _ctx.IntegerValue("QueryBrokerDemand.PageSize");
			queryBrokerDemandResponse.RequestId = _ctx.StringValue("QueryBrokerDemand.RequestId");
			queryBrokerDemandResponse.TotalItemNum = _ctx.IntegerValue("QueryBrokerDemand.TotalItemNum");

			List<QueryBrokerDemandResponse.QueryBrokerDemand_Demand> queryBrokerDemandResponse_data = new List<QueryBrokerDemandResponse.QueryBrokerDemand_Demand>();
			for (int i = 0; i < _ctx.Length("QueryBrokerDemand.Data.Length"); i++) {
				QueryBrokerDemandResponse.QueryBrokerDemand_Demand demand = new QueryBrokerDemandResponse.QueryBrokerDemand_Demand();
				demand.Status = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].Status");
				demand.DemandPrice = _ctx.FloatValue("QueryBrokerDemand.Data["+ i +"].DemandPrice");
				demand.BizId = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].BizId");
				demand.BargainSellerMobile = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].BargainSellerMobile");
				demand.PublishTime = _ctx.LongValue("QueryBrokerDemand.Data["+ i +"].PublishTime");
				demand.ProduceType = _ctx.IntegerValue("QueryBrokerDemand.Data["+ i +"].ProduceType");
				demand.DemandDomain = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].DemandDomain");
				demand.Description = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].Description");
				demand.Mobile = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].Mobile");
				demand.ServicePayPrice = _ctx.FloatValue("QueryBrokerDemand.Data["+ i +"].ServicePayPrice");
				demand.PayPrice = _ctx.FloatValue("QueryBrokerDemand.Data["+ i +"].PayPrice");
				demand.PayTime = _ctx.LongValue("QueryBrokerDemand.Data["+ i +"].PayTime");
				demand.BargainSellerPrice = _ctx.FloatValue("QueryBrokerDemand.Data["+ i +"].BargainSellerPrice");
				demand.OrderType = _ctx.IntegerValue("QueryBrokerDemand.Data["+ i +"].OrderType");
				demand.PayDomain = _ctx.StringValue("QueryBrokerDemand.Data["+ i +"].PayDomain");
				demand.AuditStatus = _ctx.IntegerValue("QueryBrokerDemand.Data["+ i +"].AuditStatus");

				queryBrokerDemandResponse_data.Add(demand);
			}
			queryBrokerDemandResponse.Data = queryBrokerDemandResponse_data;
        
			return queryBrokerDemandResponse;
        }
    }
}
