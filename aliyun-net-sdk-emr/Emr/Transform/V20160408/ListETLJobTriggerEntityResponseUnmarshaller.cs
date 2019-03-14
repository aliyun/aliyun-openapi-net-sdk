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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListETLJobTriggerEntityResponseUnmarshaller
    {
        public static ListETLJobTriggerEntityResponse Unmarshall(UnmarshallerContext context)
        {
			ListETLJobTriggerEntityResponse listETLJobTriggerEntityResponse = new ListETLJobTriggerEntityResponse();

			listETLJobTriggerEntityResponse.HttpResponse = context.HttpResponse;
			listETLJobTriggerEntityResponse.RequestId = context.StringValue("ListETLJobTriggerEntity.RequestId");

			List<ListETLJobTriggerEntityResponse.ListETLJobTriggerEntity_TriggerEntity> listETLJobTriggerEntityResponse_triggerEntityList = new List<ListETLJobTriggerEntityResponse.ListETLJobTriggerEntity_TriggerEntity>();
			for (int i = 0; i < context.Length("ListETLJobTriggerEntity.TriggerEntityList.Length"); i++) {
				ListETLJobTriggerEntityResponse.ListETLJobTriggerEntity_TriggerEntity triggerEntity = new ListETLJobTriggerEntityResponse.ListETLJobTriggerEntity_TriggerEntity();
				triggerEntity.EntityType = context.StringValue("ListETLJobTriggerEntity.TriggerEntityList["+ i +"].EntityType");
				triggerEntity.Id = context.StringValue("ListETLJobTriggerEntity.TriggerEntityList["+ i +"].Id");
				triggerEntity.Name = context.StringValue("ListETLJobTriggerEntity.TriggerEntityList["+ i +"].Name");

				listETLJobTriggerEntityResponse_triggerEntityList.Add(triggerEntity);
			}
			listETLJobTriggerEntityResponse.TriggerEntityList = listETLJobTriggerEntityResponse_triggerEntityList;
        
			return listETLJobTriggerEntityResponse;
        }
    }
}
