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
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeDomainsResolutionResponseUnmarshaller
    {
        public static DescribeDomainsResolutionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainsResolutionResponse describeDomainsResolutionResponse = new DescribeDomainsResolutionResponse();

			describeDomainsResolutionResponse.HttpResponse = context.HttpResponse;
			describeDomainsResolutionResponse.RequestId = context.StringValue("DescribeDomainsResolution.RequestId");
			describeDomainsResolutionResponse.GroupId = context.StringValue("DescribeDomainsResolution.GroupId");

			List<DescribeDomainsResolutionResponse.DescribeDomainsResolution_DomainResolution> describeDomainsResolutionResponse_domainResolutions = new List<DescribeDomainsResolutionResponse.DescribeDomainsResolution_DomainResolution>();
			for (int i = 0; i < context.Length("DescribeDomainsResolution.DomainResolutions.Length"); i++) {
				DescribeDomainsResolutionResponse.DescribeDomainsResolution_DomainResolution domainResolution = new DescribeDomainsResolutionResponse.DescribeDomainsResolution_DomainResolution();
				domainResolution.DomainName = context.StringValue("DescribeDomainsResolution.DomainResolutions["+ i +"].DomainName");
				domainResolution.DomainResolutionStatus = context.StringValue("DescribeDomainsResolution.DomainResolutions["+ i +"].DomainResolutionStatus");

				describeDomainsResolutionResponse_domainResolutions.Add(domainResolution);
			}
			describeDomainsResolutionResponse.DomainResolutions = describeDomainsResolutionResponse_domainResolutions;
        
			return describeDomainsResolutionResponse;
        }
    }
}
