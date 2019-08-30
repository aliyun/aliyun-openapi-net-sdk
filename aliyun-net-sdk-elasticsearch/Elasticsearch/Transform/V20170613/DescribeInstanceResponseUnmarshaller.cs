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
			result.InstanceId = context.StringValue("DescribeInstance.Result.InstanceId");
			result.Domain = context.StringValue("DescribeInstance.Result.Domain");
			result.Description = context.StringValue("DescribeInstance.Result.Description");
			result.NodeAmount = context.IntegerValue("DescribeInstance.Result.NodeAmount");
			result.PaymentType = context.StringValue("DescribeInstance.Result.PaymentType");
			result.Status = context.StringValue("DescribeInstance.Result.Status");
			result.EsVersion = context.StringValue("DescribeInstance.Result.EsVersion");
			result.CreatedAt = context.StringValue("DescribeInstance.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("DescribeInstance.Result.UpdatedAt");
			result.KibanaDomain = context.StringValue("DescribeInstance.Result.KibanaDomain");
			result.EnablePublic = context.BooleanValue("DescribeInstance.Result.EnablePublic");
			result.DedicateMaster = context.BooleanValue("DescribeInstance.Result.DedicateMaster");
			result.AdvancedDedicateMaster = context.BooleanValue("DescribeInstance.Result.AdvancedDedicateMaster");
			result.PublicPort = context.IntegerValue("DescribeInstance.Result.PublicPort");
			result.KibanaPort = context.IntegerValue("DescribeInstance.Result.KibanaPort");
			result.PublicDomain = context.StringValue("DescribeInstance.Result.PublicDomain");
			result.VpcInstanceId = context.StringValue("DescribeInstance.Result.VpcInstanceId");
			result.Port = context.IntegerValue("DescribeInstance.Result.Port");
			result.EsConfig = context.StringValue("DescribeInstance.Result.EsConfig");
			result.ZoneCount = context.IntegerValue("DescribeInstance.Result.ZoneCount");
			result.HaveClientNode = context.BooleanValue("DescribeInstance.Result.HaveClientNode");
			result.WarmNode = context.BooleanValue("DescribeInstance.Result.WarmNode");
			result.Protocol = context.StringValue("DescribeInstance.Result.Protocol");
			result.EnableKibanaPublicNetwork = context.BooleanValue("DescribeInstance.Result.EnableKibanaPublicNetwork");
			result.HaveKibana = context.BooleanValue("DescribeInstance.Result.HaveKibana");

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

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec nodeSpec = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("DescribeInstance.Result.NodeSpec.Spec");
			nodeSpec.Disk = context.IntegerValue("DescribeInstance.Result.NodeSpec.Disk");
			nodeSpec.DiskType = context.StringValue("DescribeInstance.Result.NodeSpec.DiskType");
			result.NodeSpec = nodeSpec;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig networkConfig = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("DescribeInstance.Result.NetworkConfig.Type");
			networkConfig.VpcId = context.StringValue("DescribeInstance.Result.NetworkConfig.VpcId");
			networkConfig.VswitchId = context.StringValue("DescribeInstance.Result.NetworkConfig.VswitchId");
			networkConfig.VsArea = context.StringValue("DescribeInstance.Result.NetworkConfig.VsArea");
			result.NetworkConfig = networkConfig;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration kibanaConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("DescribeInstance.Result.KibanaConfiguration.Spec");
			kibanaConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.KibanaConfiguration.Amount");
			kibanaConfiguration.DiskType = context.StringValue("DescribeInstance.Result.KibanaConfiguration.DiskType");
			kibanaConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.KibanaConfiguration.Disk");
			result.KibanaConfiguration = kibanaConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration masterConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("DescribeInstance.Result.MasterConfiguration.Spec");
			masterConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.MasterConfiguration.Amount");
			masterConfiguration.DiskType = context.StringValue("DescribeInstance.Result.MasterConfiguration.DiskType");
			masterConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.MasterConfiguration.Disk");
			result.MasterConfiguration = masterConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration clientNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ClientNodeConfiguration();
			clientNodeConfiguration.Spec = context.StringValue("DescribeInstance.Result.ClientNodeConfiguration.Spec");
			clientNodeConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.Amount");
			clientNodeConfiguration.DiskType = context.StringValue("DescribeInstance.Result.ClientNodeConfiguration.DiskType");
			clientNodeConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.ClientNodeConfiguration.Disk");
			result.ClientNodeConfiguration = clientNodeConfiguration;

			DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration warmNodeConfiguration = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_WarmNodeConfiguration();
			warmNodeConfiguration.Spec = context.StringValue("DescribeInstance.Result.WarmNodeConfiguration.Spec");
			warmNodeConfiguration.Amount = context.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.Amount");
			warmNodeConfiguration.DiskType = context.StringValue("DescribeInstance.Result.WarmNodeConfiguration.DiskType");
			warmNodeConfiguration.Disk = context.IntegerValue("DescribeInstance.Result.WarmNodeConfiguration.Disk");
			result.WarmNodeConfiguration = warmNodeConfiguration;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem> result_dictList = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.DictList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem dictListItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_DictListItem();
				dictListItem.Name = context.StringValue("DescribeInstance.Result.DictList["+ i +"].Name");
				dictListItem.FileSize = context.LongValue("DescribeInstance.Result.DictList["+ i +"].FileSize");
				dictListItem.Type = context.StringValue("DescribeInstance.Result.DictList["+ i +"].Type");
				dictListItem.SourceType = context.StringValue("DescribeInstance.Result.DictList["+ i +"].SourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem> result_synonymsDicts = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.SynonymsDicts.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem synonymsDictsItem = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].Name");
				synonymsDictsItem.FileSize = context.LongValue("DescribeInstance.Result.SynonymsDicts["+ i +"].FileSize");
				synonymsDictsItem.Type = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].Type");
				synonymsDictsItem.SourceType = context.StringValue("DescribeInstance.Result.SynonymsDicts["+ i +"].SourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;

			List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo> result_zoneInfos = new List<DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo>();
			for (int i = 0; i < context.Length("DescribeInstance.Result.ZoneInfos.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo zoneInfo = new DescribeInstanceResponse.DescribeInstance_Result.DescribeInstance_ZoneInfo();
				zoneInfo.ZoneId = context.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].ZoneId");
				zoneInfo.Status = context.StringValue("DescribeInstance.Result.ZoneInfos["+ i +"].Status");

				result_zoneInfos.Add(zoneInfo);
			}
			result.ZoneInfos = result_zoneInfos;
			describeInstanceResponse.Result = result;
        
			return describeInstanceResponse;
        }
    }
}
