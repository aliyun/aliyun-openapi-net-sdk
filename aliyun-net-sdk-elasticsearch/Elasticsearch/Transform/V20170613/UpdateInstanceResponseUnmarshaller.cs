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
			result.InstanceId = context.StringValue("UpdateInstance.Result.InstanceId");
			result.Domain = context.StringValue("UpdateInstance.Result.Domain");
			result.Description = context.StringValue("UpdateInstance.Result.Description");
			result.NodeAmount = context.IntegerValue("UpdateInstance.Result.NodeAmount");
			result.PaymentType = context.StringValue("UpdateInstance.Result.PaymentType");
			result.Status = context.StringValue("UpdateInstance.Result.Status");
			result.EsVersion = context.StringValue("UpdateInstance.Result.EsVersion");
			result.CreatedAt = context.StringValue("UpdateInstance.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("UpdateInstance.Result.UpdatedAt");
			result.KibanaDomain = context.StringValue("UpdateInstance.Result.KibanaDomain");
			result.KibanaPort = context.IntegerValue("UpdateInstance.Result.KibanaPort");
			result.PublicDomain = context.StringValue("UpdateInstance.Result.PublicDomain");
			result.PublicPort = context.IntegerValue("UpdateInstance.Result.PublicPort");

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec nodeSpec = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NodeSpec();
			nodeSpec.Spec = context.StringValue("UpdateInstance.Result.NodeSpec.Spec");
			nodeSpec.Disk = context.IntegerValue("UpdateInstance.Result.NodeSpec.Disk");
			nodeSpec.DiskType = context.StringValue("UpdateInstance.Result.NodeSpec.DiskType");
			result.NodeSpec = nodeSpec;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig networkConfig = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_NetworkConfig();
			networkConfig.Type = context.StringValue("UpdateInstance.Result.NetworkConfig.Type");
			networkConfig.VpcId = context.StringValue("UpdateInstance.Result.NetworkConfig.VpcId");
			networkConfig.VswitchId = context.StringValue("UpdateInstance.Result.NetworkConfig.VswitchId");
			networkConfig.VsArea = context.StringValue("UpdateInstance.Result.NetworkConfig.VsArea");
			result.NetworkConfig = networkConfig;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration kibanaConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_KibanaConfiguration();
			kibanaConfiguration.Spec = context.StringValue("UpdateInstance.Result.KibanaConfiguration.Spec");
			kibanaConfiguration.Amount = context.IntegerValue("UpdateInstance.Result.KibanaConfiguration.Amount");
			kibanaConfiguration.DiskType = context.StringValue("UpdateInstance.Result.KibanaConfiguration.DiskType");
			kibanaConfiguration.Disk = context.IntegerValue("UpdateInstance.Result.KibanaConfiguration.Disk");
			result.KibanaConfiguration = kibanaConfiguration;

			UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration masterConfiguration = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_MasterConfiguration();
			masterConfiguration.Spec = context.StringValue("UpdateInstance.Result.MasterConfiguration.Spec");
			masterConfiguration.Amount = context.IntegerValue("UpdateInstance.Result.MasterConfiguration.Amount");
			masterConfiguration.DiskType = context.StringValue("UpdateInstance.Result.MasterConfiguration.DiskType");
			masterConfiguration.Disk = context.IntegerValue("UpdateInstance.Result.MasterConfiguration.Disk");
			result.MasterConfiguration = masterConfiguration;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem> result_dictList = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem>();
			for (int i = 0; i < context.Length("UpdateInstance.Result.DictList.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem dictListItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_DictListItem();
				dictListItem.Name = context.StringValue("UpdateInstance.Result.DictList["+ i +"].Name");
				dictListItem.FileSize = context.LongValue("UpdateInstance.Result.DictList["+ i +"].FileSize");
				dictListItem.Type = context.StringValue("UpdateInstance.Result.DictList["+ i +"].Type");
				dictListItem.SourceType = context.StringValue("UpdateInstance.Result.DictList["+ i +"].SourceType");

				result_dictList.Add(dictListItem);
			}
			result.DictList = result_dictList;

			List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem> result_synonymsDicts = new List<UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem>();
			for (int i = 0; i < context.Length("UpdateInstance.Result.SynonymsDicts.Length"); i++) {
				UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem synonymsDictsItem = new UpdateInstanceResponse.UpdateInstance_Result.UpdateInstance_SynonymsDictsItem();
				synonymsDictsItem.Name = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].Name");
				synonymsDictsItem.FileSize = context.LongValue("UpdateInstance.Result.SynonymsDicts["+ i +"].FileSize");
				synonymsDictsItem.Type = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].Type");
				synonymsDictsItem.SourceType = context.StringValue("UpdateInstance.Result.SynonymsDicts["+ i +"].SourceType");

				result_synonymsDicts.Add(synonymsDictsItem);
			}
			result.SynonymsDicts = result_synonymsDicts;
			updateInstanceResponse.Result = result;
        
			return updateInstanceResponse;
        }
    }
}
