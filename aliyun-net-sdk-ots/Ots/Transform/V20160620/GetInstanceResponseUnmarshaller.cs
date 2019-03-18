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
using Aliyun.Acs.Ots.Model.V20160620;

namespace Aliyun.Acs.Ots.Transform.V20160620
{
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");

			GetInstanceResponse.GetInstance_InstanceInfo instanceInfo = new GetInstanceResponse.GetInstance_InstanceInfo();
			instanceInfo.InstanceName = context.StringValue("GetInstance.InstanceInfo.InstanceName");
			instanceInfo.UserId = context.StringValue("GetInstance.InstanceInfo.UserId");
			instanceInfo.Network = context.StringValue("GetInstance.InstanceInfo.Network");
			instanceInfo.Status = context.IntegerValue("GetInstance.InstanceInfo.Status");
			instanceInfo.WriteCapacity = context.IntegerValue("GetInstance.InstanceInfo.WriteCapacity");
			instanceInfo.ReadCapacity = context.IntegerValue("GetInstance.InstanceInfo.ReadCapacity");
			instanceInfo.Description = context.StringValue("GetInstance.InstanceInfo.Description");
			instanceInfo.CreateTime = context.StringValue("GetInstance.InstanceInfo.CreateTime");
			instanceInfo.ClusterType = context.StringValue("GetInstance.InstanceInfo.ClusterType");

			GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_Quota quota = new GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_Quota();
			quota.EntityQuota = context.IntegerValue("GetInstance.InstanceInfo.Quota.EntityQuota");
			instanceInfo.Quota = quota;

			List<GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_TagInfo> instanceInfo_tagInfos = new List<GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_TagInfo>();
			for (int i = 0; i < context.Length("GetInstance.InstanceInfo.TagInfos.Length"); i++) {
				GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_TagInfo tagInfo = new GetInstanceResponse.GetInstance_InstanceInfo.GetInstance_TagInfo();
				tagInfo.TagKey = context.StringValue("GetInstance.InstanceInfo.TagInfos["+ i +"].TagKey");
				tagInfo.TagValue = context.StringValue("GetInstance.InstanceInfo.TagInfos["+ i +"].TagValue");

				instanceInfo_tagInfos.Add(tagInfo);
			}
			instanceInfo.TagInfos = instanceInfo_tagInfos;
			getInstanceResponse.InstanceInfo = instanceInfo;
        
			return getInstanceResponse;
        }
    }
}
