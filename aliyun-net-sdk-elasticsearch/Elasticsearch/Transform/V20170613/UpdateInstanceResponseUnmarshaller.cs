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
        public static UpdateInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateInstanceResponse updateInstanceResponse = new UpdateInstanceResponse();

			updateInstanceResponse.HttpResponse = context.HttpResponse;
			updateInstanceResponse.RequestId = context.StringValue("UpdateInstance.RequestId");

			UpdateInstanceResponse.UpdateInstance_Result result = new UpdateInstanceResponse.UpdateInstance_Result();
			result.InstanceId = context.StringValue("UpdateInstance.Result.instanceId");
			result.Domain = context.StringValue("UpdateInstance.Result.domain");
			result.Description = context.StringValue("UpdateInstance.Result.description");
			result.NodeAmount = context.IntegerValue("UpdateInstance.Result.nodeAmount");
			result.PaymentType = context.StringValue("UpdateInstance.Result.paymentType");
			result.Status = context.StringValue("UpdateInstance.Result.status");
			result.EsVersion = context.StringValue("UpdateInstance.Result.esVersion");
			result.CreatedAt = context.StringValue("UpdateInstance.Result.createdAt");
			result.UpdatedAt = context.StringValue("UpdateInstance.Result.updatedAt");
			result.KibanaDomain = context.StringValue("UpdateInstance.Result.kibanaDomain");
			result.KibanaPort = context.IntegerValue("UpdateInstance.Result.kibanaPort");
			result.PublicDomain = context.StringValue("UpdateInstance.Result.publicDomain");
			result.PublicPort = context.IntegerValue("UpdateInstance.Result.publicPort");

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec nodeSpec = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("UpdateInstance.Result.NodeSpec.spec");
			nodeSpec.Disk = context.IntegerValue("UpdateInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = context.StringValue("UpdateInstance.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig networkConfig = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("UpdateInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = context.StringValue("UpdateInstance.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = context.StringValue("UpdateInstance.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = context.StringValue("UpdateInstance.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration kibanaConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("UpdateInstance.Result.KibanaConfiguration.spec");
			kibanaConfiguration.Amount = context.IntegerValue("UpdateInstance.Result.KibanaConfiguration.amount");
			kibanaConfiguration.DiskType = context.StringValue("UpdateInstance.Result.KibanaConfiguration.diskType");
			kibanaConfiguration.Disk = context.IntegerValue("UpdateInstance.Result.KibanaConfiguration.disk");
			result.KibanaConfiguration = kibanaConfiguration;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration masterConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("UpdateInstance.Result.MasterConfiguration.spec");
			masterConfiguration.Amount = context.IntegerValue("UpdateInstance.Result.MasterConfiguration.amount");
			masterConfiguration.DiskType = context.StringValue("UpdateInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.Disk = context.IntegerValue("UpdateInstance.Result.MasterConfiguration.disk");
			result.MasterConfiguration = masterConfiguration;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem> result_dictList = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem>();
			for (int i = 0; i < context.Length("UpdateInstance.Result.DictList.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem dictListItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem();
				dictListItem.Name = context.StringValue("UpdateInstance.Result.DictList["+ i +"].name");
				dictListItem.FileSize = context.LongValue("UpdateInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.Type = context.StringValue("UpdateInstance.Result.DictList["+ i +"].type");
				dictListItem.SourceType = context.StringValue("UpdateInstance.Result.DictList["+ i +"].sourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem> result_synonymsDicts = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("UpdateInstance.Result.SynonymsDicts.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem synonymsDictsItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.FileSize = context.LongValue("UpdateInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Type = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].type");
				synonymsDictsItem.SourceType = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].sourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			updateInstanceResponse.Result = result;
        
			return updateInstanceResponse;
        }
    }
}
