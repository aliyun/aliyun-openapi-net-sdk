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
    public class DescribeEmrMainVersionResponseUnmarshaller
    {
        public static DescribeEmrMainVersionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEmrMainVersionResponse describeEmrMainVersionResponse = new DescribeEmrMainVersionResponse();

			describeEmrMainVersionResponse.HttpResponse = context.HttpResponse;
			describeEmrMainVersionResponse.RequestId = context.StringValue("DescribeEmrMainVersion.RequestId");

			DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion emrMainVersion = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion();
			emrMainVersion.RegionId = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.RegionId");
			emrMainVersion.EmrVersion = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.EmrVersion");
			emrMainVersion.EcmVersion = context.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.EcmVersion");
			emrMainVersion.ImageId = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ImageId");
			emrMainVersion.Display = context.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.Display");
			emrMainVersion.StackName = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.StackName");
			emrMainVersion.StackVersion = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.StackVersion");

			List<string> emrMainVersion_whiteUserList = new List<string>();
			for (int i = 0; i < context.Length("DescribeEmrMainVersion.EmrMainVersion.WhiteUserList.Length"); i++) {
				emrMainVersion_whiteUserList.Add(context.StringValue("DescribeEmrMainVersion.EmrMainVersion.WhiteUserList["+ i +"]"));
			}
			emrMainVersion.WhiteUserList = emrMainVersion_whiteUserList;

			List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo> emrMainVersion_clusterTypeInfoList = new List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo>();
			for (int i = 0; i < context.Length("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList.Length"); i++) {
				DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo clusterTypeInfo = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo();
				clusterTypeInfo.ClusterType = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ClusterType");

				List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo> clusterTypeInfo_serviceInfoList = new List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo>();
				for (int j = 0; j < context.Length("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList.Length"); j++) {
					DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo serviceInfo = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo();
					serviceInfo.ServiceName = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceName");
					serviceInfo.ServiceDisplayName = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceDisplayName");
					serviceInfo.ServiceVersion = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceVersion");
					serviceInfo.ServiceDisplayVersion = context.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceDisplayVersion");
					serviceInfo.Mandatory = context.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].Mandatory");
					serviceInfo.Display = context.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].Display");

					clusterTypeInfo_serviceInfoList.Add(serviceInfo);
				}
				clusterTypeInfo.ServiceInfoList = clusterTypeInfo_serviceInfoList;

				emrMainVersion_clusterTypeInfoList.Add(clusterTypeInfo);
			}
			emrMainVersion.ClusterTypeInfoList = emrMainVersion_clusterTypeInfoList;
			describeEmrMainVersionResponse.EmrMainVersion = emrMainVersion;
        
			return describeEmrMainVersionResponse;
        }
    }
}
