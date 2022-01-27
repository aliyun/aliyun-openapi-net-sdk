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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class QueryGateVerifyBillingPublicResponseUnmarshaller
    {
        public static QueryGateVerifyBillingPublicResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryGateVerifyBillingPublicResponse queryGateVerifyBillingPublicResponse = new QueryGateVerifyBillingPublicResponse();

			queryGateVerifyBillingPublicResponse.HttpResponse = _ctx.HttpResponse;
			queryGateVerifyBillingPublicResponse.Code = _ctx.StringValue("QueryGateVerifyBillingPublic.Code");
			queryGateVerifyBillingPublicResponse.Message = _ctx.StringValue("QueryGateVerifyBillingPublic.Message");
			queryGateVerifyBillingPublicResponse.RequestId = _ctx.StringValue("QueryGateVerifyBillingPublic.RequestId");

			QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data data = new QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data();
			data.AmountSum = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.AmountSum");

			List<QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data.QueryGateVerifyBillingPublic_SceneBillingListItem> data_sceneBillingList = new List<QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data.QueryGateVerifyBillingPublic_SceneBillingListItem>();
			for (int i = 0; i < _ctx.Length("QueryGateVerifyBillingPublic.Data.SceneBillingList.Length"); i++) {
				QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data.QueryGateVerifyBillingPublic_SceneBillingListItem sceneBillingListItem = new QueryGateVerifyBillingPublicResponse.QueryGateVerifyBillingPublic_Data.QueryGateVerifyBillingPublic_SceneBillingListItem();
				sceneBillingListItem._Add = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].Add");
				sceneBillingListItem.SinglePrice = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].SinglePrice");
				sceneBillingListItem.Amount = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].Amount");
				sceneBillingListItem.ItemName = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].ItemName");
				sceneBillingListItem.SceneCode = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].SceneCode");
				sceneBillingListItem.AppName = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].AppName");
				sceneBillingListItem.SceneName = _ctx.StringValue("QueryGateVerifyBillingPublic.Data.SceneBillingList["+ i +"].SceneName");

				data_sceneBillingList.Add(sceneBillingListItem);
			}
			data.SceneBillingList = data_sceneBillingList;
			queryGateVerifyBillingPublicResponse.Data = data;
        
			return queryGateVerifyBillingPublicResponse;
        }
    }
}
