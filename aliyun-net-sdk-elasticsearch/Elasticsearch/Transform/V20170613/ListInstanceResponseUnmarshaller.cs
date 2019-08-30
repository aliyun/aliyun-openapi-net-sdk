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
			headers.XTotalCount = context.IntegerValue("ListInstance.Headers.XTotalCount");
			listInstanceResponse.Headers = headers;

			List<ListInstanceResponse.ListInstance_Instance> listInstanceResponse_result = new List<ListInstanceResponse.ListInstance_Instance>();
			for (int i = 0; i < context.Length("ListInstance.Result.Length"); i++) {
				ListInstanceResponse.ListInstance_Instance instance = new ListInstanceResponse.ListInstance_Instance();
				instance.InstanceId = context.StringValue("ListInstance.Result["+ i +"].InstanceId");
				instance.Description = context.StringValue("ListInstance.Result["+ i +"].Description");
				instance.NodeAmount = context.IntegerValue("ListInstance.Result["+ i +"].NodeAmount");
				instance.PaymentType = context.StringValue("ListInstance.Result["+ i +"].PaymentType");
				instance.Status = context.StringValue("ListInstance.Result["+ i +"].Status");
				instance.EsVersion = context.StringValue("ListInstance.Result["+ i +"].EsVersion");
				instance.CreatedAt = context.StringValue("ListInstance.Result["+ i +"].CreatedAt");
				instance.UpdatedAt = context.StringValue("ListInstance.Result["+ i +"].UpdatedAt");
				instance.AdvancedDedicateMaster = context.BooleanValue("ListInstance.Result["+ i +"].AdvancedDedicateMaster");
				instance.DedicateMaster = context.BooleanValue("ListInstance.Result["+ i +"].DedicateMaster");

				ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec nodeSpec = new ListInstanceResponse.ListInstance_Instance.ListInstance_NodeSpec();
				nodeSpec.Spec = context.StringValue("ListInstance.Result["+ i +"].NodeSpec.Spec");
				nodeSpec.Disk = context.IntegerValue("ListInstance.Result["+ i +"].NodeSpec.Disk");
				nodeSpec.DiskType = context.StringValue("ListInstance.Result["+ i +"].NodeSpec.DiskType");
				instance.NodeSpec = nodeSpec;

				ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig networkConfig = new ListInstanceResponse.ListInstance_Instance.ListInstance_NetworkConfig();
				networkConfig.Type = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.Type");
				networkConfig.VpcId = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.VpcId");
				networkConfig.VswitchId = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.VswitchId");
				networkConfig.VsArea = context.StringValue("ListInstance.Result["+ i +"].NetworkConfig.VsArea");
				instance.NetworkConfig = networkConfig;

				ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration masterConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_MasterConfiguration();
				masterConfiguration.Spec = context.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.Spec");
				masterConfiguration.Amount = context.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.Amount");
				masterConfiguration.DiskType = context.StringValue("ListInstance.Result["+ i +"].MasterConfiguration.DiskType");
				masterConfiguration.Disk = context.IntegerValue("ListInstance.Result["+ i +"].MasterConfiguration.Disk");
				instance.MasterConfiguration = masterConfiguration;

				ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration kibanaConfiguration = new ListInstanceResponse.ListInstance_Instance.ListInstance_KibanaConfiguration();
				kibanaConfiguration.Spec = context.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.Spec");
				kibanaConfiguration.Disk = context.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.Disk");
				kibanaConfiguration.Amount = context.IntegerValue("ListInstance.Result["+ i +"].KibanaConfiguration.Amount");
				kibanaConfiguration.DiskType = context.StringValue("ListInstance.Result["+ i +"].KibanaConfiguration.DiskType");
				instance.KibanaConfiguration = kibanaConfiguration;

				listInstanceResponse_result.Add(instance);
			}
			listInstanceResponse.Result = listInstanceResponse_result;
        
			return listInstanceResponse;
        }
    }
}
