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
    public class RestartInstanceResponseUnmarshaller
    {
        public static RestartInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestartInstanceResponse restartInstanceResponse = new RestartInstanceResponse();

			restartInstanceResponse.HttpResponse = _ctx.HttpResponse;
			restartInstanceResponse.RequestId = _ctx.StringValue("RestartInstance.RequestId");

			RestartInstanceResponse.RestartInstance_Result result = new RestartInstanceResponse.RestartInstance_Result();
			result.CreatedAt = _ctx.StringValue("RestartInstance.Result.createdAt");
			result.Description = _ctx.StringValue("RestartInstance.Result.description");
			result.Domain = _ctx.StringValue("RestartInstance.Result.domain");
			result.EsVersion = _ctx.StringValue("RestartInstance.Result.esVersion");
			result.InstanceId = _ctx.StringValue("RestartInstance.Result.instanceId");
			result.KibanaDomain = _ctx.StringValue("RestartInstance.Result.kibanaDomain");
			result.KibanaPort = _ctx.IntegerValue("RestartInstance.Result.kibanaPort");
			result.NodeAmount = _ctx.IntegerValue("RestartInstance.Result.nodeAmount");
			result.PaymentType = _ctx.StringValue("RestartInstance.Result.paymentType");
			result.PublicDomain = _ctx.StringValue("RestartInstance.Result.publicDomain");
			result.PublicPort = _ctx.IntegerValue("RestartInstance.Result.publicPort");
			result.Status = _ctx.StringValue("RestartInstance.Result.status");
			result.UpdatedAt = _ctx.StringValue("RestartInstance.Result.updatedAt");

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_KibanaConfiguration kibanaConfiguration = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_KibanaConfiguration();
			kibanaConfiguration.Amount = _ctx.IntegerValue("RestartInstance.Result.KibanaConfiguration.amount");
			kibanaConfiguration.Disk = _ctx.IntegerValue("RestartInstance.Result.KibanaConfiguration.disk");
			kibanaConfiguration.DiskType = _ctx.StringValue("RestartInstance.Result.KibanaConfiguration.diskType");
			kibanaConfiguration.Spec = _ctx.StringValue("RestartInstance.Result.KibanaConfiguration.spec");
			result.KibanaConfiguration = kibanaConfiguration;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_MasterConfiguration masterConfiguration = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_MasterConfiguration();
			masterConfiguration.Amount = _ctx.IntegerValue("RestartInstance.Result.MasterConfiguration.amount");
			masterConfiguration.Disk = _ctx.IntegerValue("RestartInstance.Result.MasterConfiguration.disk");
			masterConfiguration.DiskType = _ctx.StringValue("RestartInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.Spec = _ctx.StringValue("RestartInstance.Result.MasterConfiguration.spec");
			result.MasterConfiguration = masterConfiguration;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_NetworkConfig networkConfig = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_NetworkConfig();
			networkConfig.Type = _ctx.StringValue("RestartInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = _ctx.StringValue("RestartInstance.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("RestartInstance.Result.NetworkConfig.vsArea");
			networkConfig.VswitchId = _ctx.StringValue("RestartInstance.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_NodeSpec nodeSpec = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_NodeSpec();
			nodeSpec.Disk = _ctx.IntegerValue("RestartInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("RestartInstance.Result.NodeSpec.diskType");
			nodeSpec.Spec = _ctx.StringValue("RestartInstance.Result.NodeSpec.spec");
			result.NodeSpec = nodeSpec;

			List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem> result_dictList = new List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem>();
			for (int i = 0; i < _ctx.Length("RestartInstance.Result.DictList.Length"); i++) {
				RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem dictListItem = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem();
				dictListItem.FileSize = _ctx.LongValue("RestartInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.Name = _ctx.StringValue("RestartInstance.Result.DictList["+ i +"].name");
				dictListItem.SourceType = _ctx.StringValue("RestartInstance.Result.DictList["+ i +"].sourceType");
				dictListItem.Type = _ctx.StringValue("RestartInstance.Result.DictList["+ i +"].type");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem> result_synonymsDicts = new List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem>();
			for (int i = 0; i < _ctx.Length("RestartInstance.Result.SynonymsDicts.Length"); i++) {
				RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem synonymsDictsItem = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem();
				synonymsDictsItem.FileSize = _ctx.LongValue("RestartInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Name = _ctx.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.SourceType = _ctx.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].sourceType");
				synonymsDictsItem.Type = _ctx.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].type");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			restartInstanceResponse.Result = result;
        
			return restartInstanceResponse;
        }
    }
}
