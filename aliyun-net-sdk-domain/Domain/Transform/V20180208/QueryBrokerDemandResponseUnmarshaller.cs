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
        public static QueryBrokerDemandResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBrokerDemandResponse queryBrokerDemandResponse = new QueryBrokerDemandResponse();

			queryBrokerDemandResponse.HttpResponse = context.HttpResponse;
			queryBrokerDemandResponse.RequestId = context.StringValue("QueryBrokerDemand.RequestId");
			queryBrokerDemandResponse.TotalItemNum = context.IntegerValue("QueryBrokerDemand.TotalItemNum");
			queryBrokerDemandResponse.CurrentPageNum = context.IntegerValue("QueryBrokerDemand.CurrentPageNum");
			queryBrokerDemandResponse.PageSize = context.IntegerValue("QueryBrokerDemand.PageSize");
			queryBrokerDemandResponse.TotalPageNum = context.IntegerValue("QueryBrokerDemand.TotalPageNum");

			List<QueryBrokerDemandResponse.QueryBrokerDemand_Demand> queryBrokerDemandResponse_data = new List<QueryBrokerDemandResponse.QueryBrokerDemand_Demand>();
			for (int i = 0; i < context.Length("QueryBrokerDemand.Data.Length"); i++) {
				QueryBrokerDemandResponse.QueryBrokerDemand_Demand demand = new QueryBrokerDemandResponse.QueryBrokerDemand_Demand();
				demand.BizId = context.StringValue("QueryBrokerDemand.Data["+ i +"].BizId");
				demand.Status = context.StringValue("QueryBrokerDemand.Data["+ i +"].Status");
				demand.DemandDomain = context.StringValue("QueryBrokerDemand.Data["+ i +"].DemandDomain");
				demand.DemandPrice = context.FloatValue("QueryBrokerDemand.Data["+ i +"].DemandPrice");
				demand.Mobile = context.StringValue("QueryBrokerDemand.Data["+ i +"].Mobile");
				demand.Description = context.StringValue("QueryBrokerDemand.Data["+ i +"].Description");
				demand.PublishTime = context.LongValue("QueryBrokerDemand.Data["+ i +"].PublishTime");
				demand.PayDomain = context.StringValue("QueryBrokerDemand.Data["+ i +"].PayDomain");
				demand.PayPrice = context.FloatValue("QueryBrokerDemand.Data["+ i +"].PayPrice");
				demand.PayTime = context.LongValue("QueryBrokerDemand.Data["+ i +"].PayTime");
				demand.ProduceType = context.IntegerValue("QueryBrokerDemand.Data["+ i +"].ProduceType");
				demand.BargainSellerPrice = context.FloatValue("QueryBrokerDemand.Data["+ i +"].BargainSellerPrice");
				demand.BargainSellerMobile = context.StringValue("QueryBrokerDemand.Data["+ i +"].BargainSellerMobile");
				demand.ServicePayPrice = context.FloatValue("QueryBrokerDemand.Data["+ i +"].ServicePayPrice");

				queryBrokerDemandResponse_data.Add(demand);
			}
			queryBrokerDemandResponse.Data = queryBrokerDemandResponse_data;
        
			return queryBrokerDemandResponse;
        }
    }
}
