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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class ModifyTenantEncryptionResponseUnmarshaller
    {
        public static ModifyTenantEncryptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyTenantEncryptionResponse modifyTenantEncryptionResponse = new ModifyTenantEncryptionResponse();

			modifyTenantEncryptionResponse.HttpResponse = _ctx.HttpResponse;
			modifyTenantEncryptionResponse.RequestId = _ctx.StringValue("ModifyTenantEncryption.RequestId");

			ModifyTenantEncryptionResponse.ModifyTenantEncryption_TenantEncryption tenantEncryption = new ModifyTenantEncryptionResponse.ModifyTenantEncryption_TenantEncryption();
			tenantEncryption.InstanceId = _ctx.StringValue("ModifyTenantEncryption.TenantEncryption.InstanceId");
			tenantEncryption.TenantId = _ctx.StringValue("ModifyTenantEncryption.TenantEncryption.TenantId");
			tenantEncryption.EncryptionType = _ctx.StringValue("ModifyTenantEncryption.TenantEncryption.EncryptionType");
			modifyTenantEncryptionResponse.TenantEncryption = tenantEncryption;
        
			return modifyTenantEncryptionResponse;
        }
    }
}
