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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeExpressSyncSharesResponseUnmarshaller
    {
        public static DescribeExpressSyncSharesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExpressSyncSharesResponse describeExpressSyncSharesResponse = new DescribeExpressSyncSharesResponse();

			describeExpressSyncSharesResponse.HttpResponse = context.HttpResponse;
			describeExpressSyncSharesResponse.RequestId = context.StringValue("DescribeExpressSyncShares.RequestId");
			describeExpressSyncSharesResponse.Success = context.BooleanValue("DescribeExpressSyncShares.Success");
			describeExpressSyncSharesResponse.Code = context.StringValue("DescribeExpressSyncShares.Code");
			describeExpressSyncSharesResponse.Message = context.StringValue("DescribeExpressSyncShares.Message");

			List<DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share> describeExpressSyncSharesResponse_shares = new List<DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share>();
			for (int i = 0; i < context.Length("DescribeExpressSyncShares.Shares.Length"); i++) {
				DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share share = new DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share();
				share.GatewayId = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayId");
				share.StorageBundleId = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].StorageBundleId");
				share.GatewayName = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayName");
				share.GatewayRegion = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayRegion");
				share.ShareName = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ShareName");
				share.ExpressSyncState = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ExpressSyncState");
				share.ExpressSyncId = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ExpressSyncId");
				share.MnsQueue = context.StringValue("DescribeExpressSyncShares.Shares["+ i +"].MnsQueue");
				share.SyncProgress = context.IntegerValue("DescribeExpressSyncShares.Shares["+ i +"].SyncProgress");

				describeExpressSyncSharesResponse_shares.Add(share);
			}
			describeExpressSyncSharesResponse.Shares = describeExpressSyncSharesResponse_shares;
        
			return describeExpressSyncSharesResponse;
        }
    }
}
