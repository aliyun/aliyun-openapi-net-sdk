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
        public static MoveResourceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MoveResourceGroupResponse moveResourceGroupResponse = new MoveResourceGroupResponse();

			moveResourceGroupResponse.HttpResponse = _ctx.HttpResponse;
			moveResourceGroupResponse.RequestId = _ctx.StringValue("MoveResourceGroup.RequestId");

			MoveResourceGroupResponse.MoveResourceGroup_Result result = new MoveResourceGroupResponse.MoveResourceGroup_Result();
			result.NodeAmount = _ctx.IntegerValue("MoveResourceGroup.Result.nodeAmount");
			result.PublicDomain = _ctx.StringValue("MoveResourceGroup.Result.publicDomain");
			result.CreatedAt = _ctx.StringValue("MoveResourceGroup.Result.createdAt");
			result.Status = _ctx.StringValue("MoveResourceGroup.Result.status");
			result.PublicPort = _ctx.IntegerValue("MoveResourceGroup.Result.publicPort");
			result.KibanaPort = _ctx.IntegerValue("MoveResourceGroup.Result.kibanaPort");
			result.PaymentType = _ctx.StringValue("MoveResourceGroup.Result.paymentType");
			result.Domain = _ctx.StringValue("MoveResourceGroup.Result.domain");
			result.Description = _ctx.StringValue("MoveResourceGroup.Result.description");
			result.EsVersion = _ctx.StringValue("MoveResourceGroup.Result.esVersion");
			result.KibanaDomain = _ctx.StringValue("MoveResourceGroup.Result.kibanaDomain");
			result.UpdatedAt = _ctx.StringValue("MoveResourceGroup.Result.updatedAt");
			result.InstanceId = _ctx.StringValue("MoveResourceGroup.Result.instanceId");

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec nodeSpec = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("MoveResourceGroup.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("MoveResourceGroup.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("MoveResourceGroup.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig networkConfig = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_NetworkConfig();
			networkConfig.VpcId = _ctx.StringValue("MoveResourceGroup.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("MoveResourceGroup.Result.NetworkConfig.vsArea");
			networkConfig.Type = _ctx.StringValue("MoveResourceGroup.Result.NetworkConfig.type");
			networkConfig.VswitchId = _ctx.StringValue("MoveResourceGroup.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration kibanaConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_KibanaConfiguration();
			kibanaConfiguration.Spec = _ctx.StringValue("MoveResourceGroup.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = _ctx.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.amount");
			kibanaConfiguration.Disk = _ctx.IntegerValue("MoveResourceGroup.Result.KibanaConfiguration.disk");
			kibanaConfiguration.DiskType = _ctx.StringValue("MoveResourceGroup.Result.KibanaConfiguration.diskType");
			result.KibanaConfiguration = kibanaConfiguration;

			MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration masterConfiguration = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_MasterConfiguration();
			masterConfiguration.Spec = _ctx.StringValue("MoveResourceGroup.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = _ctx.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.amount");
			masterConfiguration.Disk = _ctx.IntegerValue("MoveResourceGroup.Result.MasterConfiguration.disk");
			masterConfiguration.DiskType = _ctx.StringValue("MoveResourceGroup.Result.MasterConfiguration.diskType");
			result.MasterConfiguration = masterConfiguration;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem> result_dictList = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem>();
			for (int i = 0; i < _ctx.Length("MoveResourceGroup.Result.DictList.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem dictListItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_DictListItem();
				dictListItem.FileSize = _ctx.LongValue("MoveResourceGroup.Result.DictList["+ i +"].fileSize");
				dictListItem.SourceType = _ctx.StringValue("MoveResourceGroup.Result.DictList["+ i +"].sourceType");
				dictListItem.Name = _ctx.StringValue("MoveResourceGroup.Result.DictList["+ i +"].name");
				dictListItem.Type = _ctx.StringValue("MoveResourceGroup.Result.DictList["+ i +"].type");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem> result_synonymsDicts = new List<MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem>();
			for (int i = 0; i < _ctx.Length("MoveResourceGroup.Result.SynonymsDicts.Length"); i++) {
				MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem synonymsDictsItem = new MoveResourceGroupResponse.MoveResourceGroup_Result.MoveResourceGroup_SynonymsDictsItem();
				synonymsDictsItem.FileSize = _ctx.LongValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.SourceType = _ctx.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].sourceType");
				synonymsDictsItem.Name = _ctx.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.Type = _ctx.StringValue("MoveResourceGroup.Result.SynonymsDicts["+ i +"].type");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			moveResourceGroupResponse.Result = result;
        
			return moveResourceGroupResponse;
        }
    }
}
