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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class RenewWebSiteInstanceResponseUnmarshaller
    {
        public static RenewWebSiteInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RenewWebSiteInstanceResponse renewWebSiteInstanceResponse = new RenewWebSiteInstanceResponse();

			renewWebSiteInstanceResponse.HttpResponse = _ctx.HttpResponse;
			renewWebSiteInstanceResponse.Code = _ctx.StringValue("RenewWebSiteInstance.Code");
			renewWebSiteInstanceResponse.Message = _ctx.StringValue("RenewWebSiteInstance.Message");
			renewWebSiteInstanceResponse.OrderId = _ctx.StringValue("RenewWebSiteInstance.OrderId");
			renewWebSiteInstanceResponse.InstanceId = _ctx.StringValue("RenewWebSiteInstance.InstanceId");
			renewWebSiteInstanceResponse.RequestId = _ctx.StringValue("RenewWebSiteInstance.RequestId");

			List<string> renewWebSiteInstanceResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("RenewWebSiteInstance.InstanceIds.Length"); i++) {
				renewWebSiteInstanceResponse_instanceIds.Add(_ctx.StringValue("RenewWebSiteInstance.InstanceIds["+ i +"]"));
			}
			renewWebSiteInstanceResponse.InstanceIds = renewWebSiteInstanceResponse_instanceIds;
        
			return renewWebSiteInstanceResponse;
        }
    }
}
