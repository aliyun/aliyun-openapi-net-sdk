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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetSubnetResponseUnmarshaller
    {
        public static GetSubnetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSubnetResponse getSubnetResponse = new GetSubnetResponse();

			getSubnetResponse.HttpResponse = _ctx.HttpResponse;
			getSubnetResponse.Code = _ctx.IntegerValue("GetSubnet.Code");
			getSubnetResponse.Message = _ctx.StringValue("GetSubnet.Message");
			getSubnetResponse.RequestId = _ctx.StringValue("GetSubnet.RequestId");

			GetSubnetResponse.GetSubnet_Content content = new GetSubnetResponse.GetSubnet_Content();
			content.Id = _ctx.LongValue("GetSubnet.Content.Id");
			content.GmtCreate = _ctx.StringValue("GetSubnet.Content.GmtCreate");
			content.GmtModified = _ctx.StringValue("GetSubnet.Content.GmtModified");
			content.TenantId = _ctx.StringValue("GetSubnet.Content.TenantId");
			content.RegionId = _ctx.StringValue("GetSubnet.Content.RegionId");
			content.ZoneId = _ctx.StringValue("GetSubnet.Content.ZoneId");
			content.SubnetId = _ctx.StringValue("GetSubnet.Content.SubnetId");
			content.Name = _ctx.StringValue("GetSubnet.Content.Name");
			content.Cidr = _ctx.StringValue("GetSubnet.Content.Cidr");
			content.Description = _ctx.StringValue("GetSubnet.Content.Description");
			content.VpdId = _ctx.StringValue("GetSubnet.Content.VpdId");
			content.Type = _ctx.StringValue("GetSubnet.Content.Type");
			content.Status = _ctx.StringValue("GetSubnet.Content.Status");
			content.Message = _ctx.StringValue("GetSubnet.Content.Message");
			content.NcCount = _ctx.LongValue("GetSubnet.Content.NcCount");
			content.LbCount = _ctx.LongValue("GetSubnet.Content.LbCount");

			GetSubnetResponse.GetSubnet_Content.GetSubnet_VpdBaseInfo vpdBaseInfo = new GetSubnetResponse.GetSubnet_Content.GetSubnet_VpdBaseInfo();
			vpdBaseInfo.VpdId = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.VpdId");
			vpdBaseInfo.Name = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.Name");
			vpdBaseInfo.Cidr = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.Cidr");
			vpdBaseInfo.GmtCreate = _ctx.StringValue("GetSubnet.Content.VpdBaseInfo.GmtCreate");
			content.VpdBaseInfo = vpdBaseInfo;
			getSubnetResponse.Content = content;
        
			return getSubnetResponse;
        }
    }
}
