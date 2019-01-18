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
    public class DescribeBlockchainInfoResponseUnmarshaller
    {
        public static DescribeBlockchainInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBlockchainInfoResponse describeBlockchainInfoResponse = new DescribeBlockchainInfoResponse();

			describeBlockchainInfoResponse.HttpResponse = context.HttpResponse;
			describeBlockchainInfoResponse.RequestId = context.StringValue("DescribeBlockchainInfo.RequestId");

			DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result result = new DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result();
			result.Bizid = context.StringValue("DescribeBlockchainInfo.Result.Bizid");
			result.NodeNumber = context.IntegerValue("DescribeBlockchainInfo.Result.NodeNumber");
			result.BlockHeight = context.IntegerValue("DescribeBlockchainInfo.Result.BlockHeight");
			result.TransactionSum = context.IntegerValue("DescribeBlockchainInfo.Result.TransactionSum");
			result.CreateTime = context.LongValue("DescribeBlockchainInfo.Result.CreateTime");
			result.AbnormalNodes = context.IntegerValue("DescribeBlockchainInfo.Result.AbnormalNodes");
			result.Version = context.StringValue("DescribeBlockchainInfo.Result.Version");
			result.IsRole = context.BooleanValue("DescribeBlockchainInfo.Result.IsRole");
			result.Normal = context.BooleanValue("DescribeBlockchainInfo.Result.Normal");

			List<DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result.DescribeBlockchainInfo_NodeInfoListItem> result_nodeInfoList = new List<DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result.DescribeBlockchainInfo_NodeInfoListItem>();
			for (int i = 0; i < context.Length("DescribeBlockchainInfo.Result.NodeInfoList.Length"); i++) {
				DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result.DescribeBlockchainInfo_NodeInfoListItem nodeInfoListItem = new DescribeBlockchainInfoResponse.DescribeBlockchainInfo_Result.DescribeBlockchainInfo_NodeInfoListItem();
				nodeInfoListItem.NodeName = context.StringValue("DescribeBlockchainInfo.Result.NodeInfoList["+ i +"].NodeName");
				nodeInfoListItem.Status = context.BooleanValue("DescribeBlockchainInfo.Result.NodeInfoList["+ i +"].Status");
				nodeInfoListItem.Version = context.StringValue("DescribeBlockchainInfo.Result.NodeInfoList["+ i +"].Version");
				nodeInfoListItem.BlockHeight = context.LongValue("DescribeBlockchainInfo.Result.NodeInfoList["+ i +"].BlockHeight");

				result_nodeInfoList.Add(nodeInfoListItem);
			}
			result.NodeInfoList = result_nodeInfoList;
			describeBlockchainInfoResponse.Result = result;
        
			return describeBlockchainInfoResponse;
        }
    }
}