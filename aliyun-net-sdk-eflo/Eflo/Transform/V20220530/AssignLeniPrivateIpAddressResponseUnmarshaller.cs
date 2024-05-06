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
    public class AssignLeniPrivateIpAddressResponseUnmarshaller
    {
        public static AssignLeniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssignLeniPrivateIpAddressResponse assignLeniPrivateIpAddressResponse = new AssignLeniPrivateIpAddressResponse();

			assignLeniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			assignLeniPrivateIpAddressResponse.Code = _ctx.IntegerValue("AssignLeniPrivateIpAddress.Code");
			assignLeniPrivateIpAddressResponse.Message = _ctx.StringValue("AssignLeniPrivateIpAddress.Message");
			assignLeniPrivateIpAddressResponse.RequestId = _ctx.StringValue("AssignLeniPrivateIpAddress.RequestId");

			AssignLeniPrivateIpAddressResponse.AssignLeniPrivateIpAddress_Content content = new AssignLeniPrivateIpAddressResponse.AssignLeniPrivateIpAddress_Content();
			content.IpName = _ctx.StringValue("AssignLeniPrivateIpAddress.Content.IpName");
			content.ElasticNetworkInterfaceId = _ctx.StringValue("AssignLeniPrivateIpAddress.Content.ElasticNetworkInterfaceId");
			assignLeniPrivateIpAddressResponse.Content = content;
        
			return assignLeniPrivateIpAddressResponse;
        }
    }
}
