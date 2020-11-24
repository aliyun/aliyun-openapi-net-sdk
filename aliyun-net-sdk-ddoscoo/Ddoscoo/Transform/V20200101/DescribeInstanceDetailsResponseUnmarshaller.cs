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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeInstanceDetailsResponseUnmarshaller
    {
        public static DescribeInstanceDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceDetailsResponse describeInstanceDetailsResponse = new DescribeInstanceDetailsResponse();

			describeInstanceDetailsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceDetailsResponse.RequestId = _ctx.StringValue("DescribeInstanceDetails.RequestId");

			List<DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail> describeInstanceDetailsResponse_instanceDetails = new List<DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceDetails.InstanceDetails.Length"); i++) {
				DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail instanceDetail = new DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail();
				instanceDetail.InstanceId = _ctx.StringValue("DescribeInstanceDetails.InstanceDetails["+ i +"].InstanceId");
				instanceDetail.Line = _ctx.StringValue("DescribeInstanceDetails.InstanceDetails["+ i +"].Line");

				List<DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail.DescribeInstanceDetails_EipInfo> instanceDetail_eipInfos = new List<DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail.DescribeInstanceDetails_EipInfo>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceDetails.InstanceDetails["+ i +"].EipInfos.Length"); j++) {
					DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail.DescribeInstanceDetails_EipInfo eipInfo = new DescribeInstanceDetailsResponse.DescribeInstanceDetails_InstanceDetail.DescribeInstanceDetails_EipInfo();
					eipInfo.Eip = _ctx.StringValue("DescribeInstanceDetails.InstanceDetails["+ i +"].EipInfos["+ j +"].Eip");
					eipInfo.Status = _ctx.StringValue("DescribeInstanceDetails.InstanceDetails["+ i +"].EipInfos["+ j +"].Status");

					instanceDetail_eipInfos.Add(eipInfo);
				}
				instanceDetail.EipInfos = instanceDetail_eipInfos;

				describeInstanceDetailsResponse_instanceDetails.Add(instanceDetail);
			}
			describeInstanceDetailsResponse.InstanceDetails = describeInstanceDetailsResponse_instanceDetails;
        
			return describeInstanceDetailsResponse;
        }
    }
}
