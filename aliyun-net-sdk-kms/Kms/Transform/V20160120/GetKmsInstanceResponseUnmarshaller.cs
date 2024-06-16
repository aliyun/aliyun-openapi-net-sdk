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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class GetKmsInstanceResponseUnmarshaller
    {
        public static GetKmsInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetKmsInstanceResponse getKmsInstanceResponse = new GetKmsInstanceResponse();

			getKmsInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getKmsInstanceResponse.RequestId = _ctx.StringValue("GetKmsInstance.RequestId");

			GetKmsInstanceResponse.GetKmsInstance_KmsInstance kmsInstance = new GetKmsInstanceResponse.GetKmsInstance_KmsInstance();
			kmsInstance.InstanceId = _ctx.StringValue("GetKmsInstance.KmsInstance.InstanceId");
			kmsInstance.InstanceName = _ctx.StringValue("GetKmsInstance.KmsInstance.InstanceName");
			kmsInstance.Status = _ctx.StringValue("GetKmsInstance.KmsInstance.Status");
			kmsInstance.CreateTime = _ctx.StringValue("GetKmsInstance.KmsInstance.CreateTime");
			kmsInstance.Spec = _ctx.LongValue("GetKmsInstance.KmsInstance.Spec");
			kmsInstance.KeyNum = _ctx.LongValue("GetKmsInstance.KmsInstance.KeyNum");
			kmsInstance.SecretNum = _ctx.StringValue("GetKmsInstance.KmsInstance.SecretNum");
			kmsInstance.VpcNum = _ctx.LongValue("GetKmsInstance.KmsInstance.VpcNum");
			kmsInstance.VpcId = _ctx.StringValue("GetKmsInstance.KmsInstance.VpcId");
			kmsInstance.ZoneIds = _ctx.StringValue("GetKmsInstance.KmsInstance.ZoneIds");
			kmsInstance.VswitchIds = _ctx.StringValue("GetKmsInstance.KmsInstance.VswitchIds");
			kmsInstance.EndDate = _ctx.StringValue("GetKmsInstance.KmsInstance.EndDate");
			kmsInstance.StartDate = _ctx.StringValue("GetKmsInstance.KmsInstance.StartDate");
			kmsInstance.CaCertificateChainPem = _ctx.StringValue("GetKmsInstance.KmsInstance.CaCertificateChainPem");

			List<GetKmsInstanceResponse.GetKmsInstance_KmsInstance.GetKmsInstance_BindVpc> kmsInstance_bindVpcs = new List<GetKmsInstanceResponse.GetKmsInstance_KmsInstance.GetKmsInstance_BindVpc>();
			for (int i = 0; i < _ctx.Length("GetKmsInstance.KmsInstance.BindVpcs.Length"); i++) {
				GetKmsInstanceResponse.GetKmsInstance_KmsInstance.GetKmsInstance_BindVpc bindVpc = new GetKmsInstanceResponse.GetKmsInstance_KmsInstance.GetKmsInstance_BindVpc();
				bindVpc.RegionId = _ctx.StringValue("GetKmsInstance.KmsInstance.BindVpcs["+ i +"].RegionId");
				bindVpc.VpcId = _ctx.StringValue("GetKmsInstance.KmsInstance.BindVpcs["+ i +"].VpcId");
				bindVpc.VpcOwnerId = _ctx.StringValue("GetKmsInstance.KmsInstance.BindVpcs["+ i +"].VpcOwnerId");
				bindVpc.VSwitchId = _ctx.StringValue("GetKmsInstance.KmsInstance.BindVpcs["+ i +"].VSwitchId");

				kmsInstance_bindVpcs.Add(bindVpc);
			}
			kmsInstance.BindVpcs = kmsInstance_bindVpcs;
			getKmsInstanceResponse.KmsInstance = kmsInstance;
        
			return getKmsInstanceResponse;
        }
    }
}
