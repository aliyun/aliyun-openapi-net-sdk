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
using Aliyun.Acs.Dds.Model.V20151201;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class SampleResponseUnmarshaller
    {
        public static SampleResponse Unmarshall(UnmarshallerContext context)
        {
			SampleResponse sampleResponse = new SampleResponse();

			sampleResponse.HttpResponse = context.HttpResponse;
			sampleResponse.RequestId = context.StringValue("Sample.RequestId");
			sampleResponse.SecurityIps = context.StringValue("Sample.SecurityIps");

			List<SampleResponse.Sample_SecurityIpGroup> sampleResponse_securityIpGroups = new List<SampleResponse.Sample_SecurityIpGroup>();
			for (int i = 0; i < context.Length("Sample.SecurityIpGroups.Length"); i++) {
				SampleResponse.Sample_SecurityIpGroup securityIpGroup = new SampleResponse.Sample_SecurityIpGroup();
				securityIpGroup.SecurityIpGroupName = context.StringValue("Sample.SecurityIpGroups["+ i +"].SecurityIpGroupName");
				securityIpGroup.SecurityIpGroupAttribute = context.StringValue("Sample.SecurityIpGroups["+ i +"].SecurityIpGroupAttribute");
				securityIpGroup.SecurityIpList = context.StringValue("Sample.SecurityIpGroups["+ i +"].SecurityIpList");

				sampleResponse_securityIpGroups.Add(securityIpGroup);
			}
			sampleResponse.SecurityIpGroups = sampleResponse_securityIpGroups;
        
			return sampleResponse;
        }
    }
}