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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class GetMySuccessAppliesResponseUnmarshaller
    {
        public static GetMySuccessAppliesResponse Unmarshall(UnmarshallerContext context)
        {
			GetMySuccessAppliesResponse getMySuccessAppliesResponse = new GetMySuccessAppliesResponse();

			getMySuccessAppliesResponse.HttpResponse = context.HttpResponse;
			getMySuccessAppliesResponse.RequestId = context.StringValue("GetMySuccessApplies.RequestId");

			List<GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem> getMySuccessAppliesResponse_result = new List<GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem>();
			for (int i = 0; i < context.Length("GetMySuccessApplies.Result.Length"); i++) {
				GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem resultItem = new GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem();
				resultItem.Bizid = context.StringValue("GetMySuccessApplies.Result["+ i +"].Bizid");
				resultItem.NodeNumber = context.IntegerValue("GetMySuccessApplies.Result["+ i +"].NodeNumber");
				resultItem.BlockHeight = context.IntegerValue("GetMySuccessApplies.Result["+ i +"].BlockHeight");
				resultItem.TransactionSum = context.IntegerValue("GetMySuccessApplies.Result["+ i +"].TransactionSum");
				resultItem.CreateTime = context.LongValue("GetMySuccessApplies.Result["+ i +"].CreateTime");
				resultItem.AbnormalNodes = context.IntegerValue("GetMySuccessApplies.Result["+ i +"].AbnormalNodes");
				resultItem.Version = context.StringValue("GetMySuccessApplies.Result["+ i +"].Version");
				resultItem.IsRole = context.BooleanValue("GetMySuccessApplies.Result["+ i +"].IsRole");
				resultItem.Normal = context.BooleanValue("GetMySuccessApplies.Result["+ i +"].Normal");
				resultItem.Name = context.StringValue("GetMySuccessApplies.Result["+ i +"].Name");

				List<GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem.GetMySuccessApplies_NodeInfoListItem> resultItem_nodeInfoList = new List<GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem.GetMySuccessApplies_NodeInfoListItem>();
				for (int j = 0; j < context.Length("GetMySuccessApplies.Result["+ i +"].NodeInfoList.Length"); j++) {
					GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem.GetMySuccessApplies_NodeInfoListItem nodeInfoListItem = new GetMySuccessAppliesResponse.GetMySuccessApplies_ResultItem.GetMySuccessApplies_NodeInfoListItem();
					nodeInfoListItem.NodeName = context.StringValue("GetMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].NodeName");
					nodeInfoListItem.Status = context.BooleanValue("GetMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].Status");
					nodeInfoListItem.Version = context.StringValue("GetMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].Version");
					nodeInfoListItem.BlockHeight = context.LongValue("GetMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].BlockHeight");

					resultItem_nodeInfoList.Add(nodeInfoListItem);
				}
				resultItem.NodeInfoList = resultItem_nodeInfoList;

				getMySuccessAppliesResponse_result.Add(resultItem);
			}
			getMySuccessAppliesResponse.Result = getMySuccessAppliesResponse_result;
        
			return getMySuccessAppliesResponse;
        }
    }
}