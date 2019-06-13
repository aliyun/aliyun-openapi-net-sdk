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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class DescribeNetworkQuotasResponseUnmarshaller
    {
        public static DescribeNetworkQuotasResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkQuotasResponse describeNetworkQuotasResponse = new DescribeNetworkQuotasResponse();

			describeNetworkQuotasResponse.HttpResponse = context.HttpResponse;
			describeNetworkQuotasResponse.RequestId = context.StringValue("DescribeNetworkQuotas.RequestId");
			describeNetworkQuotasResponse.TotalCount = context.IntegerValue("DescribeNetworkQuotas.TotalCount");

			List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota> describeNetworkQuotasResponse_networkQuotas = new List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota>();
			for (int i = 0; i < context.Length("DescribeNetworkQuotas.NetworkQuotas.Length"); i++) {
				DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota networkQuota = new DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota();
				networkQuota.Product = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Product");
				networkQuota.ResourceType = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].ResourceType");

				List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_Privilege> networkQuota_privileges = new List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_Privilege>();
				for (int j = 0; j < context.Length("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Privileges.Length"); j++) {
					DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_Privilege privilege = new DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_Privilege();
					privilege.Privilege = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Privileges["+ j +"].Privilege");
					privilege.Description = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Privileges["+ j +"].Description");
					privilege.Enabled = context.BooleanValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Privileges["+ j +"].Enabled");
					privilege.DescriptionCn = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].Privileges["+ j +"].DescriptionCn");

					networkQuota_privileges.Add(privilege);
				}
				networkQuota.Privileges = networkQuota_privileges;

				List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_NetworkQuotaInfo> networkQuota_networkQuotaInfos = new List<DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_NetworkQuotaInfo>();
				for (int j = 0; j < context.Length("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos.Length"); j++) {
					DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_NetworkQuotaInfo networkQuotaInfo = new DescribeNetworkQuotasResponse.DescribeNetworkQuotas_NetworkQuota.DescribeNetworkQuotas_NetworkQuotaInfo();
					networkQuotaInfo.QuotaName = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].QuotaName");
					networkQuotaInfo.QuotaDescription = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].QuotaDescription");
					networkQuotaInfo.QuotaQuantity = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].QuotaQuantity");
					networkQuotaInfo.InstanceQuantity = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].InstanceQuantity");
					networkQuotaInfo.CanExceptional = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].CanExceptional");
					networkQuotaInfo.QuotaDescriptionCn = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].QuotaDescriptionCn");
					networkQuotaInfo.Sequence = context.StringValue("DescribeNetworkQuotas.NetworkQuotas["+ i +"].NetworkQuotaInfos["+ j +"].Sequence");

					networkQuota_networkQuotaInfos.Add(networkQuotaInfo);
				}
				networkQuota.NetworkQuotaInfos = networkQuota_networkQuotaInfos;

				describeNetworkQuotasResponse_networkQuotas.Add(networkQuota);
			}
			describeNetworkQuotasResponse.NetworkQuotas = describeNetworkQuotasResponse_networkQuotas;
        
			return describeNetworkQuotasResponse;
        }
    }
}
