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
    public class QueryRedeemResponseUnmarshaller
    {
        public static QueryRedeemResponse Unmarshall(UnmarshallerContext context)
        {
			QueryRedeemResponse queryRedeemResponse = new QueryRedeemResponse();

			queryRedeemResponse.HttpResponse = context.HttpResponse;
			queryRedeemResponse.RequestId = context.StringValue("QueryRedeem.RequestId");
			queryRedeemResponse.Success = context.BooleanValue("QueryRedeem.Success");
			queryRedeemResponse.Code = context.StringValue("QueryRedeem.Code");
			queryRedeemResponse.Message = context.StringValue("QueryRedeem.Message");

			QueryRedeemResponse.QueryRedeem_Data data = new QueryRedeemResponse.QueryRedeem_Data();
			data.PageNum = context.LongValue("QueryRedeem.Data.PageNum");
			data.PageSize = context.LongValue("QueryRedeem.Data.PageSize");
			data.TotalCount = context.LongValue("QueryRedeem.Data.TotalCount");

			List<QueryRedeemResponse.QueryRedeem_Data.QueryRedeem_RedeemItem> data_redeem = new List<QueryRedeemResponse.QueryRedeem_Data.QueryRedeem_RedeemItem>();
			for (int i = 0; i < context.Length("QueryRedeem.Data.Redeem.Length"); i++) {
				QueryRedeemResponse.QueryRedeem_Data.QueryRedeem_RedeemItem redeemItem = new QueryRedeemResponse.QueryRedeem_Data.QueryRedeem_RedeemItem();
				redeemItem.RedeemId = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].RedeemId");
				redeemItem.RedeemNo = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].RedeemNo");
				redeemItem.Status = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].Status");
				redeemItem.GrantedTime = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].GrantedTime");
				redeemItem.EffectiveTime = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].EffectiveTime");
				redeemItem.ExpiryTime = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].ExpiryTime");
				redeemItem.NominalValue = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].NominalValue");
				redeemItem.Balance = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].Balance");
				redeemItem.ApplicableProducts = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].ApplicableProducts");
				redeemItem.Specification = context.StringValue("QueryRedeem.Data.Redeem["+ i +"].Specification");

				data_redeem.Add(redeemItem);
			}
			data.Redeem = data_redeem;
			queryRedeemResponse.Data = data;
        
			return queryRedeemResponse;
        }
    }
}
