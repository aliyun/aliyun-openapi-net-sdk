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
    public class GetVmMetaResponseUnmarshaller
    {
        public static GetVmMetaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVmMetaResponse getVmMetaResponse = new GetVmMetaResponse();

			getVmMetaResponse.HttpResponse = _ctx.HttpResponse;
			getVmMetaResponse.RequestId = _ctx.StringValue("GetVmMeta.RequestId");

			GetVmMetaResponse.GetVmMeta_VmMetaInfo vmMetaInfo = new GetVmMetaResponse.GetVmMeta_VmMetaInfo();
			vmMetaInfo.RootCertPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.RootCertPath");
			vmMetaInfo.RootCertContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.RootCertContent");
			vmMetaInfo.KeyPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.KeyPath");
			vmMetaInfo.KeyContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.KeyContent");
			vmMetaInfo.CertChainPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.CertChainPath");
			vmMetaInfo.CertChainContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.CertChainContent");
			vmMetaInfo.EnvoyEnvPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.EnvoyEnvPath");
			vmMetaInfo.EnvoyEnvContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.EnvoyEnvContent");
			vmMetaInfo.HostsPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.HostsPath");
			vmMetaInfo.HostsContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.HostsContent");
			vmMetaInfo.TokenPath = _ctx.StringValue("GetVmMeta.VmMetaInfo.TokenPath");
			vmMetaInfo.TokenContent = _ctx.StringValue("GetVmMeta.VmMetaInfo.TokenContent");
			getVmMetaResponse.VmMetaInfo = vmMetaInfo;
        
			return getVmMetaResponse;
        }
    }
}
