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
    public class UpdateInstanceResponseUnmarshaller
    {
        public static UpdateInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateInstanceResponse updateInstanceResponse = new UpdateInstanceResponse();

			updateInstanceResponse.HttpResponse = _ctx.HttpResponse;
			updateInstanceResponse.RequestId = _ctx.StringValue("UpdateInstance.RequestId");
			updateInstanceResponse.Code = _ctx.StringValue("UpdateInstance.Code");
			updateInstanceResponse.Message = _ctx.StringValue("UpdateInstance.Message");

			UpdateInstanceResponse.UpdateInstance_Result result = new UpdateInstanceResponse.UpdateInstance_Result();
			result.NodeAmount = _ctx.IntegerValue("UpdateInstance.Result.nodeAmount");
			result.PublicDomain = _ctx.StringValue("UpdateInstance.Result.publicDomain");
			result.CreatedAt = _ctx.StringValue("UpdateInstance.Result.createdAt");
			result.Status = _ctx.StringValue("UpdateInstance.Result.status");
			result.PublicPort = _ctx.IntegerValue("UpdateInstance.Result.publicPort");
			result.KibanaPort = _ctx.IntegerValue("UpdateInstance.Result.kibanaPort");
			result.PaymentType = _ctx.StringValue("UpdateInstance.Result.paymentType");
			result.Domain = _ctx.StringValue("UpdateInstance.Result.domain");
			result.Description = _ctx.StringValue("UpdateInstance.Result.description");
			result.EsVersion = _ctx.StringValue("UpdateInstance.Result.esVersion");
			result.KibanaDomain = _ctx.StringValue("UpdateInstance.Result.kibanaDomain");
			result.UpdatedAt = _ctx.StringValue("UpdateInstance.Result.updatedAt");
			result.InstanceId = _ctx.StringValue("UpdateInstance.Result.instanceId");

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec nodeSpec = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("UpdateInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("UpdateInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("UpdateInstance.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig networkConfig = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig();
			networkConfig.VpcId = _ctx.StringValue("UpdateInstance.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("UpdateInstance.Result.NetworkConfig.vsArea");
			networkConfig.Type = _ctx.StringValue("UpdateInstance.Result.NetworkConfig.type");
			networkConfig.VswitchId = _ctx.StringValue("UpdateInstance.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration kibanaConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = _ctx.StringValue("UpdateInstance.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = _ctx.IntegerValue("UpdateInstance.Result.KibanaConfiguration.amount");
			kibanaConfiguration.Disk = _ctx.IntegerValue("UpdateInstance.Result.KibanaConfiguration.disk");
			kibanaConfiguration.DiskType = _ctx.StringValue("UpdateInstance.Result.KibanaConfiguration.diskType");
			result.KibanaConfiguration = kibanaConfiguration;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration masterConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration();
			masterConfiguration.Spec = _ctx.StringValue("UpdateInstance.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = _ctx.IntegerValue("UpdateInstance.Result.MasterConfiguration.amount");
			masterConfiguration.Disk = _ctx.IntegerValue("UpdateInstance.Result.MasterConfiguration.disk");
			masterConfiguration.DiskType = _ctx.StringValue("UpdateInstance.Result.MasterConfiguration.diskType");
			result.MasterConfiguration = masterConfiguration;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem> result_dictList = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem>();
			for (int i = 0; i < _ctx.Length("UpdateInstance.Result.DictList.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem dictListItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem();
				dictListItem.FileSize = _ctx.LongValue("UpdateInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.SourceType = _ctx.StringValue("UpdateInstance.Result.DictList["+ i +"].sourceType");
				dictListItem.Name = _ctx.StringValue("UpdateInstance.Result.DictList["+ i +"].name");
				dictListItem.Type = _ctx.StringValue("UpdateInstance.Result.DictList["+ i +"].type");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem> result_synonymsDicts = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem>();
			for (int i = 0; i < _ctx.Length("UpdateInstance.Result.SynonymsDicts.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem synonymsDictsItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem();
				synonymsDictsItem.FileSize = _ctx.LongValue("UpdateInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.SourceType = _ctx.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].sourceType");
				synonymsDictsItem.Name = _ctx.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.Type = _ctx.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].type");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			updateInstanceResponse.Result = result;
        
			return updateInstanceResponse;
        }
    }
}
