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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListCloudMetricProfilingsResponseUnmarshaller
    {
        public static ListCloudMetricProfilingsResponse Unmarshall(UnmarshallerContext context)
        {
			ListCloudMetricProfilingsResponse listCloudMetricProfilingsResponse = new ListCloudMetricProfilingsResponse();

			listCloudMetricProfilingsResponse.HttpResponse = context.HttpResponse;
			listCloudMetricProfilingsResponse.RequestId = context.StringValue("ListCloudMetricProfilings.RequestId");
			listCloudMetricProfilingsResponse.TotalCount = context.IntegerValue("ListCloudMetricProfilings.TotalCount");
			listCloudMetricProfilingsResponse.PageNumber = context.IntegerValue("ListCloudMetricProfilings.PageNumber");
			listCloudMetricProfilingsResponse.PageSize = context.IntegerValue("ListCloudMetricProfilings.PageSize");

			List<ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo> listCloudMetricProfilingsResponse_profilings = new List<ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo>();
			for (int i = 0; i < context.Length("ListCloudMetricProfilings.Profilings.Length"); i++) {
				ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo profilingInfo = new ListCloudMetricProfilingsResponse.ListCloudMetricProfilings_ProfilingInfo();
				profilingInfo.ProfilingId = context.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].ProfilingId");
				profilingInfo.InstanceId = context.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].InstanceId");
				profilingInfo.HostName = context.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].HostName");
				profilingInfo.Pid = context.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Pid");
				profilingInfo.Duration = context.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Duration");
				profilingInfo.Freq = context.IntegerValue("ListCloudMetricProfilings.Profilings["+ i +"].Freq");
				profilingInfo.TriggerTime = context.StringValue("ListCloudMetricProfilings.Profilings["+ i +"].TriggerTime");

				listCloudMetricProfilingsResponse_profilings.Add(profilingInfo);
			}
			listCloudMetricProfilingsResponse.Profilings = listCloudMetricProfilingsResponse_profilings;
        
			return listCloudMetricProfilingsResponse;
        }
    }
}