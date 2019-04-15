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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class OperateAgentClientInstallResponseUnmarshaller
    {
        public static OperateAgentClientInstallResponse Unmarshall(UnmarshallerContext context)
        {
			OperateAgentClientInstallResponse operateAgentClientInstallResponse = new OperateAgentClientInstallResponse();

			operateAgentClientInstallResponse.HttpResponse = context.HttpResponse;
			operateAgentClientInstallResponse.RequestId = context.StringValue("OperateAgentClientInstall.RequestId");

			List<OperateAgentClientInstallResponse.OperateAgentClientInstall_AegisCelintInstallRespose> operateAgentClientInstallResponse_aegisCelintInstallResposeList = new List<OperateAgentClientInstallResponse.OperateAgentClientInstall_AegisCelintInstallRespose>();
			for (int i = 0; i < context.Length("OperateAgentClientInstall.AegisCelintInstallResposeList.Length"); i++) {
				OperateAgentClientInstallResponse.OperateAgentClientInstall_AegisCelintInstallRespose aegisCelintInstallRespose = new OperateAgentClientInstallResponse.OperateAgentClientInstall_AegisCelintInstallRespose();
				aegisCelintInstallRespose.InstanceId = context.StringValue("OperateAgentClientInstall.AegisCelintInstallResposeList["+ i +"].InstanceId");
				aegisCelintInstallRespose.RecordId = context.LongValue("OperateAgentClientInstall.AegisCelintInstallResposeList["+ i +"].RecordId");
				aegisCelintInstallRespose.Uuid = context.StringValue("OperateAgentClientInstall.AegisCelintInstallResposeList["+ i +"].Uuid");

				operateAgentClientInstallResponse_aegisCelintInstallResposeList.Add(aegisCelintInstallRespose);
			}
			operateAgentClientInstallResponse.AegisCelintInstallResposeList = operateAgentClientInstallResponse_aegisCelintInstallResposeList;
        
			return operateAgentClientInstallResponse;
        }
    }
}
