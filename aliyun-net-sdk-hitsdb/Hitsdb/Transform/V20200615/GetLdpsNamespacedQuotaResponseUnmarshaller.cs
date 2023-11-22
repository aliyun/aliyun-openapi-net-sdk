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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetLdpsNamespacedQuotaResponseUnmarshaller
    {
        public static GetLdpsNamespacedQuotaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLdpsNamespacedQuotaResponse getLdpsNamespacedQuotaResponse = new GetLdpsNamespacedQuotaResponse();

			getLdpsNamespacedQuotaResponse.HttpResponse = _ctx.HttpResponse;
			getLdpsNamespacedQuotaResponse.RequestId = _ctx.StringValue("GetLdpsNamespacedQuota.RequestId");

			List<GetLdpsNamespacedQuotaResponse.GetLdpsNamespacedQuota_NamespacedQuota> getLdpsNamespacedQuotaResponse_namespacedQuotas = new List<GetLdpsNamespacedQuotaResponse.GetLdpsNamespacedQuota_NamespacedQuota>();
			for (int i = 0; i < _ctx.Length("GetLdpsNamespacedQuota.NamespacedQuotas.Length"); i++) {
				GetLdpsNamespacedQuotaResponse.GetLdpsNamespacedQuota_NamespacedQuota namespacedQuota = new GetLdpsNamespacedQuotaResponse.GetLdpsNamespacedQuota_NamespacedQuota();
				namespacedQuota.Name = _ctx.StringValue("GetLdpsNamespacedQuota.NamespacedQuotas["+ i +"].Name");
				namespacedQuota.CpuAmount = _ctx.StringValue("GetLdpsNamespacedQuota.NamespacedQuotas["+ i +"].CpuAmount");
				namespacedQuota.MemoryAmount = _ctx.StringValue("GetLdpsNamespacedQuota.NamespacedQuotas["+ i +"].MemoryAmount");
				namespacedQuota.UsedCpu = _ctx.StringValue("GetLdpsNamespacedQuota.NamespacedQuotas["+ i +"].UsedCpu");
				namespacedQuota.UsedMemory = _ctx.StringValue("GetLdpsNamespacedQuota.NamespacedQuotas["+ i +"].UsedMemory");

				getLdpsNamespacedQuotaResponse_namespacedQuotas.Add(namespacedQuota);
			}
			getLdpsNamespacedQuotaResponse.NamespacedQuotas = getLdpsNamespacedQuotaResponse_namespacedQuotas;
        
			return getLdpsNamespacedQuotaResponse;
        }
    }
}
