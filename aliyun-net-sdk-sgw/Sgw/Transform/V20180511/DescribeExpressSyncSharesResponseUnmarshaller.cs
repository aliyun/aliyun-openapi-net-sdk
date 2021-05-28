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
        public static DescribeExpressSyncSharesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExpressSyncSharesResponse describeExpressSyncSharesResponse = new DescribeExpressSyncSharesResponse();

			describeExpressSyncSharesResponse.HttpResponse = _ctx.HttpResponse;
			describeExpressSyncSharesResponse.RequestId = _ctx.StringValue("DescribeExpressSyncShares.RequestId");
			describeExpressSyncSharesResponse.Success = _ctx.BooleanValue("DescribeExpressSyncShares.Success");
			describeExpressSyncSharesResponse.Code = _ctx.StringValue("DescribeExpressSyncShares.Code");
			describeExpressSyncSharesResponse.Message = _ctx.StringValue("DescribeExpressSyncShares.Message");

			List<DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share> describeExpressSyncSharesResponse_shares = new List<DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share>();
			for (int i = 0; i < _ctx.Length("DescribeExpressSyncShares.Shares.Length"); i++) {
				DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share share = new DescribeExpressSyncSharesResponse.DescribeExpressSyncShares_Share();
				share.GatewayId = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayId");
				share.StorageBundleId = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].StorageBundleId");
				share.GatewayName = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayName");
				share.GatewayRegion = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].GatewayRegion");
				share.ShareName = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ShareName");
				share.ExpressSyncState = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ExpressSyncState");
				share.ExpressSyncId = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].ExpressSyncId");
				share.MnsQueue = _ctx.StringValue("DescribeExpressSyncShares.Shares["+ i +"].MnsQueue");
				share.SyncProgress = _ctx.IntegerValue("DescribeExpressSyncShares.Shares["+ i +"].SyncProgress");

				describeExpressSyncSharesResponse_shares.Add(share);
			}
			describeExpressSyncSharesResponse.Shares = describeExpressSyncSharesResponse_shares;
        
			return describeExpressSyncSharesResponse;
        }
    }
}
