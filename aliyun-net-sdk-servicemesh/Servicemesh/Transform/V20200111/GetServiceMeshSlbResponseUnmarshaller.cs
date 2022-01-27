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
using Aliyun.Acs.servicemesh.Model.V20200111;

namespace Aliyun.Acs.servicemesh.Transform.V20200111
{
    public class GetServiceMeshSlbResponseUnmarshaller
    {
        public static GetServiceMeshSlbResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceMeshSlbResponse getServiceMeshSlbResponse = new GetServiceMeshSlbResponse();

			getServiceMeshSlbResponse.HttpResponse = _ctx.HttpResponse;
			getServiceMeshSlbResponse.RequestId = _ctx.StringValue("GetServiceMeshSlb.RequestId");

			List<GetServiceMeshSlbResponse.GetServiceMeshSlb_SLBInfo> getServiceMeshSlbResponse_data = new List<GetServiceMeshSlbResponse.GetServiceMeshSlb_SLBInfo>();
			for (int i = 0; i < _ctx.Length("GetServiceMeshSlb.Data.Length"); i++) {
				GetServiceMeshSlbResponse.GetServiceMeshSlb_SLBInfo sLBInfo = new GetServiceMeshSlbResponse.GetServiceMeshSlb_SLBInfo();
				sLBInfo.LoadBalancerId = _ctx.StringValue("GetServiceMeshSlb.Data["+ i +"].LoadBalancerId");
				sLBInfo.Status = _ctx.StringValue("GetServiceMeshSlb.Data["+ i +"].Status");
				sLBInfo.ServerHealthStatus = _ctx.StringValue("GetServiceMeshSlb.Data["+ i +"].ServerHealthStatus");

				getServiceMeshSlbResponse_data.Add(sLBInfo);
			}
			getServiceMeshSlbResponse.Data = getServiceMeshSlbResponse_data;
        
			return getServiceMeshSlbResponse;
        }
    }
}
