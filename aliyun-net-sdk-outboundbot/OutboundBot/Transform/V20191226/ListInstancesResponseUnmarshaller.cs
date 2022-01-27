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
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.Code = _ctx.StringValue("ListInstances.Code");
			listInstancesResponse.HttpStatusCode = _ctx.IntegerValue("ListInstances.HttpStatusCode");
			listInstancesResponse.Message = _ctx.StringValue("ListInstances.Message");
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");
			listInstancesResponse.Success = _ctx.BooleanValue("ListInstances.Success");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instances = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstances.Instances.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.CallCenterInstanceId = _ctx.StringValue("ListInstances.Instances["+ i +"].CallCenterInstanceId");
				instance.CreationTime = _ctx.LongValue("ListInstances.Instances["+ i +"].CreationTime");
				instance.InstanceDescription = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceDescription");
				instance.InstanceId = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceId");
				instance.InstanceName = _ctx.StringValue("ListInstances.Instances["+ i +"].InstanceName");
				instance.IsTemplateContainer = _ctx.BooleanValue("ListInstances.Instances["+ i +"].IsTemplateContainer");
				instance.MaxConcurrentConversation = _ctx.IntegerValue("ListInstances.Instances["+ i +"].MaxConcurrentConversation");
				instance.OwnerName = _ctx.StringValue("ListInstances.Instances["+ i +"].OwnerName");
				instance.CreatorId = _ctx.LongValue("ListInstances.Instances["+ i +"].CreatorId");
				instance.CreatorName = _ctx.StringValue("ListInstances.Instances["+ i +"].CreatorName");
				instance.NluServiceType = _ctx.StringValue("ListInstances.Instances["+ i +"].NluServiceType");
				instance.Owner = _ctx.StringValue("ListInstances.Instances["+ i +"].Owner");
				instance.ResourceGroupId = _ctx.StringValue("ListInstances.Instances["+ i +"].ResourceGroupId");

				ListInstancesResponse.ListInstances_Instance.ListInstances_NluProfile nluProfile = new ListInstancesResponse.ListInstances_Instance.ListInstances_NluProfile();
				nluProfile.AccessKey = _ctx.StringValue("ListInstances.Instances["+ i +"].NluProfile.AccessKey");
				nluProfile.Endpoint = _ctx.StringValue("ListInstances.Instances["+ i +"].NluProfile.Endpoint");
				nluProfile.SecretKey = _ctx.StringValue("ListInstances.Instances["+ i +"].NluProfile.SecretKey");
				instance.NluProfile = nluProfile;

				List<ListInstancesResponse.ListInstances_Instance.ListInstances_ResourceTag> instance_resourceTags = new List<ListInstancesResponse.ListInstances_Instance.ListInstances_ResourceTag>();
				for (int j = 0; j < _ctx.Length("ListInstances.Instances["+ i +"].ResourceTags.Length"); j++) {
					ListInstancesResponse.ListInstances_Instance.ListInstances_ResourceTag resourceTag = new ListInstancesResponse.ListInstances_Instance.ListInstances_ResourceTag();
					resourceTag.Key = _ctx.StringValue("ListInstances.Instances["+ i +"].ResourceTags["+ j +"].Key");
					resourceTag._Value = _ctx.StringValue("ListInstances.Instances["+ i +"].ResourceTags["+ j +"].Value");

					instance_resourceTags.Add(resourceTag);
				}
				instance.ResourceTags = instance_resourceTags;

				listInstancesResponse_instances.Add(instance);
			}
			listInstancesResponse.Instances = listInstancesResponse_instances;
        
			return listInstancesResponse;
        }
    }
}
