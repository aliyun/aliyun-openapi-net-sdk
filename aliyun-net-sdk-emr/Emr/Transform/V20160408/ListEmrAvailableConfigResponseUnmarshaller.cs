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
    public class ListEmrAvailableConfigResponseUnmarshaller
    {
        public static ListEmrAvailableConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEmrAvailableConfigResponse listEmrAvailableConfigResponse = new ListEmrAvailableConfigResponse();

			listEmrAvailableConfigResponse.HttpResponse = _ctx.HttpResponse;
			listEmrAvailableConfigResponse.RequestId = _ctx.StringValue("ListEmrAvailableConfig.RequestId");

			List<string> listEmrAvailableConfigResponse_keyPairNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("ListEmrAvailableConfig.KeyPairNameList.Length"); i++) {
				listEmrAvailableConfigResponse_keyPairNameList.Add(_ctx.StringValue("ListEmrAvailableConfig.KeyPairNameList["+ i +"]"));
			}
			listEmrAvailableConfigResponse.KeyPairNameList = listEmrAvailableConfigResponse_keyPairNameList;

			List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion> listEmrAvailableConfigResponse_emrMainVersionList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion>();
			for (int i = 0; i < _ctx.Length("ListEmrAvailableConfig.EmrMainVersionList.Length"); i++) {
				ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion emrMainVersion = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion();
				emrMainVersion.RegionId = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].RegionId");
				emrMainVersion.MainVersionName = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].MainVersionName");
				emrMainVersion.EcmVersion = _ctx.BooleanValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].EcmVersion");
				emrMainVersion.StackName = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].StackName");
				emrMainVersion.StackVersion = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].StackVersion");
				emrMainVersion.ExtraInfo = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ExtraInfo");
				emrMainVersion.OnCloudNative = _ctx.BooleanValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].OnCloudNative");
				emrMainVersion.PublishType = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].PublishType");

				List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo> emrMainVersion_clusterTypeInfoList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo>();
				for (int j = 0; j < _ctx.Length("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList.Length"); j++) {
					ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo clusterTypeInfo = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo();
					clusterTypeInfo.ClusterType = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterType");

					List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo.ListEmrAvailableConfig_ClusterServiceInfo> clusterTypeInfo_clusterServiceInfoList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo.ListEmrAvailableConfig_ClusterServiceInfo>();
					for (int k = 0; k < _ctx.Length("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterServiceInfoList.Length"); k++) {
						ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo.ListEmrAvailableConfig_ClusterServiceInfo clusterServiceInfo = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_EmrMainVersion.ListEmrAvailableConfig_ClusterTypeInfo.ListEmrAvailableConfig_ClusterServiceInfo();
						clusterServiceInfo.ServiceName = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterServiceInfoList["+ k +"].ServiceName");
						clusterServiceInfo.ServiceDisplayName = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterServiceInfoList["+ k +"].ServiceDisplayName");
						clusterServiceInfo.ServiceVersion = _ctx.StringValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterServiceInfoList["+ k +"].ServiceVersion");
						clusterServiceInfo.Mandatory = _ctx.BooleanValue("ListEmrAvailableConfig.EmrMainVersionList["+ i +"].ClusterTypeInfoList["+ j +"].ClusterServiceInfoList["+ k +"].Mandatory");

						clusterTypeInfo_clusterServiceInfoList.Add(clusterServiceInfo);
					}
					clusterTypeInfo.ClusterServiceInfoList = clusterTypeInfo_clusterServiceInfoList;

					emrMainVersion_clusterTypeInfoList.Add(clusterTypeInfo);
				}
				emrMainVersion.ClusterTypeInfoList = emrMainVersion_clusterTypeInfoList;

				listEmrAvailableConfigResponse_emrMainVersionList.Add(emrMainVersion);
			}
			listEmrAvailableConfigResponse.EmrMainVersionList = listEmrAvailableConfigResponse_emrMainVersionList;

			List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_SecurityGroup> listEmrAvailableConfigResponse_securityGroupList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_SecurityGroup>();
			for (int i = 0; i < _ctx.Length("ListEmrAvailableConfig.SecurityGroupList.Length"); i++) {
				ListEmrAvailableConfigResponse.ListEmrAvailableConfig_SecurityGroup securityGroup = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_SecurityGroup();
				securityGroup.SecurityGroupId = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].SecurityGroupId");
				securityGroup.Description = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].Description");
				securityGroup.SecurityGroupName = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].SecurityGroupName");
				securityGroup.VpcId = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].VpcId");
				securityGroup.CreationTime = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].CreationTime");
				securityGroup.SecurityGroupType = _ctx.StringValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].SecurityGroupType");
				securityGroup.AvailableInstanceAmount = _ctx.IntegerValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].AvailableInstanceAmount");
				securityGroup.EcsCount = _ctx.IntegerValue("ListEmrAvailableConfig.SecurityGroupList["+ i +"].EcsCount");

				listEmrAvailableConfigResponse_securityGroupList.Add(securityGroup);
			}
			listEmrAvailableConfigResponse.SecurityGroupList = listEmrAvailableConfigResponse_securityGroupList;

			List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo> listEmrAvailableConfigResponse_vpcInfoList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo>();
			for (int i = 0; i < _ctx.Length("ListEmrAvailableConfig.VpcInfoList.Length"); i++) {
				ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo vpcInfo = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo();
				vpcInfo.VpcId = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VpcId");
				vpcInfo.VpcName = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VpcName");
				vpcInfo.CidrBlock = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].CidrBlock");
				vpcInfo.CreationTime = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].CreationTime");
				vpcInfo.VRouterId = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VRouterId");
				vpcInfo.Description = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].Description");

				List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo.ListEmrAvailableConfig_VswitchInfo> vpcInfo_vswitchInfoList = new List<ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo.ListEmrAvailableConfig_VswitchInfo>();
				for (int j = 0; j < _ctx.Length("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList.Length"); j++) {
					ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo.ListEmrAvailableConfig_VswitchInfo vswitchInfo = new ListEmrAvailableConfigResponse.ListEmrAvailableConfig_VpcInfo.ListEmrAvailableConfig_VswitchInfo();
					vswitchInfo.VpcId = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].VpcId");
					vswitchInfo.VswitchId = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].VswitchId");
					vswitchInfo.VswitchName = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].VswitchName");
					vswitchInfo.ZoneId = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].ZoneId");
					vswitchInfo.CidrBlock = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].CidrBlock");
					vswitchInfo.AvailableIpAddressCount = _ctx.LongValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].AvailableIpAddressCount");
					vswitchInfo.Description = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].Description");
					vswitchInfo.CreationTime = _ctx.StringValue("ListEmrAvailableConfig.VpcInfoList["+ i +"].VswitchInfoList["+ j +"].CreationTime");

					vpcInfo_vswitchInfoList.Add(vswitchInfo);
				}
				vpcInfo.VswitchInfoList = vpcInfo_vswitchInfoList;

				listEmrAvailableConfigResponse_vpcInfoList.Add(vpcInfo);
			}
			listEmrAvailableConfigResponse.VpcInfoList = listEmrAvailableConfigResponse_vpcInfoList;
        
			return listEmrAvailableConfigResponse;
        }
    }
}
