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
    public class GetBlockchainInfoResponseUnmarshaller
    {
        public static GetBlockchainInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetBlockchainInfoResponse getBlockchainInfoResponse = new GetBlockchainInfoResponse();

			getBlockchainInfoResponse.HttpResponse = context.HttpResponse;
			getBlockchainInfoResponse.RequestId = context.StringValue("GetBlockchainInfo.RequestId");

			GetBlockchainInfoResponse.GetBlockchainInfo_Result result = new GetBlockchainInfoResponse.GetBlockchainInfo_Result();
			result.Bizid = context.StringValue("GetBlockchainInfo.Result.Bizid");
			result.NodeNumber = context.IntegerValue("GetBlockchainInfo.Result.NodeNumber");
			result.BlockHeight = context.IntegerValue("GetBlockchainInfo.Result.BlockHeight");
			result.TransactionSum = context.IntegerValue("GetBlockchainInfo.Result.TransactionSum");
			result.CreateTime = context.LongValue("GetBlockchainInfo.Result.CreateTime");
			result.AbnormalNodes = context.IntegerValue("GetBlockchainInfo.Result.AbnormalNodes");
			result.Version = context.StringValue("GetBlockchainInfo.Result.Version");
			result.IsRole = context.BooleanValue("GetBlockchainInfo.Result.IsRole");
			result.Normal = context.BooleanValue("GetBlockchainInfo.Result.Normal");

			List<GetBlockchainInfoResponse.GetBlockchainInfo_Result.GetBlockchainInfo_NodeInfoListItem> result_nodeInfoList = new List<GetBlockchainInfoResponse.GetBlockchainInfo_Result.GetBlockchainInfo_NodeInfoListItem>();
			for (int i = 0; i < context.Length("GetBlockchainInfo.Result.NodeInfoList.Length"); i++) {
				GetBlockchainInfoResponse.GetBlockchainInfo_Result.GetBlockchainInfo_NodeInfoListItem nodeInfoListItem = new GetBlockchainInfoResponse.GetBlockchainInfo_Result.GetBlockchainInfo_NodeInfoListItem();
				nodeInfoListItem.NodeName = context.StringValue("GetBlockchainInfo.Result.NodeInfoList["+ i +"].NodeName");
				nodeInfoListItem.Status = context.BooleanValue("GetBlockchainInfo.Result.NodeInfoList["+ i +"].Status");
				nodeInfoListItem.Version = context.StringValue("GetBlockchainInfo.Result.NodeInfoList["+ i +"].Version");
				nodeInfoListItem.BlockHeight = context.LongValue("GetBlockchainInfo.Result.NodeInfoList["+ i +"].BlockHeight");

				result_nodeInfoList.Add(nodeInfoListItem);
			}
			result.NodeInfoList = result_nodeInfoList;
			getBlockchainInfoResponse.Result = result;
        
			return getBlockchainInfoResponse;
        }
    }
}