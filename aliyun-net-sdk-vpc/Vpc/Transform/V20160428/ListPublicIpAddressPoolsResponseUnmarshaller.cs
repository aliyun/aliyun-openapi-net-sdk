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
    public class ListPublicIpAddressPoolsResponseUnmarshaller
    {
        public static ListPublicIpAddressPoolsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPublicIpAddressPoolsResponse listPublicIpAddressPoolsResponse = new ListPublicIpAddressPoolsResponse();

			listPublicIpAddressPoolsResponse.HttpResponse = _ctx.HttpResponse;
			listPublicIpAddressPoolsResponse.RequestId = _ctx.StringValue("ListPublicIpAddressPools.RequestId");
			listPublicIpAddressPoolsResponse.NextToken = _ctx.StringValue("ListPublicIpAddressPools.NextToken");
			listPublicIpAddressPoolsResponse.MaxResults = _ctx.IntegerValue("ListPublicIpAddressPools.MaxResults");
			listPublicIpAddressPoolsResponse.TotalCount = _ctx.IntegerValue("ListPublicIpAddressPools.TotalCount");

			List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool> listPublicIpAddressPoolsResponse_publicIpAddressPoolList = new List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool>();
			for (int i = 0; i < _ctx.Length("ListPublicIpAddressPools.PublicIpAddressPoolList.Length"); i++) {
				ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool publicIpAddressPool = new ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool();
				publicIpAddressPool.PublicIpAddressPoolId = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpAddressPoolId");
				publicIpAddressPool.RegionId = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].RegionId");
				publicIpAddressPool.CreationTime = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].CreationTime");
				publicIpAddressPool.Isp = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Isp");
				publicIpAddressPool.Name = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Name");
				publicIpAddressPool.Status = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Status");
				publicIpAddressPool.Description = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Description");
				publicIpAddressPool.TotalIpNum = _ctx.IntegerValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].TotalIpNum");
				publicIpAddressPool.UsedIpNum = _ctx.IntegerValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].UsedIpNum");
				publicIpAddressPool.IpAddressRemaining = _ctx.BooleanValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].IpAddressRemaining");
				publicIpAddressPool.UserType = _ctx.BooleanValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].UserType");
				publicIpAddressPool.OwnerId = _ctx.LongValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].OwnerId");
				publicIpAddressPool.ShareType = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].ShareType");
				publicIpAddressPool.ResourceGroupId = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].ResourceGroupId");

				List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_PublicIpCidrBlock> publicIpAddressPool_publicIpCidrBlockList = new List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_PublicIpCidrBlock>();
				for (int j = 0; j < _ctx.Length("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList.Length"); j++) {
					ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_PublicIpCidrBlock publicIpCidrBlock = new ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_PublicIpCidrBlock();
					publicIpCidrBlock.CidrBlock = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList["+ j +"].CidrBlock");
					publicIpCidrBlock.Status = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList["+ j +"].Status");
					publicIpCidrBlock.TotalIpNum = _ctx.IntegerValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList["+ j +"].TotalIpNum");
					publicIpCidrBlock.UsedIpNum = _ctx.IntegerValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList["+ j +"].UsedIpNum");
					publicIpCidrBlock.CreationTime = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].PublicIpCidrBlockList["+ j +"].CreationTime");

					publicIpAddressPool_publicIpCidrBlockList.Add(publicIpCidrBlock);
				}
				publicIpAddressPool.PublicIpCidrBlockList = publicIpAddressPool_publicIpCidrBlockList;

				List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_Tag> publicIpAddressPool_tags = new List<ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_Tag>();
				for (int j = 0; j < _ctx.Length("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Tags.Length"); j++) {
					ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_Tag tag = new ListPublicIpAddressPoolsResponse.ListPublicIpAddressPools_PublicIpAddressPool.ListPublicIpAddressPools_Tag();
					tag.Key = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListPublicIpAddressPools.PublicIpAddressPoolList["+ i +"].Tags["+ j +"].Value");

					publicIpAddressPool_tags.Add(tag);
				}
				publicIpAddressPool.Tags = publicIpAddressPool_tags;

				listPublicIpAddressPoolsResponse_publicIpAddressPoolList.Add(publicIpAddressPool);
			}
			listPublicIpAddressPoolsResponse.PublicIpAddressPoolList = listPublicIpAddressPoolsResponse_publicIpAddressPoolList;
        
			return listPublicIpAddressPoolsResponse;
        }
    }
}
