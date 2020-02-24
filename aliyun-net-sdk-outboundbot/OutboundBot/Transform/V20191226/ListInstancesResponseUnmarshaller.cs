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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = context.HttpResponse;
			listInstancesResponse.RequestId = context.StringValue("ListInstances.RequestId");
			listInstancesResponse.Success = context.BooleanValue("ListInstances.Success");
			listInstancesResponse.Code = context.StringValue("ListInstances.Code");
			listInstancesResponse.Message = context.StringValue("ListInstances.Message");
			listInstancesResponse.HttpStatusCode = context.IntegerValue("ListInstances.HttpStatusCode");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < context.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.InstanceId = context.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = context.StringValue("ListInstances.Instances["+ i +"].InstanceName");
				instance.InstanceDescription = context.StringValue("ListInstances.Instances["+ i +"].InstanceDescription");
				instance.MaxConcurrentConversation = context.IntegerValue("ListInstances.Instances["+ i +"].MaxConcurrentConversation");
				instance.Owner = context.StringValue("ListInstances.Instances["+ i +"].Owner");
				instance.CreationTime = context.LongValue("ListInstances.Instances["+ i +"].CreationTime");
				instance.CallCenterInstanceId = context.StringValue("ListInstances.Instances["+ i +"].CallCenterInstanceId");
				instance.IsTemplateContainer = context.BooleanValue("ListInstances.Instances["+ i +"].IsTemplateContainer");

				listInstancesResponse_instances.Add(instance);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
