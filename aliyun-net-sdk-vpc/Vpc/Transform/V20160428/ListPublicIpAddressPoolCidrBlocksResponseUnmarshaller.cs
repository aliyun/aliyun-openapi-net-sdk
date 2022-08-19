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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListPublicIpAddressPoolCidrBlocksResponseUnmarshaller
    {
        public static ListPublicIpAddressPoolCidrBlocksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPublicIpAddressPoolCidrBlocksResponse listPublicIpAddressPoolCidrBlocksResponse = new ListPublicIpAddressPoolCidrBlocksResponse();

			listPublicIpAddressPoolCidrBlocksResponse.HttpResponse = _ctx.HttpResponse;
			listPublicIpAddressPoolCidrBlocksResponse.RequestId = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.RequestId");
			listPublicIpAddressPoolCidrBlocksResponse.NextToken = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.NextToken");
			listPublicIpAddressPoolCidrBlocksResponse.MaxResults = _ctx.IntegerValue("ListPublicIpAddressPoolCidrBlocks.MaxResults");
			listPublicIpAddressPoolCidrBlocksResponse.TotalCount = _ctx.IntegerValue("ListPublicIpAddressPoolCidrBlocks.TotalCount");

			List<ListPublicIpAddressPoolCidrBlocksResponse.ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock> listPublicIpAddressPoolCidrBlocksResponse_publicIpPoolCidrBlockList = new List<ListPublicIpAddressPoolCidrBlocksResponse.ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock>();
			for (int i = 0; i < _ctx.Length("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList.Length"); i++) {
				ListPublicIpAddressPoolCidrBlocksResponse.ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock publicIpPoolCidrBlock = new ListPublicIpAddressPoolCidrBlocksResponse.ListPublicIpAddressPoolCidrBlocks_PublicIpPoolCidrBlock();
				publicIpPoolCidrBlock.PublicIpAddressPoolId = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].PublicIpAddressPoolId");
				publicIpPoolCidrBlock.CidrBlock = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].CidrBlock");
				publicIpPoolCidrBlock.CreationTime = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].CreationTime");
				publicIpPoolCidrBlock.Status = _ctx.StringValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].Status");
				publicIpPoolCidrBlock.UsedIpNum = _ctx.IntegerValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].UsedIpNum");
				publicIpPoolCidrBlock.TotalIpNum = _ctx.IntegerValue("ListPublicIpAddressPoolCidrBlocks.PublicIpPoolCidrBlockList["+ i +"].TotalIpNum");

				listPublicIpAddressPoolCidrBlocksResponse_publicIpPoolCidrBlockList.Add(publicIpPoolCidrBlock);
			}
			listPublicIpAddressPoolCidrBlocksResponse.PublicIpPoolCidrBlockList = listPublicIpAddressPoolCidrBlocksResponse_publicIpPoolCidrBlockList;
        
			return listPublicIpAddressPoolCidrBlocksResponse;
        }
    }
}
