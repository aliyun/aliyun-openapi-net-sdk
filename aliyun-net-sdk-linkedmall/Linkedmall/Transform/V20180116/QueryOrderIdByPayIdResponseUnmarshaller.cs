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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryOrderIdByPayIdResponseUnmarshaller
    {
        public static QueryOrderIdByPayIdResponse Unmarshall(UnmarshallerContext context)
        {
			QueryOrderIdByPayIdResponse queryOrderIdByPayIdResponse = new QueryOrderIdByPayIdResponse();

			queryOrderIdByPayIdResponse.HttpResponse = context.HttpResponse;
			queryOrderIdByPayIdResponse.RequestId = context.StringValue("QueryOrderIdByPayId.RequestId");
			queryOrderIdByPayIdResponse.Code = context.StringValue("QueryOrderIdByPayId.Code");
			queryOrderIdByPayIdResponse.Message = context.StringValue("QueryOrderIdByPayId.Message");

			List<QueryOrderIdByPayIdResponse.QueryOrderIdByPayId_LmOrderIdsItem> queryOrderIdByPayIdResponse_lmOrderIds = new List<QueryOrderIdByPayIdResponse.QueryOrderIdByPayId_LmOrderIdsItem>();
			for (int i = 0; i < context.Length("QueryOrderIdByPayId.LmOrderIds.Length"); i++) {
				QueryOrderIdByPayIdResponse.QueryOrderIdByPayId_LmOrderIdsItem lmOrderIdsItem = new QueryOrderIdByPayIdResponse.QueryOrderIdByPayId_LmOrderIdsItem();
				lmOrderIdsItem.LmOrderId = context.LongValue("QueryOrderIdByPayId.LmOrderIds["+ i +"].LmOrderId");

				queryOrderIdByPayIdResponse_lmOrderIds.Add(lmOrderIdsItem);
			}
			queryOrderIdByPayIdResponse.LmOrderIds = queryOrderIdByPayIdResponse_lmOrderIds;
        
			return queryOrderIdByPayIdResponse;
        }
    }
}
