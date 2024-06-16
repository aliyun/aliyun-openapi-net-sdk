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
    public class GetLniPrivateIpAddressResponseUnmarshaller
    {
        public static GetLniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLniPrivateIpAddressResponse getLniPrivateIpAddressResponse = new GetLniPrivateIpAddressResponse();

			getLniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			getLniPrivateIpAddressResponse.Code = _ctx.IntegerValue("GetLniPrivateIpAddress.Code");
			getLniPrivateIpAddressResponse.Message = _ctx.StringValue("GetLniPrivateIpAddress.Message");
			getLniPrivateIpAddressResponse.RequestId = _ctx.StringValue("GetLniPrivateIpAddress.RequestId");

			GetLniPrivateIpAddressResponse.GetLniPrivateIpAddress_Content content = new GetLniPrivateIpAddressResponse.GetLniPrivateIpAddress_Content();
			content.RegionId = _ctx.StringValue("GetLniPrivateIpAddress.Content.RegionId");
			content.GmtCreate = _ctx.StringValue("GetLniPrivateIpAddress.Content.GmtCreate");
			content.NetworkInterfaceId = _ctx.StringValue("GetLniPrivateIpAddress.Content.NetworkInterfaceId");
			content.IpName = _ctx.StringValue("GetLniPrivateIpAddress.Content.IpName");
			content.PrivateIpAddress = _ctx.StringValue("GetLniPrivateIpAddress.Content.PrivateIpAddress");
			content.IpAddressMac = _ctx.StringValue("GetLniPrivateIpAddress.Content.IpAddressMac");
			content.Status = _ctx.StringValue("GetLniPrivateIpAddress.Content.Status");
			content.Description = _ctx.StringValue("GetLniPrivateIpAddress.Content.Description");
			content.Message = _ctx.StringValue("GetLniPrivateIpAddress.Content.Message");
			getLniPrivateIpAddressResponse.Content = content;
        
			return getLniPrivateIpAddressResponse;
        }
    }
}
