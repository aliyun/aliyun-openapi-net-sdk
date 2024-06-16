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
    public class UpdateLeniPrivateIpAddressResponseUnmarshaller
    {
        public static UpdateLeniPrivateIpAddressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateLeniPrivateIpAddressResponse updateLeniPrivateIpAddressResponse = new UpdateLeniPrivateIpAddressResponse();

			updateLeniPrivateIpAddressResponse.HttpResponse = _ctx.HttpResponse;
			updateLeniPrivateIpAddressResponse.Code = _ctx.IntegerValue("UpdateLeniPrivateIpAddress.Code");
			updateLeniPrivateIpAddressResponse.Message = _ctx.StringValue("UpdateLeniPrivateIpAddress.Message");
			updateLeniPrivateIpAddressResponse.RequestId = _ctx.StringValue("UpdateLeniPrivateIpAddress.RequestId");

			UpdateLeniPrivateIpAddressResponse.UpdateLeniPrivateIpAddress_Content content = new UpdateLeniPrivateIpAddressResponse.UpdateLeniPrivateIpAddress_Content();
			content.ElasticNetworkInterfaceId = _ctx.StringValue("UpdateLeniPrivateIpAddress.Content.ElasticNetworkInterfaceId");
			content.IpName = _ctx.StringValue("UpdateLeniPrivateIpAddress.Content.IpName");
			updateLeniPrivateIpAddressResponse.Content = content;
        
			return updateLeniPrivateIpAddressResponse;
        }
    }
}
