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
        public static RestartInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			RestartInstanceResponse restartInstanceResponse = new RestartInstanceResponse();

			restartInstanceResponse.HttpResponse = context.HttpResponse;
			restartInstanceResponse.RequestId = context.StringValue("RestartInstance.RequestId");

			RestartInstanceResponse.RestartInstance_Result result = new RestartInstanceResponse.RestartInstance_Result();
			result.CreatedAt = context.StringValue("RestartInstance.Result.createdAt");
			result.Description = context.StringValue("RestartInstance.Result.description");
			result.Domain = context.StringValue("RestartInstance.Result.domain");
			result.EsVersion = context.StringValue("RestartInstance.Result.esVersion");
			result.InstanceId = context.StringValue("RestartInstance.Result.instanceId");
			result.KibanaDomain = context.StringValue("RestartInstance.Result.kibanaDomain");
			result.KibanaPort = context.IntegerValue("RestartInstance.Result.kibanaPort");
			result.NodeAmount = context.IntegerValue("RestartInstance.Result.nodeAmount");
			result.PaymentType = context.StringValue("RestartInstance.Result.paymentType");
			result.PublicDomain = context.StringValue("RestartInstance.Result.publicDomain");
			result.PublicPort = context.IntegerValue("RestartInstance.Result.publicPort");
			result.Status = context.StringValue("RestartInstance.Result.status");
			result.UpdatedAt = context.StringValue("RestartInstance.Result.updatedAt");

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_KibanaConfiguration kibanaConfiguration = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_KibanaConfiguration();
			kibanaConfiguration.Amount = context.IntegerValue("RestartInstance.Result.KibanaConfiguration.amount");
			kibanaConfiguration.Disk = context.IntegerValue("RestartInstance.Result.KibanaConfiguration.disk");
			kibanaConfiguration.DiskType = context.StringValue("RestartInstance.Result.KibanaConfiguration.diskType");
			kibanaConfiguration.Spec = context.StringValue("RestartInstance.Result.KibanaConfiguration.spec");
			result.KibanaConfiguration = kibanaConfiguration;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_MasterConfiguration masterConfiguration = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_MasterConfiguration();
			masterConfiguration.Amount = context.IntegerValue("RestartInstance.Result.MasterConfiguration.amount");
			masterConfiguration.Disk = context.IntegerValue("RestartInstance.Result.MasterConfiguration.disk");
			masterConfiguration.DiskType = context.StringValue("RestartInstance.Result.MasterConfiguration.diskType");
			masterConfiguration.Spec = context.StringValue("RestartInstance.Result.MasterConfiguration.spec");
			result.MasterConfiguration = masterConfiguration;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_NetworkConfig networkConfig = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("RestartInstance.Result.NetworkConfig.type");
			networkConfig.VpcId = context.StringValue("RestartInstance.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = context.StringValue("RestartInstance.Result.NetworkConfig.vsArea");
			networkConfig.VswitchId = context.StringValue("RestartInstance.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			RestartInstanceResponse.RestartInstance_Result.RestartInstance_NodeSpec nodeSpec = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_NodeSpec();
			nodeSpec.Disk = context.IntegerValue("RestartInstance.Result.NodeSpec.disk");
			nodeSpec.DiskType = context.StringValue("RestartInstance.Result.NodeSpec.diskType");
			nodeSpec.Spec = context.StringValue("RestartInstance.Result.NodeSpec.spec");
			result.NodeSpec = nodeSpec;

			List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem> result_dictList = new List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem>();
			for (int i = 0; i < context.Length("RestartInstance.Result.DictList.Length"); i++) {
				RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem dictListItem = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_DictListItem();
				dictListItem.FileSize = context.LongValue("RestartInstance.Result.DictList["+ i +"].fileSize");
				dictListItem.Name = context.StringValue("RestartInstance.Result.DictList["+ i +"].name");
				dictListItem.SourceType = context.StringValue("RestartInstance.Result.DictList["+ i +"].sourceType");
				dictListItem.Type = context.StringValue("RestartInstance.Result.DictList["+ i +"].type");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem> result_synonymsDicts = new List<RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("RestartInstance.Result.SynonymsDicts.Length"); i++) {
				RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem synonymsDictsItem = new RestartInstanceResponse.RestartInstance_Result.RestartInstance_SynonymsDictsItem();
				synonymsDictsItem.FileSize = context.LongValue("RestartInstance.Result.SynonymsDicts["+ i +"].fileSize");
				synonymsDictsItem.Name = context.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].name");
				synonymsDictsItem.SourceType = context.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].sourceType");
				synonymsDictsItem.Type = context.StringValue("RestartInstance.Result.SynonymsDicts["+ i +"].type");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			restartInstanceResponse.Result = result;
        
			return restartInstanceResponse;
        }
    }
}
