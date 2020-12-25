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
    public class ListEmrMainVersionResponseUnmarshaller
    {
        public static ListEmrMainVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmrMainVersionResponse listEmrMainVersionResponse = new ListEmrMainVersionResponse();

			listEmrMainVersionResponse.HttpResponse = _ctx.HttpResponse;
			listEmrMainVersionResponse.RequestId = _ctx.StringValue("ListEmrMainVersion.RequestId");
			listEmrMainVersionResponse.TotalCount = _ctx.IntegerValue("ListEmrMainVersion.TotalCount");
			listEmrMainVersionResponse.PageNumber = _ctx.IntegerValue("ListEmrMainVersion.PageNumber");
			listEmrMainVersionResponse.PageSize = _ctx.IntegerValue("ListEmrMainVersion.PageSize");

			List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion> listEmrMainVersionResponse_emrMainVersionList = new List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion>();
			for (int i = 0; i < _ctx.Length("ListEmrMainVersion.EmrMainVersionList.Length"); i++) {
				ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion emrMainVersion = new ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion();
				emrMainVersion.RegionId = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].RegionId");
				emrMainVersion.EmrVersion = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].EmrVersion");
				emrMainVersion.EcmVersion = _ctx.BooleanValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].EcmVersion");
				emrMainVersion.ImageId = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ImageId");
				emrMainVersion.Display = _ctx.BooleanValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].Display");
				emrMainVersion.StackName = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].StackName");
				emrMainVersion.StackVersion = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].StackVersion");
				emrMainVersion.PublishType = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].PublishType");

				List<string> emrMainVersion_whiteUserList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEmrMainVersion.EmrMainVersionList["+ i +"].WhiteUserList.Length"); j++) {
					emrMainVersion_whiteUserList.Add(_ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].WhiteUserList["+ j +"]"));
				}
				emrMainVersion.WhiteUserList = emrMainVersion_whiteUserList;

				List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo> emrMainVersion_clusterTypeInfoList = new List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo>();
				for (int j = 0; j < _ctx.Length("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList.Length"); j++) {
					ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo clusterTypeInfo = new ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo();
					clusterTypeInfo.ClusterType = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterType");

					List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo.ListEmrMainVersion_ServiceInfo> clusterTypeInfo_serviceInfoList = new List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo.ListEmrMainVersion_ServiceInfo>();
					for (int k = 0; k < _ctx.Length("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList.Length"); k++) {
						ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo.ListEmrMainVersion_ServiceInfo serviceInfo = new ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeInfo.ListEmrMainVersion_ServiceInfo();
						serviceInfo.ServiceName = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].ServiceName");
						serviceInfo.ServiceDisplayName = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].ServiceDisplayName");
						serviceInfo.ServiceVersion = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].ServiceVersion");
						serviceInfo.ServiceDisplayVersion = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].ServiceDisplayVersion");
						serviceInfo.Mandatory = _ctx.BooleanValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].Mandatory");
						serviceInfo.Display = _ctx.BooleanValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ServiceInfoList["+ k +"].Display");

						clusterTypeInfo_serviceInfoList.Add(serviceInfo);
					}
					clusterTypeInfo.ServiceInfoList = clusterTypeInfo_serviceInfoList;

					emrMainVersion_clusterTypeInfoList.Add(clusterTypeInfo);
				}
				emrMainVersion.ClusterTypeInfoList = emrMainVersion_clusterTypeInfoList;

				List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeWhiteUser> emrMainVersion_clusterTypeWhiteUserList = new List<ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeWhiteUser>();
				for (int j = 0; j < _ctx.Length("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeWhiteUserList.Length"); j++) {
					ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeWhiteUser clusterTypeWhiteUser = new ListEmrMainVersionResponse.ListEmrMainVersion_EmrMainVersion.ListEmrMainVersion_ClusterTypeWhiteUser();
					clusterTypeWhiteUser.ClusterType = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeWhiteUserList["+ j +"].ClusterType");
					clusterTypeWhiteUser.UserId = _ctx.StringValue("ListEmrMainVersion.EmrMainVersionList["+ i +"].ClusterTypeWhiteUserList["+ j +"].UserId");

					emrMainVersion_clusterTypeWhiteUserList.Add(clusterTypeWhiteUser);
				}
				emrMainVersion.ClusterTypeWhiteUserList = emrMainVersion_clusterTypeWhiteUserList;

				listEmrMainVersionResponse_emrMainVersionList.Add(emrMainVersion);
			}
			listEmrMainVersionResponse.EmrMainVersionList = listEmrMainVersionResponse_emrMainVersionList;
        
			return listEmrMainVersionResponse;
        }
    }
}
