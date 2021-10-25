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
        public static DescribeEmrMainVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEmrMainVersionResponse describeEmrMainVersionResponse = new DescribeEmrMainVersionResponse();

			describeEmrMainVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeEmrMainVersionResponse.RequestId = _ctx.StringValue("DescribeEmrMainVersion.RequestId");

			DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion emrMainVersion = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion();
			emrMainVersion.RegionId = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.RegionId");
			emrMainVersion.EmrVersion = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.EmrVersion");
			emrMainVersion.EcmVersion = _ctx.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.EcmVersion");
			emrMainVersion.ImageId = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ImageId");
			emrMainVersion.Display = _ctx.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.Display");
			emrMainVersion.StackName = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.StackName");
			emrMainVersion.StackVersion = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.StackVersion");
			emrMainVersion.PublishType = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.PublishType");

			List<string> emrMainVersion_whiteUserList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeEmrMainVersion.EmrMainVersion.WhiteUserList.Length"); i++) {
				emrMainVersion_whiteUserList.Add(_ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.WhiteUserList["+ i +"]"));
			}
			emrMainVersion.WhiteUserList = emrMainVersion_whiteUserList;

			List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo> emrMainVersion_clusterTypeInfoList = new List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo>();
			for (int i = 0; i < _ctx.Length("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList.Length"); i++) {
				DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo clusterTypeInfo = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo();
				clusterTypeInfo.ClusterType = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ClusterType");

				List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo> clusterTypeInfo_serviceInfoList = new List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo>();
				for (int j = 0; j < _ctx.Length("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList.Length"); j++) {
					DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo serviceInfo = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeInfo.DescribeEmrMainVersion_ServiceInfo();
					serviceInfo.ServiceName = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceName");
					serviceInfo.ServiceDisplayName = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceDisplayName");
					serviceInfo.ServiceVersion = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceVersion");
					serviceInfo.ServiceDisplayVersion = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].ServiceDisplayVersion");
					serviceInfo.Mandatory = _ctx.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].Mandatory");
					serviceInfo.Display = _ctx.BooleanValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeInfoList["+ i +"].ServiceInfoList["+ j +"].Display");

					clusterTypeInfo_serviceInfoList.Add(serviceInfo);
				}
				clusterTypeInfo.ServiceInfoList = clusterTypeInfo_serviceInfoList;

				emrMainVersion_clusterTypeInfoList.Add(clusterTypeInfo);
			}
			emrMainVersion.ClusterTypeInfoList = emrMainVersion_clusterTypeInfoList;

			List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeWhiteUser> emrMainVersion_clusterTypeWhiteUserList = new List<DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeWhiteUser>();
			for (int i = 0; i < _ctx.Length("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeWhiteUserList.Length"); i++) {
				DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeWhiteUser clusterTypeWhiteUser = new DescribeEmrMainVersionResponse.DescribeEmrMainVersion_EmrMainVersion.DescribeEmrMainVersion_ClusterTypeWhiteUser();
				clusterTypeWhiteUser.ClusterType = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeWhiteUserList["+ i +"].ClusterType");
				clusterTypeWhiteUser.UserId = _ctx.StringValue("DescribeEmrMainVersion.EmrMainVersion.ClusterTypeWhiteUserList["+ i +"].UserId");

				emrMainVersion_clusterTypeWhiteUserList.Add(clusterTypeWhiteUser);
			}
			emrMainVersion.ClusterTypeWhiteUserList = emrMainVersion_clusterTypeWhiteUserList;
			describeEmrMainVersionResponse.EmrMainVersion = emrMainVersion;
        
			return describeEmrMainVersionResponse;
        }
    }
}
