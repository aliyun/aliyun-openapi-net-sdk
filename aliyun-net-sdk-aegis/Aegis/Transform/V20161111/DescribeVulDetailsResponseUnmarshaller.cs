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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulDetailsResponseUnmarshaller
    {
        public static DescribeVulDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulDetailsResponse describeVulDetailsResponse = new DescribeVulDetailsResponse();

			describeVulDetailsResponse.HttpResponse = context.HttpResponse;
			describeVulDetailsResponse.RequestId = context.StringValue("DescribeVulDetails.RequestId");
			describeVulDetailsResponse.Name = context.StringValue("DescribeVulDetails.Name");
			describeVulDetailsResponse.AliasName = context.StringValue("DescribeVulDetails.AliasName");
			describeVulDetailsResponse.Level = context.StringValue("DescribeVulDetails.Level");
			describeVulDetailsResponse.VulPublishTs = context.LongValue("DescribeVulDetails.VulPublishTs");
			describeVulDetailsResponse.Type = context.StringValue("DescribeVulDetails.Type");
			describeVulDetailsResponse.Product = context.StringValue("DescribeVulDetails.Product");
			describeVulDetailsResponse.HasPatch = context.BooleanValue("DescribeVulDetails.HasPatch");
			describeVulDetailsResponse.PatchPublishTs = context.LongValue("DescribeVulDetails.PatchPublishTs");
			describeVulDetailsResponse.PatchSource = context.StringValue("DescribeVulDetails.PatchSource");
			describeVulDetailsResponse.Cvss = context.StringValue("DescribeVulDetails.Cvss");
			describeVulDetailsResponse.CveIds = context.StringValue("DescribeVulDetails.CveIds");
			describeVulDetailsResponse.Advice = context.StringValue("DescribeVulDetails.Advice");
			describeVulDetailsResponse.Description = context.StringValue("DescribeVulDetails.Description");
			describeVulDetailsResponse.PendingCount = context.IntegerValue("DescribeVulDetails.PendingCount");
			describeVulDetailsResponse.HandledCount = context.IntegerValue("DescribeVulDetails.HandledCount");

			List<string> describeVulDetailsResponse_cveLists = new List<string>();
			for (int i = 0; i < context.Length("DescribeVulDetails.CveLists.Length"); i++) {
				describeVulDetailsResponse_cveLists.Add(context.StringValue("DescribeVulDetails.CveLists["+ i +"]"));
			}
			describeVulDetailsResponse.CveLists = describeVulDetailsResponse_cveLists;
        
			return describeVulDetailsResponse;
        }
    }
}