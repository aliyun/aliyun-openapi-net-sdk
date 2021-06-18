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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeBackupPoliciesResponseUnmarshaller
    {
        public static DescribeBackupPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPoliciesResponse describeBackupPoliciesResponse = new DescribeBackupPoliciesResponse();

			describeBackupPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPoliciesResponse.RequestId = _ctx.StringValue("DescribeBackupPolicies.RequestId");

			DescribeBackupPoliciesResponse.DescribeBackupPolicies_PageInfo pageInfo = new DescribeBackupPoliciesResponse.DescribeBackupPolicies_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeBackupPolicies.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeBackupPolicies.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeBackupPolicies.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeBackupPolicies.PageInfo.CurrentPage");
			describeBackupPoliciesResponse.PageInfo = pageInfo;

			List<DescribeBackupPoliciesResponse.DescribeBackupPolicies_BackupPolicy> describeBackupPoliciesResponse_policies = new List<DescribeBackupPoliciesResponse.DescribeBackupPolicies_BackupPolicy>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPolicies.Policies.Length"); i++) {
				DescribeBackupPoliciesResponse.DescribeBackupPolicies_BackupPolicy backupPolicy = new DescribeBackupPoliciesResponse.DescribeBackupPolicies_BackupPolicy();
				backupPolicy.Id = _ctx.LongValue("DescribeBackupPolicies.Policies["+ i +"].Id");
				backupPolicy.Name = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].Name");
				backupPolicy.Status = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].Status");
				backupPolicy.Policy = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].Policy");
				backupPolicy.PolicyVersion = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].PolicyVersion");
				backupPolicy.PolicyRegionId = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].PolicyRegionId");
				backupPolicy.ClientStatus = _ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].ClientStatus");
				backupPolicy.ClientErrorCount = _ctx.IntegerValue("DescribeBackupPolicies.Policies["+ i +"].ClientErrorCount");
				backupPolicy.ServiceErrorCount = _ctx.IntegerValue("DescribeBackupPolicies.Policies["+ i +"].ServiceErrorCount");
				backupPolicy.HealthClientCount = _ctx.IntegerValue("DescribeBackupPolicies.Policies["+ i +"].HealthClientCount");

				List<string> backupPolicy_uuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupPolicies.Policies["+ i +"].UuidList.Length"); j++) {
					backupPolicy_uuidList.Add(_ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].UuidList["+ j +"]"));
				}
				backupPolicy.UuidList = backupPolicy_uuidList;

				List<string> backupPolicy_remarkedUuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupPolicies.Policies["+ i +"].RemarkedUuidList.Length"); j++) {
					backupPolicy_remarkedUuidList.Add(_ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].RemarkedUuidList["+ j +"]"));
				}
				backupPolicy.RemarkedUuidList = backupPolicy_remarkedUuidList;

				List<string> backupPolicy_clientErrorUuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupPolicies.Policies["+ i +"].ClientErrorUuidList.Length"); j++) {
					backupPolicy_clientErrorUuidList.Add(_ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].ClientErrorUuidList["+ j +"]"));
				}
				backupPolicy.ClientErrorUuidList = backupPolicy_clientErrorUuidList;

				List<string> backupPolicy_serviceErrorUuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupPolicies.Policies["+ i +"].ServiceErrorUuidList.Length"); j++) {
					backupPolicy_serviceErrorUuidList.Add(_ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].ServiceErrorUuidList["+ j +"]"));
				}
				backupPolicy.ServiceErrorUuidList = backupPolicy_serviceErrorUuidList;

				List<string> backupPolicy_healthClientUuidList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupPolicies.Policies["+ i +"].HealthClientUuidList.Length"); j++) {
					backupPolicy_healthClientUuidList.Add(_ctx.StringValue("DescribeBackupPolicies.Policies["+ i +"].HealthClientUuidList["+ j +"]"));
				}
				backupPolicy.HealthClientUuidList = backupPolicy_healthClientUuidList;

				describeBackupPoliciesResponse_policies.Add(backupPolicy);
			}
			describeBackupPoliciesResponse.Policies = describeBackupPoliciesResponse_policies;
        
			return describeBackupPoliciesResponse;
        }
    }
}
