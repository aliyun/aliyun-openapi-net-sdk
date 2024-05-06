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
    public class UnassignLeniPrivateIpAddressResponseUnmarshaller
    {
        public static UnassignLeniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnassignLeniPrivateIpAddressResponse unassignLeniPrivateIpAddressResponse = new UnassignLeniPrivateIpAddressResponse();

			unassignLeniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			unassignLeniPrivateIpAddressResponse.Code = _ctx.IntegerValue("UnassignLeniPrivateIpAddress.Code");
			unassignLeniPrivateIpAddressResponse.Message = _ctx.StringValue("UnassignLeniPrivateIpAddress.Message");
			unassignLeniPrivateIpAddressResponse.RequestId = _ctx.StringValue("UnassignLeniPrivateIpAddress.RequestId");

			UnassignLeniPrivateIpAddressResponse.UnassignLeniPrivateIpAddress_Content content = new UnassignLeniPrivateIpAddressResponse.UnassignLeniPrivateIpAddress_Content();
			content.IpName = _ctx.StringValue("UnassignLeniPrivateIpAddress.Content.IpName");
			content.ElasticNetworkInterfaceId = _ctx.StringValue("UnassignLeniPrivateIpAddress.Content.ElasticNetworkInterfaceId");
			unassignLeniPrivateIpAddressResponse.Content = content;
        
			return unassignLeniPrivateIpAddressResponse;
        }
    }
}
