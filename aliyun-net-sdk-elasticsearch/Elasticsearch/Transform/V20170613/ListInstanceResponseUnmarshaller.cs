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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceResponse.RequestId = _ctx.StringValue("ListInstance.RequestId");

			ListInstanceResponse.ListInstance_Headers headers = new ListInstanceResponse.ListInstance_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListInstance.Headers.X-Total-Count");
			listInstanceResponse.Headers = headers;

			List<ListInstanceResponse.ListInstance_Instance> listInstanceResponse_result = new List<ListInstanceResponse.ListInstance_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstance.Result.Length"); i++) {
				ListInstanceResponse.ListInstance_Instance instance = new ListInstanceResponse.ListInstance_Instance();
				instance.AdvancedDedicateMaster = _ctx.BooleanValue("ListInstance.Result["+ i +"].advancedDedicateMaster");
				instance.NodeAmount = _ctx.IntegerValue("ListInstance.Result["+ i +"].nodeAmount");
				instance.CreatedAt = _ctx.StringValue("ListInstance.Result["+ i +"].createdAt");
				instance.Status = _ctx.StringValue("ListInstance.Result["+ i +"].status");
				instance.DedicateMaster = _ctx.BooleanValue("ListInstance.Result["+ i +"].dedicateMaster");
				instance.ServiceVpc = _ctx.BooleanValue("ListInstance.Result["+ i +"].serviceVpc");
				instance.PaymentType = _ctx.StringValue("ListInstance.Result["+ i +"].paymentType");
				instance.ResourceGroupId = _ctx.StringValue("ListInstance.Result["+ i +"].resourceGroupId");
				instance.PostpaidServiceStatus = _ctx.StringValue("ListInstance.Result["+ i +"].postpaidServiceStatus");
				instance.Description = _ctx.StringValue("ListInstance.Result["+ i +"].description");
				instance.EsVersion = _ctx.StringValue("ListInstance.Result["+ i +"].esVersion");
				instance.IsNewDeployment = _ctx.StringValue("ListInstance.Result["+ i +"].isNewDeployment");
				instance.UpdatedAt = _ctx.StringValue("ListInstance.Result["+ i +"].updatedAt");
				instance.InstanceId = _ctx.StringValue("ListInstance.Result["+ i +"].instanceId");
				instance.VpcInstanceId = _ctx.StringValue("ListInstance.Result["+ i +"].vpcInstanceId");
				instance.EndTime = _ctx.LongValue("ListInstance.Result["+ i +"].endTime");
				instance.ArchType = _ctx.StringValue("ListInstance.Result["+ i +"].archType");

				List<Dictionary<string, string>> instance_extendConfigs = new List<Dictionary<string, string>>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].ExtendConfigs.Length"); j++) {
					Dictionary<string, string> tmp = new Dictionary<string, string>() { };
					foreach (var _item in _ctx.ResponseDictionary){
						string prefix = "ListInstance.Result["+ i +"].ExtendConfigs["+ j +"].";
						if (_item.Key.IndexOf(prefix) == 0){
							tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
						}
					}
					if (tmp.Count > 0){
						instance_extendConfigs.Add(tmp);
					}
				}
				instance.ExtendConfigs = instance_extendConfigs;

				List<string> instance_kibanaIPWhitelist = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].KibanaIPWhitelist.Length"); j++) {
					instance_kibanaIPWhitelist.Add(_ctx.StringValue("ListInstance.Result["+ i +"].KibanaIPWhitelist["+ j +"]"));
				}
				instance.KibanaIPWhitelist = instance_kibanaIPWhitelist;

				List<string> instance_kibanaPrivateIPWhitelist = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].KibanaPrivateIPWhitelist.Length"); j++) {
					instance_kibanaPrivateIPWhitelist.Add(_ctx.StringValue("ListInstance.Result["+ i +"].KibanaPrivateIPWhitelist["+ j +"]"));
				}
				instance.KibanaPrivateIPWhitelist = instance_kibanaPrivateIPWhitelist;

				List<string> instance_publicIpWhitelist = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].PublicIpWhitelist.Length"); j++) {
					instance_publicIpWhitelist.Add(_ctx.StringValue("ListInstance.Result["+ i +"].PublicIpWhitelist["+ j +"]"));
				}
				instance.PublicIpWhitelist = instance_publicIpWhitelist;

				List<string> instance_privateNetworkIpWhiteList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].PrivateNetworkIpWhiteList.Length"); j++) {
					instance_privateNetworkIpWhiteList.Add(_ctx.StringValue("ListInstance.Result["+ i +"].PrivateNetworkIpWhiteList["+ j +"]"));
				}
				instance.PrivateNetworkIpWhiteList = instance_privateNetworkIpWhiteList;

				ListInstanceResponse.ListInstance_Instance.ListInstance_ClientNodeConfiguration clientNodeConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_ClientNodeConfiguration();
				clientNodeConfiguration.Spec = _ctx.StringValue("ListInstance.Result["+ i +"].ClientNodeConfiguration.spec");
				clientNodeConfiguration.Amount = _ctx.IntegerValue("ListInstance.Result["+ i +"].ClientNodeConfiguration.amount");
				clientNodeConfiguration.Disk = _ctx.IntegerValue("ListInstance.Result["+ i +"].ClientNodeConfiguration.disk");
				clientNodeConfiguration.DiskType = _ctx.StringValue("ListInstance.Result["+ i +"].ClientNodeConfiguration.diskType");
				clientNodeConfiguration.SpecInfo = _ctx.StringValue("ListInstance.Result["+ i +"].ClientNodeConfiguration.specInfo");
				instance.ClientNodeConfiguration = clientNodeConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_ElasticDataNodeConfiguration elasticDataNodeConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_ElasticDataNodeConfiguration();
				elasticDataNodeConfiguration.Spec = _ctx.StringValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.spec");
				elasticDataNodeConfiguration.Amount = _ctx.IntegerValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.amount");
				elasticDataNodeConfiguration.Disk = _ctx.IntegerValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.disk");
				elasticDataNodeConfiguration.DiskEncryption = _ctx.BooleanValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.diskEncryption");
				elasticDataNodeConfiguration.DiskType = _ctx.StringValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.diskType");
				elasticDataNodeConfiguration.SpecInfo = _ctx.StringValue("ListInstance.Result["+ i +"].ElasticDataNodeConfiguration.specInfo");
				instance.ElasticDataNodeConfiguration = elasticDataNodeConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration kibanaConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration();
				kibanaConfiguration.Spec = _ctx.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.spec");
				kibanaConfiguration.Amount = _ctx.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.amount");
				kibanaConfiguration.Disk = _ctx.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.disk");
				kibanaConfiguration.DiskType = _ctx.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.diskType");
				kibanaConfiguration.SpecInfo = _ctx.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.specInfo");
				instance.KibanaConfiguration = kibanaConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration masterConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration();
				masterConfiguration.Spec = _ctx.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.spec");
				masterConfiguration.Amount = _ctx.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.amount");
				masterConfiguration.Disk = _ctx.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.disk");
				masterConfiguration.DiskType = _ctx.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.diskType");
				masterConfiguration.SpecInfo = _ctx.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.specInfo");
				instance.MasterConfiguration = masterConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig networkConfig = new ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig();
				networkConfig.VpcId = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vpcId");
				networkConfig.VsArea = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vsArea");
				networkConfig.Type = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.type");
				networkConfig.VswitchId = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vswitchId");

				List<ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig.ListInstance_WhiteIpGroupListItem> networkConfig_whiteIpGroupList = new List<ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig.ListInstance_WhiteIpGroupListItem>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].NetworkConfig.WhiteIpGroupList.Length"); j++) {
					ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig.ListInstance_WhiteIpGroupListItem whiteIpGroupListItem = new ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig.ListInstance_WhiteIpGroupListItem();
					whiteIpGroupListItem.GroupName = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.WhiteIpGroupList["+ j +"].groupName");
					whiteIpGroupListItem.WhiteIpType = _ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.WhiteIpGroupList["+ j +"].whiteIpType");

					List<string> whiteIpGroupListItem_ips = new List<string>();
					for (int k = 0; k < _ctx.Length("ListInstance.Result["+ i +"].NetworkConfig.WhiteIpGroupList["+ j +"].Ips.Length"); k++) {
						whiteIpGroupListItem_ips.Add(_ctx.StringValue("ListInstance.Result["+ i +"].NetworkConfig.WhiteIpGroupList["+ j +"].Ips["+ k +"]"));
					}
					whiteIpGroupListItem.Ips = whiteIpGroupListItem_ips;

					networkConfig_whiteIpGroupList.Add(whiteIpGroupListItem);
				}
				networkConfig.WhiteIpGroupList = networkConfig_whiteIpGroupList;
				instance.NetworkConfig = networkConfig;

				ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec nodeSpec = new ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec();
				nodeSpec.Spec = _ctx.StringValue("ListInstance.Result["+ i +"].NodeSpec.spec");
				nodeSpec.Disk = _ctx.IntegerValue("ListInstance.Result["+ i +"].NodeSpec.disk");
				nodeSpec.DiskEncryption = _ctx.BooleanValue("ListInstance.Result["+ i +"].NodeSpec.diskEncryption");
				nodeSpec.DiskType = _ctx.StringValue("ListInstance.Result["+ i +"].NodeSpec.diskType");
				nodeSpec.PerformanceLevel = _ctx.StringValue("ListInstance.Result["+ i +"].NodeSpec.performanceLevel");
				nodeSpec.SpecInfo = _ctx.StringValue("ListInstance.Result["+ i +"].NodeSpec.specInfo");
				instance.NodeSpec = nodeSpec;

				List<ListInstanceResponse.ListInstance_Instance.ListInstance_Tag> instance_tags = new List<ListInstanceResponse.ListInstance_Instance.ListInstance_Tag>();
				for (int j = 0; j < _ctx.Length("ListInstance.Result["+ i +"].Tags.Length"); j++) {
					ListInstanceResponse.ListInstance_Instance.ListInstance_Tag tag = new ListInstanceResponse.ListInstance_Instance.ListInstance_Tag();
					tag.TagKey = _ctx.StringValue("ListInstance.Result["+ i +"].Tags["+ j +"].tagKey");
					tag.TagValue = _ctx.StringValue("ListInstance.Result["+ i +"].Tags["+ j +"].tagValue");

					instance_tags.Add(tag);
				}
				instance.Tags = instance_tags;

				listInstanceResponse_result.Add(instance);
			}
			listInstanceResponse.Result = listInstanceResponse_result;
        
			return listInstanceResponse;
        }
    }
}
