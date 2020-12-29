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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListCloudMetricProfilingsResponseUnmarshaller
    {
        public static ListCloudMetricProfilingsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCloudMetricProfilingsResponse listCloudMetricProfilingsResponse = new ListCloudMetricProfilingsResponse();

			listCloudMetricProfilingsResponse.HttpResponse = _ctx.HttpResponse;
			listCloudMetricProfilingsResponse.RequestId = _ctx.StringValue("ListCloudMetricProfilings.RequestId");
			listCloudMetricProfilingsResponse.TotalCount = _ctx.IntegerValue("ListCloudMetricProfilings.TotalCount");
			listCloudMetricProfilingsResponse.PageNumber = _ctx.IntegerValue("ListCloudMetricProfilings.PageNumber");
			listCloudMetricProfilingsResponse.PageSize = _ctx.IntegerValue("ListCloudMetricProfilings.PageSize");

			List<ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo> listCloudMetricProfilingsResponse_profilings = new List<ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo>();
			for (int i = 0; i < _ctx.Length("ListCloudMetricProfilings.Profilings.Length"); i++) {
				ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo profilingInfo = new ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo();
				profilingInfo.ProfilingId = _ctx.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].ProfilingId");
				profilingInfo.InstanceId = _ctx.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].InstanceId");
				profilingInfo.HostName = _ctx.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].HostName");
				profilingInfo.Pid = _ctx.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Pid");
				profilingInfo.Duration = _ctx.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Duration");
				profilingInfo.Freq = _ctx.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Freq");
				profilingInfo.TriggerTime = _ctx.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].TriggerTime");

				listCloudMetricProfilingsResponse_profilings.Add(profilingInfo);
			}
			listCloudMetricProfilingsResponse.Profilings = listCloudMetricProfilingsResponse_profilings;
        
			return listCloudMetricProfilingsResponse;
        }
    }
}
