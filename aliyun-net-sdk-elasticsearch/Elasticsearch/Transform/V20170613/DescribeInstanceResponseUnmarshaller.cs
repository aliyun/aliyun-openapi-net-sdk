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
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = context.HttpResponse;
			describeInstanceResponse.RequestId = context.StringValue("DescribeInstance.RequestId");

			DescribeInstanceResponse.DescribeInstance_Result result = new DescribeInstanceResponse.DescribeInstance_Result();
			result.InstanceId = context.StringValue("DescribeInstance.Result.instanceId");
			result.Domain = context.StringValue("DescribeInstance.Result.domain");
			result.Description = context.StringValue("DescribeInstance.Result.description");
			result.NodeAmount = context.IntegerValue("DescribeInstance.Result.nodeAmount");
			result.PaymentType = context.StringValue("DescribeInstance.Result.paymentType");
			result.Status = context.StringValue("DescribeInstance.Result.status");
			result.EsVersion = context.StringValue("DescribeInstance.Result.esVersion");
			result.CreatedAt = context.StringValue("DescribeInstance.Result.createdAt");
			result.UpdatedAt = context.StringValue("DescribeInstance.Result.updatedAt");
			result.KibanaDomain = context.StringValue("DescribeInstance.Result.kibanaDomain");
			result.EnablePublic = context.BooleanValue("DescribeInstance.Result.enablePublic");
			result.DedicateMaster = context.BooleanValue("DescribeInstance.Result.dedicateMaster");
			result.AdvancedDedicateMaster = context.BooleanValue("DescribeInstance.Result.advancedDedicateMaster");
			result.PublicPort = context.IntegerValue("DescribeInstance.Result.publicPort");
			result.KibanaPort = context.IntegerValue("DescribeInstance.Result.kibanaPort");
			result.PublicDomain = context.StringValue("DescribeInstance.Result.publicDomain");
			result.VpcInstanceId = context.StringValue("DescribeInstance.Result.vpcInstanceId");
			result.Port = context.IntegerValue("DescribeInstance.Result.port");
			result.EsConfig = context.StringValue("DescribeInstance.Result.esConfig");
			result.ZoneCount = context.IntegerValue("DescribeInstance.Result.zoneCount");
			result.HaveClientNode = context.BooleanValue("DescribeInstance.Result.haveClientNode");
			result.WarmNode = context.BooleanValue("DescribeInstance.Result.warmNode");
			result.Protocol = context.StringValue("DescribeInstance.Result.protocol");
			result.EnableKibanaPublicNetwork = context.BooleanValue("DescribeInstance.Result.enableKibanaPublicNetwork");
			result.HaveKibana = context.BooleanValue("DescribeInstance.Result.haveKibana");
			result.ResourceGroupId = context.StringValue("DescribeInstance.Result.resourceGroupId");
			result.EnableKibanaPrivateNetwork = context.BooleanValue("DescribeInstance.Result.enableKibanaPrivateNetwork");

			List<string> result_esIPWhitelist = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.EsIPWhitelist.Length"); i++) {
				result_esIPWhitelist.Add(context.StringValue("DescribeInstance.Result.EsIPWhitelist["+ i +"]"));
			}
			result.EsIPWhitelist = result_esIPWhitelist;

			List<string> result_esIPBlacklist = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.EsIPBlacklist.Length"); i++) {
				result_esIPBlacklist.Add(context.StringValue("DescribeInstance.Result.EsIPBlacklist["+ i +"]"));
			}
			result.EsIPBlacklist = result_esIPBlacklist;

			List<string> result_kibanaIPWhitelist = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.KibanaIPWhitelist.Length"); i++) {
				result_kibanaIPWhitelist.Add(context.StringValue("DescribeInstance.Result.KibanaIPWhitelist["+ i +"]"));
			}
			result.KibanaIPWhitelist = result_kibanaIPWhitelist;

			List<string> result_publicIpWhitelist = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.PublicIpWhitelist.Length"); i++) {
				result_publicIpWhitelist.Add(context.StringValue("DescribeInstance.Result.PublicIpWhitelist["+ i +"]"));
			}
			result.PublicIpWhitelist = result_publicIpWhitelist;

			List<string> result_privateNetworkIpWhiteList = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.PrivateNetworkIpWhiteList.Length"); i++) {
				result_privateNetworkIpWhiteList.Add(context.StringValue("DescribeInstance.Result.PrivateNetworkIpWhiteList["+ i +"]"));
			}
			result.PrivateNetworkIpWhiteList = result_privateNetworkIpWhiteList;

			List<string> result_kibanaPrivateIPWhitelist = new List<string>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.KibanaPrivateIPWhitelist.Length"); i++) {
				result_kibanaPrivateIPWhitelist.Add(context.StringValue("DescribeInstance.Result.KibanaPrivateIPWhitelist["+ i +"]"));
			}
			result.KibanaPrivateIPWhitelist = result_kibanaPrivateIPWhitelist;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec nodeSpec = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("DescribeInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = context.IntegerValue("DescribeInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = context.StringValue("DescribeInstance.Result.NodeSpec.diskType");
			nodeSpec.DiskEncryption = context.BooleanValue("DescribeInstance.Result.NodeSpec.diskEncryption");
			result.NodeSpec = nodeSpec;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig networkConfig = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("DescribeInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = context.StringValue("DescribeInstance.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = context.StringValue("DescribeInstance.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = context.StringValue("DescribeInstance.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration kibanaConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("DescribeInstance.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.KibanaConfiguration.amount");
			result.KibanaConfiguration = kibanaConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration masterConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("DescribeInstance.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.MasterConfiguration.amount");
			masterConfiguration.DiskType = context.StringValue("DescribeInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.MasterConfiguration.disk");
			result.MasterConfiguration = masterConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration clientNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration();
			clientNodeConfiguration.Spec = context.StringValue("DescribeInstance.Result.ClientNodeConfiguration.spec");
			clientNodeConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.amount");
			clientNodeConfiguration.DiskType = context.StringValue("DescribeInstance.Result.ClientNodeConfiguration.diskType");
			clientNodeConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.disk");
			result.ClientNodeConfiguration = clientNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration warmNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration();
			warmNodeConfiguration.Spec = context.StringValue("DescribeInstance.Result.WarmNodeConfiguration.spec");
			warmNodeConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.amount");
			warmNodeConfiguration.DiskType = context.StringValue("DescribeInstance.Result.WarmNodeConfiguration.diskType");
			warmNodeConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.disk");
			warmNodeConfiguration.DiskEncryption = context.BooleanValue("DescribeInstance.Result.WarmNodeConfiguration.diskEncryption");
			result.WarmNodeConfiguration = warmNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting advancedSetting = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_AdvancedSetting();
			advancedSetting.GcName = context.StringValue("DescribeInstance.Result.AdvancedSetting.gcName");
			result.AdvancedSetting = advancedSetting;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem> result_dictList = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.DictList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem dictListItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem();
				dictListItem.Name = context.StringValue("DescribeInstance.Result.DictList["+ i +"].name");
				dictListItem.FileSize = context.LongValue("DescribeInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.Type = context.StringValue("DescribeInstance.Result.DictList["+ i +"].type");
				dictListItem.SourceType = context.StringValue("DescribeInstance.Result.DictList["+ i +"].sourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem> result_synonymsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.SynonymsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem synonymsDictsItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.FileSize = context.LongValue("DescribeInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Type = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].type");
				synonymsDictsItem.SourceType = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].sourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo> result_zoneInfos = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.ZoneInfos.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo zoneInfo = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo();
				zoneInfo.ZoneId = context.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].zoneId");
				zoneInfo.Status = context.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].status");

				result_zoneInfos.Add(zoneInfo);
			}
			result.ZoneInfos = result_zoneInfos;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict> result_aliwsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.AliwsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict dict = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Dict();
				dict.Name = context.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].name");
				dict.FileSize = context.LongValue("DescribeInstance.Result.AliwsDicts["+ i +"].fileSize");
				dict.Type = context.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].type");
				dict.SourceType = context.StringValue("DescribeInstance.Result.AliwsDicts["+ i +"].sourceType");

				result_aliwsDicts.Add(dict);
			}
			result.AliwsDicts = result_aliwsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag> result_tags = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.Tags.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag tag = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_Tag();
				tag.TagKey = context.StringValue("DescribeInstance.Result.Tags["+ i +"].tagKey");
				tag.TagValue = context.StringValue("DescribeInstance.Result.Tags["+ i +"].tagValue");

				result_tags.Add(tag);
			}
			result.Tags = result_tags;
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
