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
    public class DescribeTenantEncryptionResponseUnmarshaller
    {
        public static DescribeTenantEncryptionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantEncryptionResponse describeTenantEncryptionResponse = new DescribeTenantEncryptionResponse();

			describeTenantEncryptionResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantEncryptionResponse.RequestId = _ctx.StringValue("DescribeTenantEncryption.RequestId");
			describeTenantEncryptionResponse.TotalCount = _ctx.IntegerValue("DescribeTenantEncryption.TotalCount");

			List<DescribeTenantEncryptionResponse.DescribeTenantEncryption_TenantEncryptionsItem> describeTenantEncryptionResponse_tenantEncryptions = new List<DescribeTenantEncryptionResponse.DescribeTenantEncryption_TenantEncryptionsItem>();
			for (int i = 0; i < _ctx.Length("DescribeTenantEncryption.TenantEncryptions.Length"); i++) {
				DescribeTenantEncryptionResponse.DescribeTenantEncryption_TenantEncryptionsItem tenantEncryptionsItem = new DescribeTenantEncryptionResponse.DescribeTenantEncryption_TenantEncryptionsItem();
				tenantEncryptionsItem.TenantId = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].TenantId");
				tenantEncryptionsItem.TenantMode = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].TenantMode");
				tenantEncryptionsItem.TenantName = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].TenantName");
				tenantEncryptionsItem.EnableEncryption = _ctx.BooleanValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].EnableEncryption");
				tenantEncryptionsItem.TenantStatus = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].TenantStatus");
				tenantEncryptionsItem.Status = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].Status");
				tenantEncryptionsItem.EncryptionType = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].EncryptionType");
				tenantEncryptionsItem.EncryptionKeyId = _ctx.StringValue("DescribeTenantEncryption.TenantEncryptions["+ i +"].EncryptionKeyId");

				describeTenantEncryptionResponse_tenantEncryptions.Add(tenantEncryptionsItem);
			}
			describeTenantEncryptionResponse.TenantEncryptions = describeTenantEncryptionResponse_tenantEncryptions;
        
			return describeTenantEncryptionResponse;
        }
    }
}
