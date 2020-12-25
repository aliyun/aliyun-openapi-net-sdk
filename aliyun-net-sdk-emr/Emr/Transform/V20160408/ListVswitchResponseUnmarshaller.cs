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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListVswitchResponseUnmarshaller
    {
        public static ListVswitchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVswitchResponse listVswitchResponse = new ListVswitchResponse();

			listVswitchResponse.HttpResponse = _ctx.HttpResponse;
			listVswitchResponse.RequestId = _ctx.StringValue("ListVswitch.RequestId");

			List<ListVswitchResponse.ListVswitch_Vswitch> listVswitchResponse_vswitchList = new List<ListVswitchResponse.ListVswitch_Vswitch>();
			for (int i = 0; i < _ctx.Length("ListVswitch.VswitchList.Length"); i++) {
				ListVswitchResponse.ListVswitch_Vswitch vswitch = new ListVswitchResponse.ListVswitch_Vswitch();
				vswitch.VSwitchId = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].VSwitchId");
				vswitch.VpcId = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].VpcId");
				vswitch.Status = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].Status");
				vswitch.CidrBlock = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].CidrBlock");
				vswitch.ZoneId = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].ZoneId");
				vswitch.AvailableIpAddressCount = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].AvailableIpAddressCount");
				vswitch.Description = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].Description");
				vswitch.VSwitchName = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].VSwitchName");
				vswitch.CreationTime = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].CreationTime");
				vswitch.IsDefault = _ctx.BooleanValue("ListVswitch.VswitchList["+ i +"].IsDefault");
				vswitch.ResourceGroupId = _ctx.StringValue("ListVswitch.VswitchList["+ i +"].ResourceGroupId");

				listVswitchResponse_vswitchList.Add(vswitch);
			}
			listVswitchResponse.VswitchList = listVswitchResponse_vswitchList;
        
			return listVswitchResponse;
        }
    }
}
