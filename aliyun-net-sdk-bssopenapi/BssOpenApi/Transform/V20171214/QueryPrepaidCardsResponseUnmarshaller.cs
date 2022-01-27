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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryPrepaidCardsResponseUnmarshaller
    {
        public static QueryPrepaidCardsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPrepaidCardsResponse queryPrepaidCardsResponse = new QueryPrepaidCardsResponse();

			queryPrepaidCardsResponse.HttpResponse = _ctx.HttpResponse;
			queryPrepaidCardsResponse.RequestId = _ctx.StringValue("QueryPrepaidCards.RequestId");
			queryPrepaidCardsResponse.Success = _ctx.BooleanValue("QueryPrepaidCards.Success");
			queryPrepaidCardsResponse.Code = _ctx.StringValue("QueryPrepaidCards.Code");
			queryPrepaidCardsResponse.Message = _ctx.StringValue("QueryPrepaidCards.Message");

			List<QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard> queryPrepaidCardsResponse_data = new List<QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard>();
			for (int i = 0; i < _ctx.Length("QueryPrepaidCards.Data.Length"); i++) {
				QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard prepaidCard = new QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard();
				prepaidCard.PrepaidCardId = _ctx.LongValue("QueryPrepaidCards.Data["+ i +"].PrepaidCardId");
				prepaidCard.PrepaidCardNo = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].PrepaidCardNo");
				prepaidCard.GrantedTime = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].GrantedTime");
				prepaidCard.EffectiveTime = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].EffectiveTime");
				prepaidCard.ExpiryTime = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].ExpiryTime");
				prepaidCard.ApplicableProducts = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].ApplicableProducts");
				prepaidCard.ApplicableScenarios = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].ApplicableScenarios");
				prepaidCard.NominalValue = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].NominalValue");
				prepaidCard.Balance = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].Balance");
				prepaidCard.Status = _ctx.StringValue("QueryPrepaidCards.Data["+ i +"].Status");

				queryPrepaidCardsResponse_data.Add(prepaidCard);
			}
			queryPrepaidCardsResponse.Data = queryPrepaidCardsResponse_data;
        
			return queryPrepaidCardsResponse;
        }
    }
}
