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
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = context.HttpResponse;
			listInstanceResponse.RequestId = context.StringValue("ListInstance.RequestId");

			ListInstanceResponse.ListInstance_Headers headers = new ListInstanceResponse.ListInstance_Headers();
			headers.XTotalCount = context.IntegerValue("ListInstance.Headers.X-Total-Count");
			listInstanceResponse.Headers = headers;

			List<ListInstanceResponse.ListInstance_Instance> listInstanceResponse_result = new List<ListInstanceResponse.ListInstance_Instance>();
			for (int i = 0; i < context.Length("ListInstance.Result.Length"); i++) {
				ListInstanceResponse.ListInstance_Instance instance = new ListInstanceResponse.ListInstance_Instance();
				instance.InstanceId = context.StringValue("ListInstance.Result["+ i +"].instanceId");
				instance.Description = context.StringValue("ListInstance.Result["+ i +"].description");
				instance.NodeAmount = context.IntegerValue("ListInstance.Result["+ i +"].nodeAmount");
				instance.PaymentType = context.StringValue("ListInstance.Result["+ i +"].paymentType");
				instance.Status = context.StringValue("ListInstance.Result["+ i +"].status");
				instance.EsVersion = context.StringValue("ListInstance.Result["+ i +"].esVersion");
				instance.CreatedAt = context.StringValue("ListInstance.Result["+ i +"].createdAt");
				instance.UpdatedAt = context.StringValue("ListInstance.Result["+ i +"].updatedAt");
				instance.AdvancedDedicateMaster = context.BooleanValue("ListInstance.Result["+ i +"].advancedDedicateMaster");
				instance.DedicateMaster = context.BooleanValue("ListInstance.Result["+ i +"].dedicateMaster");
				instance.ResourceGroupId = context.StringValue("ListInstance.Result["+ i +"].resourceGroupId");

				ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec nodeSpec = new ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec();
				nodeSpec.Spec = context.StringValue("ListInstance.Result["+ i +"].NodeSpec.spec");
				nodeSpec.Disk = context.IntegerValue("ListInstance.Result["+ i +"].NodeSpec.disk");
				nodeSpec.DiskType = context.StringValue("ListInstance.Result["+ i +"].NodeSpec.diskType");
				instance.NodeSpec = nodeSpec;

				ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig networkConfig = new ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig();
				networkConfig.Type = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.type");
				networkConfig.VpcId = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vpcId");
				networkConfig.VswitchId = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vswitchId");
				networkConfig.VsArea = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.vsArea");
				instance.NetworkConfig = networkConfig;

				ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration masterConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration();
				masterConfiguration.Spec = context.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.spec");
				masterConfiguration.Amount = context.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.amount");
				masterConfiguration.DiskType = context.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.diskType");
				masterConfiguration.Disk = context.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.disk");
				instance.MasterConfiguration = masterConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration kibanaConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration();
				kibanaConfiguration.Spec = context.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.spec");
				kibanaConfiguration.Disk = context.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.disk");
				kibanaConfiguration.Amount = context.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.amount");
				kibanaConfiguration.DiskType = context.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.diskType");
				instance.KibanaConfiguration = kibanaConfiguration;

				List<ListInstanceResponse.ListInstance_Instance.ListInstance_Tag> instance_tags = new List<ListInstanceResponse.ListInstance_Instance.ListInstance_Tag>();
				for (int j = 0; j < context.Length("ListInstance.Result["+ i +"].Tags.Length"); j++) {
					ListInstanceResponse.ListInstance_Instance.ListInstance_Tag tag = new ListInstanceResponse.ListInstance_Instance.ListInstance_Tag();
					tag.TagKey = context.StringValue("ListInstance.Result["+ i +"].Tags["+ j +"].tagKey");
					tag.TagValue = context.StringValue("ListInstance.Result["+ i +"].Tags["+ j +"].tagValue");

					instance_tags.Add(tag);
				}
				instance.Tags = instance_tags;

				listInstanceResponse_result.Add(instance);
			}
			listInstanceResponse.Result = listInstanceResponse_result;
        
			return listInstanceResponse;
        }
    }
}
