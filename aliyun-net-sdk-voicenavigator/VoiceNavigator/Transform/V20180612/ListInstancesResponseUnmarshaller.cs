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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = context.HttpResponse;
			listInstancesResponse.RequestId = context.StringValue("ListInstances.RequestId");
			listInstancesResponse.TotalCount = context.IntegerValue("ListInstances.TotalCount");
			listInstancesResponse.PageNumber = context.IntegerValue("ListInstances.PageNumber");
			listInstancesResponse.PageSize = context.IntegerValue("ListInstances.PageSize");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < context.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.InstanceId = context.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instance.Name = context.StringValue("ListInstances.Instances["+ i +"].Name");
				instance.Description = context.StringValue("ListInstances.Instances["+ i +"].Description");
				instance.Status = context.StringValue("ListInstances.Instances["+ i +"].Status");
				instance.Concurrency = context.LongValue("ListInstances.Instances["+ i +"].Concurrency");
				instance.ModifyTime = context.LongValue("ListInstances.Instances["+ i +"].ModifyTime");
				instance.ModifyUserName = context.StringValue("ListInstances.Instances["+ i +"].ModifyUserName");
				instance.NluServiceType = context.StringValue("ListInstances.Instances["+ i +"].NluServiceType");

				List<string> instance_applicableOperations = new List<string>();
				for (int j = 0; j < context.Length("ListInstances.Instances["+ i +"].ApplicableOperations.Length"); j++) {
					instance_applicableOperations.Add(context.StringValue("ListInstances.Instances["+ i +"].ApplicableOperations["+ j +"]"));
				}
				instance.ApplicableOperations = instance_applicableOperations;

				listInstancesResponse_instances.Add(instance);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
