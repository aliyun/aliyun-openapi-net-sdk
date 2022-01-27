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
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");
			listInstancesResponse.TotalCount = _ctx.IntegerValue("ListInstances.TotalCount");
			listInstancesResponse.PageNumber = _ctx.IntegerValue("ListInstances.PageNumber");
			listInstancesResponse.PageSize = _ctx.IntegerValue("ListInstances.PageSize");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.InstanceId = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instance.Name = _ctx.StringValue("ListInstances.Instances["+ i +"].Name");
				instance.Description = _ctx.StringValue("ListInstances.Instances["+ i +"].Description");
				instance.Status = _ctx.StringValue("ListInstances.Instances["+ i +"].Status");
				instance.Concurrency = _ctx.LongValue("ListInstances.Instances["+ i +"].Concurrency");
				instance.ModifyTime = _ctx.LongValue("ListInstances.Instances["+ i +"].ModifyTime");
				instance.ModifyUserName = _ctx.StringValue("ListInstances.Instances["+ i +"].ModifyUserName");
				instance.NluServiceType = _ctx.StringValue("ListInstances.Instances["+ i +"].NluServiceType");

				List<string> instance_applicableOperations = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstances.Instances["+ i +"].ApplicableOperations.Length"); j++) {
					instance_applicableOperations.Add(_ctx.StringValue("ListInstances.Instances["+ i +"].ApplicableOperations["+ j +"]"));
				}
				instance.ApplicableOperations = instance_applicableOperations;

				listInstancesResponse_instances.Add(instance);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
