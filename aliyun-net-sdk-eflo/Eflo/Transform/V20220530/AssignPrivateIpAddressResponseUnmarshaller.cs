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
    public class AssignPrivateIpAddressResponseUnmarshaller
    {
        public static AssignPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AssignPrivateIpAddressResponse assignPrivateIpAddressResponse = new AssignPrivateIpAddressResponse();

			assignPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			assignPrivateIpAddressResponse.Code = _ctx.IntegerValue("AssignPrivateIpAddress.Code");
			assignPrivateIpAddressResponse.Message = _ctx.StringValue("AssignPrivateIpAddress.Message");
			assignPrivateIpAddressResponse.RequestId = _ctx.StringValue("AssignPrivateIpAddress.RequestId");

			AssignPrivateIpAddressResponse.AssignPrivateIpAddress_Content content = new AssignPrivateIpAddressResponse.AssignPrivateIpAddress_Content();
			content.NetworkInterfaceId = _ctx.StringValue("AssignPrivateIpAddress.Content.NetworkInterfaceId");
			content.IpName = _ctx.StringValue("AssignPrivateIpAddress.Content.IpName");
			assignPrivateIpAddressResponse.Content = content;
        
			return assignPrivateIpAddressResponse;
        }
    }
}
