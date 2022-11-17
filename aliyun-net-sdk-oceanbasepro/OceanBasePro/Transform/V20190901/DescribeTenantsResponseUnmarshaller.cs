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
    public class DescribeTenantsResponseUnmarshaller
    {
        public static DescribeTenantsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTenantsResponse describeTenantsResponse = new DescribeTenantsResponse();

			describeTenantsResponse.HttpResponse = _ctx.HttpResponse;
			describeTenantsResponse.TotalCount = _ctx.IntegerValue("DescribeTenants.TotalCount");
			describeTenantsResponse.RequestId = _ctx.StringValue("DescribeTenants.RequestId");

			List<DescribeTenantsResponse.DescribeTenants_Data> describeTenantsResponse_tenants = new List<DescribeTenantsResponse.DescribeTenants_Data>();
			for (int i = 0; i < _ctx.Length("DescribeTenants.Tenants.Length"); i++) {
				DescribeTenantsResponse.DescribeTenants_Data data = new DescribeTenantsResponse.DescribeTenants_Data();
				data.VpcId = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].VpcId");
				data.Status = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].Status");
				data.PrimaryZone = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].PrimaryZone");
				data.DeployType = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].DeployType");
				data.DeployMode = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].DeployMode");
				data.CreateTime = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].CreateTime");
				data.TenantName = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].TenantName");
				data.Mem = _ctx.IntegerValue("DescribeTenants.Tenants["+ i +"].Mem");
				data.Cpu = _ctx.IntegerValue("DescribeTenants.Tenants["+ i +"].Cpu");
				data.Description = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].Description");
				data.TenantMode = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].TenantMode");
				data.TenantId = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].TenantId");
				data.UnitCpu = _ctx.IntegerValue("DescribeTenants.Tenants["+ i +"].UnitCpu");
				data.UnitMem = _ctx.IntegerValue("DescribeTenants.Tenants["+ i +"].UnitMem");
				data.UnitNum = _ctx.IntegerValue("DescribeTenants.Tenants["+ i +"].UnitNum");
				data.UsedDiskSize = _ctx.DoubleValue("DescribeTenants.Tenants["+ i +"].UsedDiskSize");
				data.Charset = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].Charset");
				data.Collation = _ctx.StringValue("DescribeTenants.Tenants["+ i +"].Collation");

				describeTenantsResponse_tenants.Add(data);
			}
			describeTenantsResponse.Tenants = describeTenantsResponse_tenants;
        
			return describeTenantsResponse;
        }
    }
}
