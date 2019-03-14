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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeAvailableInstanceTypeResponseUnmarshaller
    {
        public static DescribeAvailableInstanceTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAvailableInstanceTypeResponse describeAvailableInstanceTypeResponse = new DescribeAvailableInstanceTypeResponse();

			describeAvailableInstanceTypeResponse.HttpResponse = context.HttpResponse;
			describeAvailableInstanceTypeResponse.RequestId = context.StringValue("DescribeAvailableInstanceType.RequestId");

			List<DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType> describeAvailableInstanceTypeResponse_emrSupportedInstanceTypeList = new List<DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType>();
			for (int i = 0; i < context.Length("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList.Length"); i++) {
				DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType emrSupportInstanceType = new DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType();
				emrSupportInstanceType.ClusterType = context.StringValue("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList["+ i +"].ClusterType");

				List<DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType.DescribeAvailableInstanceType_ClusterNodeTypeSupportInfo> emrSupportInstanceType_nodeTypeSupportInfoList = new List<DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType.DescribeAvailableInstanceType_ClusterNodeTypeSupportInfo>();
				for (int j = 0; j < context.Length("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList["+ i +"].NodeTypeSupportInfoList.Length"); j++) {
					DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType.DescribeAvailableInstanceType_ClusterNodeTypeSupportInfo clusterNodeTypeSupportInfo = new DescribeAvailableInstanceTypeResponse.DescribeAvailableInstanceType_EmrSupportInstanceType.DescribeAvailableInstanceType_ClusterNodeTypeSupportInfo();
					clusterNodeTypeSupportInfo.ClusterNodeType = context.StringValue("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList["+ i +"].NodeTypeSupportInfoList["+ j +"].ClusterNodeType");

					List<string> clusterNodeTypeSupportInfo_supportInstanceTypeList = new List<string>();
					for (int k = 0; k < context.Length("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList["+ i +"].NodeTypeSupportInfoList["+ j +"].SupportInstanceTypeList.Length"); k++) {
						clusterNodeTypeSupportInfo_supportInstanceTypeList.Add(context.StringValue("DescribeAvailableInstanceType.EmrSupportedInstanceTypeList["+ i +"].NodeTypeSupportInfoList["+ j +"].SupportInstanceTypeList["+ k +"]"));
					}
					clusterNodeTypeSupportInfo.SupportInstanceTypeList = clusterNodeTypeSupportInfo_supportInstanceTypeList;

					emrSupportInstanceType_nodeTypeSupportInfoList.Add(clusterNodeTypeSupportInfo);
				}
				emrSupportInstanceType.NodeTypeSupportInfoList = emrSupportInstanceType_nodeTypeSupportInfoList;

				describeAvailableInstanceTypeResponse_emrSupportedInstanceTypeList.Add(emrSupportInstanceType);
			}
			describeAvailableInstanceTypeResponse.EmrSupportedInstanceTypeList = describeAvailableInstanceTypeResponse_emrSupportedInstanceTypeList;
        
			return describeAvailableInstanceTypeResponse;
        }
    }
}
