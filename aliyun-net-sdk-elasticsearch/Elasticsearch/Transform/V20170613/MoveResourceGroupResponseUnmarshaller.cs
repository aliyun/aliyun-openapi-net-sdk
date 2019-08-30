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
    public class MoveResourceGroupResponseUnmarshaller
    {
        public static MoveResourceGroupResponse Unmarshall(UnmarshallerContext context)
        {
			MoveResourceGroupResponse moveResourceGroupResponse = new MoveResourceGroupResponse();

			moveResourceGroupResponse.HttpResponse = context.HttpResponse;
			moveResourceGroupResponse.RequestId = context.StringValue("MoveResourceGroup.RequestId");

			MoveResourceGroupResponse.MoveResourceGroup_Result result = new MoveResourceGroupResponse.MoveResourceGroup_Result();
			result.InstanceId = context.StringValue("MoveResourceGroup.Result.InstanceId");
			result.Domain = context.StringValue("MoveResourceGroup.Result.Domain");
			result.Description = context.StringValue("MoveResourceGroup.Result.Description");
			result.NodeAmount = context.IntegerValue("MoveResourceGroup.Result.NodeAmount");
			result.PaymentType = context.StringValue("MoveResourceGroup.Result.PaymentType");
			result.Status = context.StringValue("MoveResourceGroup.Result.Status");
			result.EsVersion = context.StringValue("MoveResourceGroup.Result.EsVersion");
			result.CreatedAt = context.StringValue("MoveResourceGroup.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("MoveResourceGroup.Result.UpdatedAt");
			result.KibanaDomain = context.StringValue("MoveResourceGroup.Result.KibanaDomain");
			result.KibanaPort = context.IntegerValue("MoveResourceGroup.Result.KibanaPort");
			result.PublicDomain = context.StringValue("MoveResourceGroup.Result.PublicDomain");
			result.PublicPort = context.IntegerValue("MoveResourceGroup.Result.PublicPort");

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec nodeSpec = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec();
			nodeSpec.Spec = context.StringValue("MoveResourceGroup.Result.NodeSpec.Spec");
			nodeSpec.Disk = context.IntegerValue("MoveResourceGroup.Result.NodeSpec.Disk");
			nodeSpec.DiskType = context.StringValue("MoveResourceGroup.Result.NodeSpec.DiskType");
			result.NodeSpec = nodeSpec;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig networkConfig = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig();
			networkConfig.Type = context.StringValue("MoveResourceGroup.Result.NetworkConfig.Type");
			networkConfig.VpcId = context.StringValue("MoveResourceGroup.Result.NetworkConfig.VpcId");
			networkConfig.VswitchId = context.StringValue("MoveResourceGroup.Result.NetworkConfig.VswitchId");
			networkConfig.VsArea = context.StringValue("MoveResourceGroup.Result.NetworkConfig.VsArea");
			result.NetworkConfig = networkConfig;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration kibanaConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("MoveResourceGroup.Result.KibanaConfiguration.Spec");
			kibanaConfiguration.Amount = context.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.Amount");
			kibanaConfiguration.DiskType = context.StringValue("MoveResourceGroup.Result.KibanaConfiguration.DiskType");
			kibanaConfiguration.Disk = context.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.Disk");
			result.KibanaConfiguration = kibanaConfiguration;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration masterConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("MoveResourceGroup.Result.MasterConfiguration.Spec");
			masterConfiguration.Amount = context.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.Amount");
			masterConfiguration.DiskType = context.StringValue("MoveResourceGroup.Result.MasterConfiguration.DiskType");
			masterConfiguration.Disk = context.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.Disk");
			result.MasterConfiguration = masterConfiguration;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem> result_dictList = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem>();
			for (int i = 0; i < context.Length("MoveResourceGroup.Result.DictList.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem dictListItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem();
				dictListItem.Name = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].Name");
				dictListItem.FileSize = context.LongValue("MoveResourceGroup.Result.DictList["+ i +"].FileSize");
				dictListItem.Type = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].Type");
				dictListItem.SourceType = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].SourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem> result_synonymsDicts = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("MoveResourceGroup.Result.SynonymsDicts.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem synonymsDictsItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].Name");
				synonymsDictsItem.FileSize = context.LongValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].FileSize");
				synonymsDictsItem.Type = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].Type");
				synonymsDictsItem.SourceType = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].SourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			moveResourceGroupResponse.Result = result;
        
			return moveResourceGroupResponse;
        }
    }
}
