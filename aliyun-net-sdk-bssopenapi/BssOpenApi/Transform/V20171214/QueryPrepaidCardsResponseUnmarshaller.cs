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
        public static QueryPrepaidCardsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryPrepaidCardsResponse queryPrepaidCardsResponse = new QueryPrepaidCardsResponse();

			queryPrepaidCardsResponse.HttpResponse = context.HttpResponse;
			queryPrepaidCardsResponse.RequestId = context.StringValue("QueryPrepaidCards.RequestId");
			queryPrepaidCardsResponse.Success = context.BooleanValue("QueryPrepaidCards.Success");
			queryPrepaidCardsResponse.Code = context.StringValue("QueryPrepaidCards.Code");
			queryPrepaidCardsResponse.Message = context.StringValue("QueryPrepaidCards.Message");

			List<QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard> queryPrepaidCardsResponse_data = new List<QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard>();
			for (int i = 0; i < context.Length("QueryPrepaidCards.Data.Length"); i++) {
				QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard prepaidCard = new QueryPrepaidCardsResponse.QueryPrepaidCards_PrepaidCard();
				prepaidCard.PrepaidCardId = context.LongValue("QueryPrepaidCards.Data["+ i +"].PrepaidCardId");
				prepaidCard.PrepaidCardNo = context.StringValue("QueryPrepaidCards.Data["+ i +"].PrepaidCardNo");
				prepaidCard.GrantedTime = context.StringValue("QueryPrepaidCards.Data["+ i +"].GrantedTime");
				prepaidCard.EffectiveTime = context.StringValue("QueryPrepaidCards.Data["+ i +"].EffectiveTime");
				prepaidCard.ExpiryTime = context.StringValue("QueryPrepaidCards.Data["+ i +"].ExpiryTime");
				prepaidCard.ApplicableProducts = context.StringValue("QueryPrepaidCards.Data["+ i +"].ApplicableProducts");
				prepaidCard.ApplicableScenarios = context.StringValue("QueryPrepaidCards.Data["+ i +"].ApplicableScenarios");
				prepaidCard.NominalValue = context.StringValue("QueryPrepaidCards.Data["+ i +"].NominalValue");
				prepaidCard.Balance = context.StringValue("QueryPrepaidCards.Data["+ i +"].Balance");
				prepaidCard.Status = context.StringValue("QueryPrepaidCards.Data["+ i +"].Status");

				queryPrepaidCardsResponse_data.Add(prepaidCard);
			}
			queryPrepaidCardsResponse.Data = queryPrepaidCardsResponse_data;
        
			return queryPrepaidCardsResponse;
        }
    }
}
