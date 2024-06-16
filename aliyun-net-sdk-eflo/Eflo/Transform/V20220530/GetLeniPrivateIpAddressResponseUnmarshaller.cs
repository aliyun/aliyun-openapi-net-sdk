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
    public class GetLeniPrivateIpAddressResponseUnmarshaller
    {
        public static GetLeniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLeniPrivateIpAddressResponse getLeniPrivateIpAddressResponse = new GetLeniPrivateIpAddressResponse();

			getLeniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			getLeniPrivateIpAddressResponse.Code = _ctx.IntegerValue("GetLeniPrivateIpAddress.Code");
			getLeniPrivateIpAddressResponse.Message = _ctx.StringValue("GetLeniPrivateIpAddress.Message");
			getLeniPrivateIpAddressResponse.RequestId = _ctx.StringValue("GetLeniPrivateIpAddress.RequestId");

			GetLeniPrivateIpAddressResponse.GetLeniPrivateIpAddress_Content content = new GetLeniPrivateIpAddressResponse.GetLeniPrivateIpAddress_Content();
			content.ElasticNetworkInterfaceId = _ctx.StringValue("GetLeniPrivateIpAddress.Content.ElasticNetworkInterfaceId");
			content.RegionId = _ctx.StringValue("GetLeniPrivateIpAddress.Content.RegionId");
			content.GmtCreate = _ctx.StringValue("GetLeniPrivateIpAddress.Content.GmtCreate");
			content.GmtModified = _ctx.StringValue("GetLeniPrivateIpAddress.Content.GmtModified");
			content.IpName = _ctx.StringValue("GetLeniPrivateIpAddress.Content.IpName");
			content.PrivateIpAddress = _ctx.StringValue("GetLeniPrivateIpAddress.Content.PrivateIpAddress");
			content.Status = _ctx.StringValue("GetLeniPrivateIpAddress.Content.Status");
			content.Description = _ctx.StringValue("GetLeniPrivateIpAddress.Content.Description");
			content.Message = _ctx.StringValue("GetLeniPrivateIpAddress.Content.Message");
			getLeniPrivateIpAddressResponse.Content = content;
        
			return getLeniPrivateIpAddressResponse;
        }
    }
}
