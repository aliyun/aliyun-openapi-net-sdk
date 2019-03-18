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
    public class ListInstanceResponseUnmarshaller
    {
        public static ListInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstanceResponse listInstanceResponse = new ListInstanceResponse();

			listInstanceResponse.HttpResponse = context.HttpResponse;
			listInstanceResponse.TotalCount = context.LongValue("ListInstance.TotalCount");
			listInstanceResponse.PageNum = context.LongValue("ListInstance.PageNum");
			listInstanceResponse.PageSize = context.LongValue("ListInstance.PageSize");
			listInstanceResponse.RequestId = context.StringValue("ListInstance.RequestId");

			List<ListInstanceResponse.ListInstance_InstanceInfo> listInstanceResponse_instanceInfos = new List<ListInstanceResponse.ListInstance_InstanceInfo>();
			for (int i = 0; i < context.Length("ListInstance.InstanceInfos.Length"); i++) {
				ListInstanceResponse.ListInstance_InstanceInfo instanceInfo = new ListInstanceResponse.ListInstance_InstanceInfo();
				instanceInfo.InstanceName = context.StringValue("ListInstance.InstanceInfos["+ i +"].InstanceName");
				instanceInfo.Timestamp = context.StringValue("ListInstance.InstanceInfos["+ i +"].Timestamp");

				listInstanceResponse_instanceInfos.Add(instanceInfo);
			}
			listInstanceResponse.InstanceInfos = listInstanceResponse_instanceInfos;
        
			return listInstanceResponse;
        }
    }
}
