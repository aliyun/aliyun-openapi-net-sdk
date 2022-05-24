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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListGrantVSwitchEnisResponseUnmarshaller
    {
        public static ListGrantVSwitchEnisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGrantVSwitchEnisResponse listGrantVSwitchEnisResponse = new ListGrantVSwitchEnisResponse();

			listGrantVSwitchEnisResponse.HttpResponse = _ctx.HttpResponse;
			listGrantVSwitchEnisResponse.RequestId = _ctx.StringValue("ListGrantVSwitchEnis.RequestId");
			listGrantVSwitchEnisResponse.TotalCount = _ctx.StringValue("ListGrantVSwitchEnis.TotalCount");

			List<ListGrantVSwitchEnisResponse.ListGrantVSwitchEnis_GrantVSwitchEni> listGrantVSwitchEnisResponse_grantVSwitchEnis = new List<ListGrantVSwitchEnisResponse.ListGrantVSwitchEnis_GrantVSwitchEni>();
			for (int i = 0; i < _ctx.Length("ListGrantVSwitchEnis.GrantVSwitchEnis.Length"); i++) {
				ListGrantVSwitchEnisResponse.ListGrantVSwitchEnis_GrantVSwitchEni grantVSwitchEni = new ListGrantVSwitchEnisResponse.ListGrantVSwitchEnis_GrantVSwitchEni();
				grantVSwitchEni.VpcId = _ctx.StringValue("ListGrantVSwitchEnis.GrantVSwitchEnis["+ i +"].VpcId");
				grantVSwitchEni.VSwitchId = _ctx.StringValue("ListGrantVSwitchEnis.GrantVSwitchEnis["+ i +"].VSwitchId");
				grantVSwitchEni.NetworkInterfaceId = _ctx.StringValue("ListGrantVSwitchEnis.GrantVSwitchEnis["+ i +"].NetworkInterfaceId");
				grantVSwitchEni.Description = _ctx.StringValue("ListGrantVSwitchEnis.GrantVSwitchEnis["+ i +"].Description");
				grantVSwitchEni.TransitRouterFlag = _ctx.BooleanValue("ListGrantVSwitchEnis.GrantVSwitchEnis["+ i +"].TransitRouterFlag");

				listGrantVSwitchEnisResponse_grantVSwitchEnis.Add(grantVSwitchEni);
			}
			listGrantVSwitchEnisResponse.GrantVSwitchEnis = listGrantVSwitchEnisResponse_grantVSwitchEnis;
        
			return listGrantVSwitchEnisResponse;
        }
    }
}
