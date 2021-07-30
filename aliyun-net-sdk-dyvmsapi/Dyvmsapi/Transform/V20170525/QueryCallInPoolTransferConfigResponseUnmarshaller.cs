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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class QueryCallInPoolTransferConfigResponseUnmarshaller
    {
        public static QueryCallInPoolTransferConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCallInPoolTransferConfigResponse queryCallInPoolTransferConfigResponse = new QueryCallInPoolTransferConfigResponse();

			queryCallInPoolTransferConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryCallInPoolTransferConfigResponse.RequestId = _ctx.StringValue("QueryCallInPoolTransferConfig.RequestId");
			queryCallInPoolTransferConfigResponse.Code = _ctx.StringValue("QueryCallInPoolTransferConfig.Code");
			queryCallInPoolTransferConfigResponse.Message = _ctx.StringValue("QueryCallInPoolTransferConfig.Message");

			QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data data = new QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data();
			data.TransferTimeout = _ctx.StringValue("QueryCallInPoolTransferConfig.Data.TransferTimeout");
			data.CalledRouteMode = _ctx.StringValue("QueryCallInPoolTransferConfig.Data.CalledRouteMode");
			data.GmtCreate = _ctx.LongValue("QueryCallInPoolTransferConfig.Data.GmtCreate");

			List<QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data.QueryCallInPoolTransferConfig_DetailsItem> data_details = new List<QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data.QueryCallInPoolTransferConfig_DetailsItem>();
			for (int i = 0; i < _ctx.Length("QueryCallInPoolTransferConfig.Data.Details.Length"); i++) {
				QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data.QueryCallInPoolTransferConfig_DetailsItem detailsItem = new QueryCallInPoolTransferConfigResponse.QueryCallInPoolTransferConfig_Data.QueryCallInPoolTransferConfig_DetailsItem();
				detailsItem.Called = _ctx.StringValue("QueryCallInPoolTransferConfig.Data.Details["+ i +"].Called");

				data_details.Add(detailsItem);
			}
			data.Details = data_details;
			queryCallInPoolTransferConfigResponse.Data = data;
        
			return queryCallInPoolTransferConfigResponse;
        }
    }
}
