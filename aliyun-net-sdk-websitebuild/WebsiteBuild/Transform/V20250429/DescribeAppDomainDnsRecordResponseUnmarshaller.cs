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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class DescribeAppDomainDnsRecordResponseUnmarshaller
    {
        public static DescribeAppDomainDnsRecordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppDomainDnsRecordResponse describeAppDomainDnsRecordResponse = new DescribeAppDomainDnsRecordResponse();

			describeAppDomainDnsRecordResponse.HttpResponse = _ctx.HttpResponse;
			describeAppDomainDnsRecordResponse.RequestId = _ctx.StringValue("DescribeAppDomainDnsRecord.RequestId");
			describeAppDomainDnsRecordResponse.DynamicCode = _ctx.StringValue("DescribeAppDomainDnsRecord.DynamicCode");
			describeAppDomainDnsRecordResponse.DynamicMessage = _ctx.StringValue("DescribeAppDomainDnsRecord.DynamicMessage");
			describeAppDomainDnsRecordResponse.Synchro = _ctx.BooleanValue("DescribeAppDomainDnsRecord.Synchro");
			describeAppDomainDnsRecordResponse.AccessDeniedDetail = _ctx.StringValue("DescribeAppDomainDnsRecord.AccessDeniedDetail");
			describeAppDomainDnsRecordResponse.RootErrorMsg = _ctx.StringValue("DescribeAppDomainDnsRecord.RootErrorMsg");
			describeAppDomainDnsRecordResponse.RootErrorCode = _ctx.StringValue("DescribeAppDomainDnsRecord.RootErrorCode");
			describeAppDomainDnsRecordResponse.AllowRetry = _ctx.BooleanValue("DescribeAppDomainDnsRecord.AllowRetry");
			describeAppDomainDnsRecordResponse.AppName = _ctx.StringValue("DescribeAppDomainDnsRecord.AppName");

			List<string> describeAppDomainDnsRecordResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeAppDomainDnsRecord.ErrorArgs.Length"); i++) {
				describeAppDomainDnsRecordResponse_errorArgs.Add(_ctx.StringValue("DescribeAppDomainDnsRecord.ErrorArgs["+ i +"]"));
			}
			describeAppDomainDnsRecordResponse.ErrorArgs = describeAppDomainDnsRecordResponse_errorArgs;

			DescribeAppDomainDnsRecordResponse.DescribeAppDomainDnsRecord_Module module = new DescribeAppDomainDnsRecordResponse.DescribeAppDomainDnsRecord_Module();
			module.RecordType = _ctx.StringValue("DescribeAppDomainDnsRecord.Module.RecordType");
			module.Host = _ctx.StringValue("DescribeAppDomainDnsRecord.Module.Host");
			module._Value = _ctx.StringValue("DescribeAppDomainDnsRecord.Module.Value");
			describeAppDomainDnsRecordResponse.Module = module;
        
			return describeAppDomainDnsRecordResponse;
        }
    }
}
