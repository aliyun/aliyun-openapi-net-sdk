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
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");

			DescribeInstanceResponse.DescribeInstance_Result result = new DescribeInstanceResponse.DescribeInstance_Result();
			result.AdvancedDedicateMaster = _ctx.BooleanValue("DescribeInstance.Result.advancedDedicateMaster");
			result.Protocol = _ctx.StringValue("DescribeInstance.Result.protocol");
			result.EnableKibanaPublicNetwork = _ctx.BooleanValue("DescribeInstance.Result.enableKibanaPublicNetwork");
			result.NodeAmount = _ctx.IntegerValue("DescribeInstance.Result.nodeAmount");
			result.CreatedAt = _ctx.StringValue("DescribeInstance.Result.createdAt");
			result.EnableKibanaPrivateNetwork = _ctx.BooleanValue("DescribeInstance.Result.enableKibanaPrivateNetwork");
			result.VpcInstanceId = _ctx.StringValue("DescribeInstance.Result.vpcInstanceId");
			result.Port = _ctx.IntegerValue("DescribeInstance.Result.port");
			result.EnablePublic = _ctx.BooleanValue("DescribeInstance.Result.enablePublic");
			result.DedicateMaster = _ctx.BooleanValue("DescribeInstance.Result.dedicateMaster");
			result.KibanaPort = _ctx.IntegerValue("DescribeInstance.Result.kibanaPort");
			result.EsConfig = _ctx.StringValue("DescribeInstance.Result.esConfig");
			result.ResourceGroupId = _ctx.StringValue("DescribeInstance.Result.resourceGroupId");
			result.PaymentType = _ctx.StringValue("DescribeInstance.Result.paymentType");
			result.PostpaidServiceStatus = _ctx.StringValue("DescribeInstance.Result.postpaidServiceStatus");
			result.EsVersion = _ctx.StringValue("DescribeInstance.Result.esVersion");
			result.HaveKibana = _ctx.BooleanValue("DescribeInstance.Result.haveKibana");
			result.IsNewDeployment = _ctx.BooleanValue("DescribeInstance.Result.isNewDeployment");
			result.WarmNode = _ctx.BooleanValue("DescribeInstance.Result.warmNode");
			result.UpdatedAt = _ctx.StringValue("DescribeInstance.Result.updatedAt");
			result.InstanceId = _ctx.StringValue("DescribeInstance.Result.instanceId");
			result.ZoneCount = _ctx.IntegerValue("DescribeInstance.Result.zoneCount");
			result.PublicDomain = _ctx.StringValue("DescribeInstance.Result.publicDomain");
			result.Status = _ctx.StringValue("DescribeInstance.Result.status");
			result.ServiceVpc = _ctx.BooleanValue("DescribeInstance.Result.serviceVpc");
			result.PublicPort = _ctx.IntegerValue("DescribeInstance.Result.publicPort");
			result.HaveClientNode = _ctx.BooleanValue("DescribeInstance.Result.haveClientNode");
			result.Domain = _ctx.StringValue("DescribeInstance.Result.domain");
			result.Description = _ctx.StringValue("DescribeInstance.Result.description");
			result.KibanaDomain = _ctx.StringValue("DescribeInstance.Result.kibanaDomain");
			result.InstanceCategory = _ctx.StringValue("DescribeInstance.Result.instanceCategory");
			result.Endtime = _ctx.LongValue("DescribeInstance.Result.endtime");
			result.ArchType = _ctx.StringValue("DescribeInstance.Result.archType");

			List<string> result_esIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.EsIPWhitelist.Length"); i++) {
				result_esIPWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.EsIPWhitelist["+ i +"]"));
			}
			result.EsIPWhitelist = result_esIPWhitelist;

			List<Dictionary<string, string>> result_extendConfigs = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.ExtendConfigs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "DescribeInstance.Result.ExtendConfigs["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					result_extendConfigs.Add(tmp);
				}
			}
			result.ExtendConfigs = result_extendConfigs;

			List<string> result_privateNetworkIpWhiteList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.PrivateNetworkIpWhiteList.Length"); i++) {
				result_privateNetworkIpWhiteList.Add(_ctx.StringValue("DescribeInstance.Result.PrivateNetworkIpWhiteList["+ i +"]"));
			}
			result.PrivateNetworkIpWhiteList = result_privateNetworkIpWhiteList;

			List<string> result_publicIpWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.PublicIpWhitelist.Length"); i++) {
				result_publicIpWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.PublicIpWhitelist["+ i +"]"));
			}
			result.PublicIpWhitelist = result_publicIpWhitelist;

			List<string> result_kibanaPrivateIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.KibanaPrivateIPWhitelist.Length"); i++) {
				result_kibanaPrivateIPWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.KibanaPrivateIPWhitelist["+ i +"]"));
			}
			result.KibanaPrivateIPWhitelist = result_kibanaPrivateIPWhitelist;

			List<string> result_esIPBlacklist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.EsIPBlacklist.Length"); i++) {
				result_esIPBlacklist.Add(_ctx.StringValue("DescribeInstance.Result.EsIPBlacklist["+ i +"]"));
			}
			result.EsIPBlacklist = result_esIPBlacklist;

			List<string> result_kibanaIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.KibanaIPWhitelist.Length"); i++) {
				result_kibanaIPWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.KibanaIPWhitelist["+ i +"]"));
			}
			result.KibanaIPWhitelist = result_kibanaIPWhitelist;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec nodeSpec = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("DescribeInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("DescribeInstance.Result.NodeSpec.disk");
			nodeSpec.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.NodeSpec.diskEncryption");
			nodeSpec.DiskType = _ctx.StringValue("DescribeInstance.Result.NodeSpec.diskType");
			nodeSpec.PerformanceLevel = _ctx.StringValue("DescribeInstance.Result.NodeSpec.performanceLevel");
			nodeSpec.SpecInfo = _ctx.StringValue("DescribeInstance.Result.NodeSpec.specInfo");
			result.NodeSpec = nodeSpec;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig networkConfig = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig();
			networkConfig.VpcId = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vsArea");
			networkConfig.Type = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.type");
			networkConfig.VswitchId = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vswitchId");

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig.DescribeInstance_WhiteIpGroupListItem> networkConfig_whiteIpGroupList = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig.DescribeInstance_WhiteIpGroupListItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.NetworkConfig.WhiteIpGroupList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig.DescribeInstance_WhiteIpGroupListItem whiteIpGroupListItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig.DescribeInstance_WhiteIpGroupListItem();
				whiteIpGroupListItem.WhiteIpType = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.WhiteIpGroupList["+ i +"].whiteIpType");
				whiteIpGroupListItem.GroupName = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.WhiteIpGroupList["+ i +"].groupName");

				List<string> whiteIpGroupListItem_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstance.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips.Length"); j++) {
					whiteIpGroupListItem_ips.Add(_ctx.StringValue("DescribeInstance.Result.NetworkConfig.WhiteIpGroupList["+ i +"].Ips["+ j +"]"));
				}
				whiteIpGroupListItem.Ips = whiteIpGroupListItem_ips;

				networkConfig_whiteIpGroupList.Add(whiteIpGroupListItem);
			}
			networkConfig.WhiteIpGroupList = networkConfig_whiteIpGroupList;
			result.NetworkConfig = networkConfig;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration kibanaConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration();
			kibanaConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.KibanaConfiguration.amount");
			kibanaConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.KibanaConfiguration.disk");
			kibanaConfiguration.SpecInfo = _ctx.StringValue("DescribeInstance.Result.KibanaConfiguration.specInfo");
			result.KibanaConfiguration = kibanaConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration masterConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration();
			masterConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.MasterConfiguration.amount");
			masterConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.MasterConfiguration.disk");
			masterConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.SpecInfo = _ctx.StringValue("DescribeInstance.Result.MasterConfiguration.specInfo");
			result.MasterConfiguration = masterConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration clientNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration();
			clientNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.ClientNodeConfiguration.spec");
			clientNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.amount");
			clientNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.disk");
			clientNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.ClientNodeConfiguration.diskType");
			clientNodeConfiguration.SpecInfo = _ctx.StringValue("DescribeInstance.Result.ClientNodeConfiguration.specInfo");
			result.ClientNodeConfiguration = clientNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration warmNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration();
			warmNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.amount");
			warmNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.WarmNodeConfiguration.spec");
			warmNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.disk");
			warmNodeConfiguration.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.WarmNodeConfiguration.diskEncryption");
			warmNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.WarmNodeConfiguration.diskType");
			warmNodeConfiguration.SpecInfo = _ctx.StringValue("DescribeInstance.Result.WarmNodeConfiguration.specInfo");
			result.WarmNodeConfiguration = warmNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting advancedSetting = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting();
			advancedSetting.GcName = _ctx.StringValue("DescribeInstance.Result.AdvancedSetting.gcName");
			result.AdvancedSetting = advancedSetting;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ElasticDataNodeConfiguration elasticDataNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ElasticDataNodeConfiguration();
			elasticDataNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.ElasticDataNodeConfiguration.amount");
			elasticDataNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.ElasticDataNodeConfiguration.spec");
			elasticDataNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.ElasticDataNodeConfiguration.disk");
			elasticDataNodeConfiguration.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.ElasticDataNodeConfiguration.diskEncryption");
			elasticDataNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.ElasticDataNodeConfiguration.diskType");
			elasticDataNodeConfiguration.SpecInfo = _ctx.StringValue("DescribeInstance.Result.ElasticDataNodeConfiguration.specInfo");
			result.ElasticDataNodeConfiguration = elasticDataNodeConfiguration;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem> result_dictList = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.DictList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem dictListItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem();
				dictListItem.FileSize = _ctx.LongValue("DescribeInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.SourceType = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].sourceType");
				dictListItem.Name = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].name");
				dictListItem.Type = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].type");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem> result_synonymsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.SynonymsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem synonymsDictsItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem();
				synonymsDictsItem.FileSize = _ctx.LongValue("DescribeInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.SourceType = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].sourceType");
				synonymsDictsItem.Name = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.Type = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].type");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo> result_zoneInfos = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.ZoneInfos.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo zoneInfo = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo();
				zoneInfo.Status = _ctx.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].status");
				zoneInfo.ZoneId = _ctx.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].zoneId");

				result_zoneInfos.Add(zoneInfo);
			}
			result.ZoneInfos = result_zoneInfos;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict> result_aliwsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.AliwsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict dict = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict();
				dict.FileSize = _ctx.LongValue("DescribeInstance.Result.AliwsDicts["+ i +"].fileSize");
				dict.SourceType = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].sourceType");
				dict.Name = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].name");
				dict.Type = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].type");

				result_aliwsDicts.Add(dict);
			}
			result.AliwsDicts = result_aliwsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag> result_tags = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.Tags.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag tag = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag();
				tag.TagKey = _ctx.StringValue("DescribeInstance.Result.Tags["+ i +"].tagKey");
				tag.TagValue = _ctx.StringValue("DescribeInstance.Result.Tags["+ i +"].tagValue");

				result_tags.Add(tag);
			}
			result.Tags = result_tags;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_IkHotDictsItem> result_ikHotDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_IkHotDictsItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.IkHotDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_IkHotDictsItem ikHotDictsItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_IkHotDictsItem();
				ikHotDictsItem.Type = _ctx.StringValue("DescribeInstance.Result.IkHotDicts["+ i +"].type");
				ikHotDictsItem.SourceType = _ctx.StringValue("DescribeInstance.Result.IkHotDicts["+ i +"].sourceType");
				ikHotDictsItem.FileSize = _ctx.IntegerValue("DescribeInstance.Result.IkHotDicts["+ i +"].fileSize");
				ikHotDictsItem.Name = _ctx.StringValue("DescribeInstance.Result.IkHotDicts["+ i +"].name");

				result_ikHotDicts.Add(ikHotDictsItem);
			}
			result.IkHotDicts = result_ikHotDicts;
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
