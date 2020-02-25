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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListInstancesResponseUnmarshaller
    {
        public static ListInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = context.HttpResponse;
			listInstancesResponse.RequestId = context.StringValue("ListInstances.RequestId");
			listInstancesResponse.Success = context.BooleanValue("ListInstances.Success");
			listInstancesResponse.ErrorMessage = context.StringValue("ListInstances.ErrorMessage");
			listInstancesResponse.ErrorCode = context.StringValue("ListInstances.ErrorCode");
			listInstancesResponse.TotalCount = context.LongValue("ListInstances.TotalCount");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instanceList = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < context.Length("ListInstances.InstanceList.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.InstanceId = context.StringValue("ListInstances.InstanceList["+ i +"].InstanceId");
				instance.InstanceType = context.StringValue("ListInstances.InstanceList["+ i +"].InstanceType");
				instance.EnvType = context.StringValue("ListInstances.InstanceList["+ i +"].EnvType");
				instance.Host = context.StringValue("ListInstances.InstanceList["+ i +"].Host");
				instance.Port = context.IntegerValue("ListInstances.InstanceList["+ i +"].Port");
				instance.Sid = context.StringValue("ListInstances.InstanceList["+ i +"].Sid");
				instance.InstanceAlias = context.StringValue("ListInstances.InstanceList["+ i +"].InstanceAlias");
				instance.DataLinkName = context.StringValue("ListInstances.InstanceList["+ i +"].DataLinkName");
				instance.DbaNickName = context.StringValue("ListInstances.InstanceList["+ i +"].DbaNickName");
				instance.SafeRuleId = context.StringValue("ListInstances.InstanceList["+ i +"].SafeRuleId");
				instance.QueryTimeout = context.IntegerValue("ListInstances.InstanceList["+ i +"].QueryTimeout");
				instance.ExportTimeout = context.IntegerValue("ListInstances.InstanceList["+ i +"].ExportTimeout");
				instance.State = context.StringValue("ListInstances.InstanceList["+ i +"].State");
				instance.DbaId = context.StringValue("ListInstances.InstanceList["+ i +"].DbaId");
				instance.DdlOnline = context.IntegerValue("ListInstances.InstanceList["+ i +"].DdlOnline");
				instance.UseDsql = context.IntegerValue("ListInstances.InstanceList["+ i +"].UseDsql");
				instance.EcsInstanceId = context.StringValue("ListInstances.InstanceList["+ i +"].EcsInstanceId");
				instance.VpcId = context.StringValue("ListInstances.InstanceList["+ i +"].VpcId");
				instance.EcsRegion = context.StringValue("ListInstances.InstanceList["+ i +"].EcsRegion");
				instance.DatabaseUser = context.StringValue("ListInstances.InstanceList["+ i +"].DatabaseUser");
				instance.DatabasePassword = context.StringValue("ListInstances.InstanceList["+ i +"].DatabasePassword");
				instance.InstanceSource = context.StringValue("ListInstances.InstanceList["+ i +"].InstanceSource");

				listInstancesResponse_instanceList.Add(instance);
			}
			listInstancesResponse.InstanceList = listInstancesResponse_instanceList;
        
			return listInstancesResponse;
        }
    }
}
