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
    public class DescribePolicyResponseUnmarshaller
    {
        public static DescribePolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePolicyResponse describePolicyResponse = new DescribePolicyResponse();

			describePolicyResponse.HttpResponse = _ctx.HttpResponse;
			describePolicyResponse.RequestId = _ctx.StringValue("DescribePolicy.RequestId");
			describePolicyResponse.Arn = _ctx.StringValue("DescribePolicy.Arn");
			describePolicyResponse.Name = _ctx.StringValue("DescribePolicy.Name");
			describePolicyResponse.Description = _ctx.StringValue("DescribePolicy.Description");
			describePolicyResponse.KmsInstance = _ctx.StringValue("DescribePolicy.KmsInstance");
			describePolicyResponse.AccessControlRules = _ctx.StringValue("DescribePolicy.AccessControlRules");

			List<string> describePolicyResponse_permissions = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePolicy.Permissions.Length"); i++) {
				describePolicyResponse_permissions.Add(_ctx.StringValue("DescribePolicy.Permissions["+ i +"]"));
			}
			describePolicyResponse.Permissions = describePolicyResponse_permissions;

			List<string> describePolicyResponse_resources = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribePolicy.Resources.Length"); i++) {
				describePolicyResponse_resources.Add(_ctx.StringValue("DescribePolicy.Resources["+ i +"]"));
			}
			describePolicyResponse.Resources = describePolicyResponse_resources;
        
			return describePolicyResponse;
        }
    }
}
