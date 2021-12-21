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
    public class ListGrantVSwitchesToCenResponseUnmarshaller
    {
        public static ListGrantVSwitchesToCenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGrantVSwitchesToCenResponse listGrantVSwitchesToCenResponse = new ListGrantVSwitchesToCenResponse();

			listGrantVSwitchesToCenResponse.HttpResponse = _ctx.HttpResponse;
			listGrantVSwitchesToCenResponse.PageSize = _ctx.IntegerValue("ListGrantVSwitchesToCen.PageSize");
			listGrantVSwitchesToCenResponse.RequestId = _ctx.StringValue("ListGrantVSwitchesToCen.RequestId");
			listGrantVSwitchesToCenResponse.PageNumber = _ctx.IntegerValue("ListGrantVSwitchesToCen.PageNumber");
			listGrantVSwitchesToCenResponse.TotalCount = _ctx.IntegerValue("ListGrantVSwitchesToCen.TotalCount");

			List<ListGrantVSwitchesToCenResponse.ListGrantVSwitchesToCen_VSwitch> listGrantVSwitchesToCenResponse_vSwitches = new List<ListGrantVSwitchesToCenResponse.ListGrantVSwitchesToCen_VSwitch>();
			for (int i = 0; i < _ctx.Length("ListGrantVSwitchesToCen.VSwitches.Length"); i++) {
				ListGrantVSwitchesToCenResponse.ListGrantVSwitchesToCen_VSwitch vSwitch = new ListGrantVSwitchesToCenResponse.ListGrantVSwitchesToCen_VSwitch();
				vSwitch.VpcId = _ctx.StringValue("ListGrantVSwitchesToCen.VSwitches["+ i +"].VpcId");
				vSwitch.ZoneId = _ctx.StringValue("ListGrantVSwitchesToCen.VSwitches["+ i +"].ZoneId");
				vSwitch.VSwitchId = _ctx.StringValue("ListGrantVSwitchesToCen.VSwitches["+ i +"].VSwitchId");

				listGrantVSwitchesToCenResponse_vSwitches.Add(vSwitch);
			}
			listGrantVSwitchesToCenResponse.VSwitches = listGrantVSwitchesToCenResponse_vSwitches;
        
			return listGrantVSwitchesToCenResponse;
        }
    }
}
