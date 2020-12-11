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
			result.InstanceId = _ctx.StringValue("DescribeInstance.Result.instanceId");
			result.Domain = _ctx.StringValue("DescribeInstance.Result.domain");
			result.Description = _ctx.StringValue("DescribeInstance.Result.description");
			result.NodeAmount = _ctx.IntegerValue("DescribeInstance.Result.nodeAmount");
			result.PaymentType = _ctx.StringValue("DescribeInstance.Result.paymentType");
			result.Status = _ctx.StringValue("DescribeInstance.Result.status");
			result.EsVersion = _ctx.StringValue("DescribeInstance.Result.esVersion");
			result.CreatedAt = _ctx.StringValue("DescribeInstance.Result.createdAt");
			result.UpdatedAt = _ctx.StringValue("DescribeInstance.Result.updatedAt");
			result.KibanaDomain = _ctx.StringValue("DescribeInstance.Result.kibanaDomain");
			result.EnablePublic = _ctx.BooleanValue("DescribeInstance.Result.enablePublic");
			result.DedicateMaster = _ctx.BooleanValue("DescribeInstance.Result.dedicateMaster");
			result.AdvancedDedicateMaster = _ctx.BooleanValue("DescribeInstance.Result.advancedDedicateMaster");
			result.PublicPort = _ctx.IntegerValue("DescribeInstance.Result.publicPort");
			result.KibanaPort = _ctx.IntegerValue("DescribeInstance.Result.kibanaPort");
			result.PublicDomain = _ctx.StringValue("DescribeInstance.Result.publicDomain");
			result.VpcInstanceId = _ctx.StringValue("DescribeInstance.Result.vpcInstanceId");
			result.Port = _ctx.IntegerValue("DescribeInstance.Result.port");
			result.EsConfig = _ctx.StringValue("DescribeInstance.Result.esConfig");
			result.ZoneCount = _ctx.IntegerValue("DescribeInstance.Result.zoneCount");
			result.HaveClientNode = _ctx.BooleanValue("DescribeInstance.Result.haveClientNode");
			result.WarmNode = _ctx.BooleanValue("DescribeInstance.Result.warmNode");
			result.Protocol = _ctx.StringValue("DescribeInstance.Result.protocol");
			result.EnableKibanaPublicNetwork = _ctx.BooleanValue("DescribeInstance.Result.enableKibanaPublicNetwork");
			result.HaveKibana = _ctx.BooleanValue("DescribeInstance.Result.haveKibana");
			result.ResourceGroupId = _ctx.StringValue("DescribeInstance.Result.resourceGroupId");
			result.EnableKibanaPrivateNetwork = _ctx.BooleanValue("DescribeInstance.Result.enableKibanaPrivateNetwork");

			List<string> result_esIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.EsIPWhitelist.Length"); i++) {
				result_esIPWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.EsIPWhitelist["+ i +"]"));
			}
			result.EsIPWhitelist = result_esIPWhitelist;

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

			List<string> result_publicIpWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.PublicIpWhitelist.Length"); i++) {
				result_publicIpWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.PublicIpWhitelist["+ i +"]"));
			}
			result.PublicIpWhitelist = result_publicIpWhitelist;

			List<string> result_privateNetworkIpWhiteList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.PrivateNetworkIpWhiteList.Length"); i++) {
				result_privateNetworkIpWhiteList.Add(_ctx.StringValue("DescribeInstance.Result.PrivateNetworkIpWhiteList["+ i +"]"));
			}
			result.PrivateNetworkIpWhiteList = result_privateNetworkIpWhiteList;

			List<string> result_kibanaPrivateIPWhitelist = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.KibanaPrivateIPWhitelist.Length"); i++) {
				result_kibanaPrivateIPWhitelist.Add(_ctx.StringValue("DescribeInstance.Result.KibanaPrivateIPWhitelist["+ i +"]"));
			}
			result.KibanaPrivateIPWhitelist = result_kibanaPrivateIPWhitelist;

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

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec nodeSpec = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("DescribeInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("DescribeInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("DescribeInstance.Result.NodeSpec.diskType");
			nodeSpec.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.NodeSpec.diskEncryption");
			result.NodeSpec = nodeSpec;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig networkConfig = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig();
			networkConfig.Type = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = _ctx.StringValue("DescribeInstance.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration kibanaConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.KibanaConfiguration.amount");
			result.KibanaConfiguration = kibanaConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration masterConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration();
			masterConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.MasterConfiguration.amount");
			masterConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.MasterConfiguration.disk");
			result.MasterConfiguration = masterConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration clientNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration();
			clientNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.ClientNodeConfiguration.spec");
			clientNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.amount");
			clientNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.ClientNodeConfiguration.diskType");
			clientNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.disk");
			result.ClientNodeConfiguration = clientNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration warmNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration();
			warmNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.WarmNodeConfiguration.spec");
			warmNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.amount");
			warmNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.WarmNodeConfiguration.diskType");
			warmNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.disk");
			warmNodeConfiguration.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.WarmNodeConfiguration.diskEncryption");
			result.WarmNodeConfiguration = warmNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting advancedSetting = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting();
			advancedSetting.GcName = _ctx.StringValue("DescribeInstance.Result.AdvancedSetting.gcName");
			result.AdvancedSetting = advancedSetting;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ElasticDataNodeConfiguration elasticDataNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ElasticDataNodeConfiguration();
			elasticDataNodeConfiguration.Spec = _ctx.StringValue("DescribeInstance.Result.ElasticDataNodeConfiguration.spec");
			elasticDataNodeConfiguration.Amount = _ctx.IntegerValue("DescribeInstance.Result.ElasticDataNodeConfiguration.amount");
			elasticDataNodeConfiguration.DiskType = _ctx.StringValue("DescribeInstance.Result.ElasticDataNodeConfiguration.diskType");
			elasticDataNodeConfiguration.Disk = _ctx.IntegerValue("DescribeInstance.Result.ElasticDataNodeConfiguration.disk");
			elasticDataNodeConfiguration.DiskEncryption = _ctx.BooleanValue("DescribeInstance.Result.ElasticDataNodeConfiguration.diskEncryption");
			result.ElasticDataNodeConfiguration = elasticDataNodeConfiguration;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem> result_dictList = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.DictList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem dictListItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem();
				dictListItem.Name = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].name");
				dictListItem.FileSize = _ctx.LongValue("DescribeInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.Type = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].type");
				dictListItem.SourceType = _ctx.StringValue("DescribeInstance.Result.DictList["+ i +"].sourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem> result_synonymsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.SynonymsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem synonymsDictsItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem();
				synonymsDictsItem.Name = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.FileSize = _ctx.LongValue("DescribeInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Type = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].type");
				synonymsDictsItem.SourceType = _ctx.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].sourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo> result_zoneInfos = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.ZoneInfos.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo zoneInfo = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo();
				zoneInfo.ZoneId = _ctx.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].zoneId");
				zoneInfo.Status = _ctx.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].status");

				result_zoneInfos.Add(zoneInfo);
			}
			result.ZoneInfos = result_zoneInfos;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict> result_aliwsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.Result.AliwsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict dict = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict();
				dict.Name = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].name");
				dict.FileSize = _ctx.LongValue("DescribeInstance.Result.AliwsDicts["+ i +"].fileSize");
				dict.Type = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].type");
				dict.SourceType = _ctx.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].sourceType");

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
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
