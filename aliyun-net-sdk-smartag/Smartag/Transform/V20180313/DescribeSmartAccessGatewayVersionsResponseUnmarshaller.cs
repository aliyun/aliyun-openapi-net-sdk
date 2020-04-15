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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSmartAccessGatewayVersionsResponseUnmarshaller
    {
        public static DescribeSmartAccessGatewayVersionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSmartAccessGatewayVersionsResponse describeSmartAccessGatewayVersionsResponse = new DescribeSmartAccessGatewayVersionsResponse();

			describeSmartAccessGatewayVersionsResponse.HttpResponse = context.HttpResponse;
			describeSmartAccessGatewayVersionsResponse.RequestId = context.StringValue("DescribeSmartAccessGatewayVersions.RequestId");

			List<DescribeSmartAccessGatewayVersionsResponse.DescribeSmartAccessGatewayVersions_SmartAGVersion> describeSmartAccessGatewayVersionsResponse_smartAGVersions = new List<DescribeSmartAccessGatewayVersionsResponse.DescribeSmartAccessGatewayVersions_SmartAGVersion>();
			for (int i = 0; i < context.Length("DescribeSmartAccessGatewayVersions.SmartAGVersions.Length"); i++) {
				DescribeSmartAccessGatewayVersionsResponse.DescribeSmartAccessGatewayVersions_SmartAGVersion smartAGVersion = new DescribeSmartAccessGatewayVersionsResponse.DescribeSmartAccessGatewayVersions_SmartAGVersion();
				smartAGVersion.VersionCode = context.StringValue("DescribeSmartAccessGatewayVersions.SmartAGVersions["+ i +"].VersionCode");
				smartAGVersion.VersionName = context.StringValue("DescribeSmartAccessGatewayVersions.SmartAGVersions["+ i +"].VersionName");
				smartAGVersion.CreateTime = context.LongValue("DescribeSmartAccessGatewayVersions.SmartAGVersions["+ i +"].CreateTime");
				smartAGVersion.Type = context.StringValue("DescribeSmartAccessGatewayVersions.SmartAGVersions["+ i +"].Type");

				describeSmartAccessGatewayVersionsResponse_smartAGVersions.Add(smartAGVersion);
			}
			describeSmartAccessGatewayVersionsResponse.SmartAGVersions = describeSmartAccessGatewayVersionsResponse_smartAGVersions;
        
			return describeSmartAccessGatewayVersionsResponse;
        }
    }
}
