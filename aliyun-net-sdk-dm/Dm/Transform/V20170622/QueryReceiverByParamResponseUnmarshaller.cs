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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class QueryReceiverByParamResponseUnmarshaller
    {
        public static QueryReceiverByParamResponse Unmarshall(UnmarshallerContext context)
        {
			QueryReceiverByParamResponse queryReceiverByParamResponse = new QueryReceiverByParamResponse();

			queryReceiverByParamResponse.HttpResponse = context.HttpResponse;
			queryReceiverByParamResponse.RequestId = context.StringValue("QueryReceiverByParam.RequestId");
			queryReceiverByParamResponse.TotalCount = context.IntegerValue("QueryReceiverByParam.TotalCount");
			queryReceiverByParamResponse.NextStart = context.StringValue("QueryReceiverByParam.NextStart");
			queryReceiverByParamResponse.PageSize = context.IntegerValue("QueryReceiverByParam.PageSize");

			List<QueryReceiverByParamResponse.QueryReceiverByParam_Receiver> queryReceiverByParamResponse_data = new List<QueryReceiverByParamResponse.QueryReceiverByParam_Receiver>();
			for (int i = 0; i < context.Length("QueryReceiverByParam.Data.Length"); i++) {
				QueryReceiverByParamResponse.QueryReceiverByParam_Receiver receiver = new QueryReceiverByParamResponse.QueryReceiverByParam_Receiver();
				receiver.ReceiverId = context.StringValue("QueryReceiverByParam.Data["+ i +"].ReceiverId");
				receiver.ReceiversName = context.StringValue("QueryReceiverByParam.Data["+ i +"].ReceiversName");
				receiver.Count = context.StringValue("QueryReceiverByParam.Data["+ i +"].Count");
				receiver.ReceiversAlias = context.StringValue("QueryReceiverByParam.Data["+ i +"].ReceiversAlias");
				receiver.Desc = context.StringValue("QueryReceiverByParam.Data["+ i +"].Desc");
				receiver.ReceiversStatus = context.StringValue("QueryReceiverByParam.Data["+ i +"].ReceiversStatus");
				receiver.CreateTime = context.StringValue("QueryReceiverByParam.Data["+ i +"].CreateTime");
				receiver.UtcCreateTime = context.LongValue("QueryReceiverByParam.Data["+ i +"].UtcCreateTime");

				queryReceiverByParamResponse_data.Add(receiver);
			}
			queryReceiverByParamResponse.Data = queryReceiverByParamResponse_data;
        
			return queryReceiverByParamResponse;
        }
    }
}
