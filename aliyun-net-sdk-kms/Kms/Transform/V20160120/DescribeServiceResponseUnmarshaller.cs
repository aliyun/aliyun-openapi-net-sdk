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
    public class DescribeServiceResponseUnmarshaller
    {
        public static DescribeServiceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeServiceResponse describeServiceResponse = new DescribeServiceResponse();

			describeServiceResponse.HttpResponse = context.HttpResponse;
			describeServiceResponse.RequestId = context.StringValue("DescribeService.RequestId");

			List<DescribeServiceResponse.DescribeService_ProtectionLevel> describeServiceResponse_protectionLevels = new List<DescribeServiceResponse.DescribeService_ProtectionLevel>();
			for (int i = 0; i < context.Length("DescribeService.ProtectionLevels.Length"); i++) {
				DescribeServiceResponse.DescribeService_ProtectionLevel protectionLevel = new DescribeServiceResponse.DescribeService_ProtectionLevel();
				protectionLevel.Type = context.StringValue("DescribeService.ProtectionLevels["+ i +"].Type");

				describeServiceResponse_protectionLevels.Add(protectionLevel);
			}
			describeServiceResponse.ProtectionLevels = describeServiceResponse_protectionLevels;

			List<DescribeServiceResponse.DescribeService_KeySpec> describeServiceResponse_keySpecs = new List<DescribeServiceResponse.DescribeService_KeySpec>();
			for (int i = 0; i < context.Length("DescribeService.KeySpecs.Length"); i++) {
				DescribeServiceResponse.DescribeService_KeySpec keySpec = new DescribeServiceResponse.DescribeService_KeySpec();
				keySpec.Name = context.StringValue("DescribeService.KeySpecs["+ i +"].Name");

				List<string> keySpec_supportedProtectionLevels = new List<string>();
				for (int j = 0; j < context.Length("DescribeService.KeySpecs["+ i +"].SupportedProtectionLevels.Length"); j++) {
					keySpec_supportedProtectionLevels.Add(context.StringValue("DescribeService.KeySpecs["+ i +"].SupportedProtectionLevels["+ j +"]"));
				}
				keySpec.SupportedProtectionLevels = keySpec_supportedProtectionLevels;

				List<string> keySpec_usages = new List<string>();
				for (int j = 0; j < context.Length("DescribeService.KeySpecs["+ i +"].Usages.Length"); j++) {
					keySpec_usages.Add(context.StringValue("DescribeService.KeySpecs["+ i +"].Usages["+ j +"]"));
				}
				keySpec.Usages = keySpec_usages;

				describeServiceResponse_keySpecs.Add(keySpec);
			}
			describeServiceResponse.KeySpecs = describeServiceResponse_keySpecs;
        
			return describeServiceResponse;
        }
    }
}
