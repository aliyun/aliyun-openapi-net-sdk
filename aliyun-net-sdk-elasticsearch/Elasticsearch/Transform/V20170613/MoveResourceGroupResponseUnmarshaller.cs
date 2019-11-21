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
			result.InstanceId = context.StringValue("MoveResourceGroup.Result.instanceId");
			result.Domain = context.StringValue("MoveResourceGroup.Result.domain");
			result.Description = context.StringValue("MoveResourceGroup.Result.description");
			result.NodeAmount = context.IntegerValue("MoveResourceGroup.Result.nodeAmount");
			result.PaymentType = context.StringValue("MoveResourceGroup.Result.paymentType");
			result.Status = context.StringValue("MoveResourceGroup.Result.status");
			result.EsVersion = context.StringValue("MoveResourceGroup.Result.esVersion");
			result.CreatedAt = context.StringValue("MoveResourceGroup.Result.createdAt");
			result.UpdatedAt = context.StringValue("MoveResourceGroup.Result.updatedAt");
			result.KibanaDomain = context.StringValue("MoveResourceGroup.Result.kibanaDomain");
			result.KibanaPort = context.IntegerValue("MoveResourceGroup.Result.kibanaPort");
			result.PublicDomain = context.StringValue("MoveResourceGroup.Result.publicDomain");
			result.PublicPort = context.IntegerValue("MoveResourceGroup.Result.publicPort");

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec nodeSpec = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec();
			nodeSpec.Spec = context.StringValue("MoveResourceGroup.Result.NodeSpec.spec");
			nodeSpec.Disk = context.IntegerValue("MoveResourceGroup.Result.NodeSpec.disk");
			nodeSpec.DiskType = context.StringValue("MoveResourceGroup.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig networkConfig = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig();
			networkConfig.Type = context.StringValue("MoveResourceGroup.Result.NetworkConfig.type");
			networkConfig.VpcId = context.StringValue("MoveResourceGroup.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = context.StringValue("MoveResourceGroup.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = context.StringValue("MoveResourceGroup.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration kibanaConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("MoveResourceGroup.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = context.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.amount");
			kibanaConfiguration.DiskType = context.StringValue("MoveResourceGroup.Result.KibanaConfiguration.diskType");
			kibanaConfiguration.Disk = context.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.disk");
			result.KibanaConfiguration = kibanaConfiguration;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration masterConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("MoveResourceGroup.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = context.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.amount");
			masterConfiguration.DiskType = context.StringValue("MoveResourceGroup.Result.MasterConfiguration.diskType");
			masterConfiguration.Disk = context.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.disk");
			result.MasterConfiguration = masterConfiguration;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem> result_dictList = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem>();
			for (int i = 0; i < context.Length("MoveResourceGroup.Result.DictList.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem dictListItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem();
				dictListItem.Name = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].name");
				dictListItem.FileSize = context.LongValue("MoveResourceGroup.Result.DictList["+ i +"].fileSize");
				dictListItem.Type = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].type");
				dictListItem.SourceType = context.StringValue("MoveResourceGroup.Result.DictList["+ i +"].sourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem> result_synonymsDicts = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("MoveResourceGroup.Result.SynonymsDicts.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem synonymsDictsItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.FileSize = context.LongValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Type = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].type");
				synonymsDictsItem.SourceType = context.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].sourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			moveResourceGroupResponse.Result = result;
        
			return moveResourceGroupResponse;
        }
    }
}
