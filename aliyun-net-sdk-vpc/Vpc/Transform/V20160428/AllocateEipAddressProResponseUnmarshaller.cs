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
    public class AllocateEipAddressProResponseUnmarshaller
    {
        public static AllocateEipAddressProResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AllocateEipAddressProResponse allocateEipAddressProResponse = new AllocateEipAddressProResponse();

			allocateEipAddressProResponse.HttpResponse = _ctx.HttpResponse;
			allocateEipAddressProResponse.RequestId = _ctx.StringValue("AllocateEipAddressPro.RequestId");
			allocateEipAddressProResponse.AllocationId = _ctx.StringValue("AllocateEipAddressPro.AllocationId");
			allocateEipAddressProResponse.EipAddress = _ctx.StringValue("AllocateEipAddressPro.EipAddress");
			allocateEipAddressProResponse.OrderId = _ctx.LongValue("AllocateEipAddressPro.OrderId");
			allocateEipAddressProResponse.ResourceGroupId = _ctx.StringValue("AllocateEipAddressPro.ResourceGroupId");
        
			return allocateEipAddressProResponse;
        }
    }
}
