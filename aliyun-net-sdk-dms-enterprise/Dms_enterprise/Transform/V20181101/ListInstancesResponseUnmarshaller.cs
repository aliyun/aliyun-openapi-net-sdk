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
        public static ListInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstancesResponse listInstancesResponse = new ListInstancesResponse();

			listInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listInstancesResponse.TotalCount = _ctx.LongValue("ListInstances.TotalCount");
			listInstancesResponse.RequestId = _ctx.StringValue("ListInstances.RequestId");
			listInstancesResponse.ErrorCode = _ctx.StringValue("ListInstances.ErrorCode");
			listInstancesResponse.ErrorMessage = _ctx.StringValue("ListInstances.ErrorMessage");
			listInstancesResponse.Success = _ctx.BooleanValue("ListInstances.Success");

			List<ListInstancesResponse.ListInstances_Instance> listInstancesResponse_instanceList = new List<ListInstancesResponse.ListInstances_Instance>();
			for (int i = 0; i < _ctx.Length("ListInstances.InstanceList.Length"); i++) {
				ListInstancesResponse.ListInstances_Instance instance = new ListInstancesResponse.ListInstances_Instance();
				instance.VpcId = _ctx.StringValue("ListInstances.InstanceList["+ i +"].VpcId");
				instance.DatabaseUser = _ctx.StringValue("ListInstances.InstanceList["+ i +"].DatabaseUser");
				instance.DbaId = _ctx.StringValue("ListInstances.InstanceList["+ i +"].DbaId");
				instance.UseDsql = _ctx.IntegerValue("ListInstances.InstanceList["+ i +"].UseDsql");
				instance.Port = _ctx.IntegerValue("ListInstances.InstanceList["+ i +"].Port");
				instance.EcsInstanceId = _ctx.StringValue("ListInstances.InstanceList["+ i +"].EcsInstanceId");
				instance.EnvType = _ctx.StringValue("ListInstances.InstanceList["+ i +"].EnvType");
				instance.Sid = _ctx.StringValue("ListInstances.InstanceList["+ i +"].Sid");
				instance.SafeRuleId = _ctx.StringValue("ListInstances.InstanceList["+ i +"].SafeRuleId");
				instance.DbaNickName = _ctx.StringValue("ListInstances.InstanceList["+ i +"].DbaNickName");
				instance.QueryTimeout = _ctx.IntegerValue("ListInstances.InstanceList["+ i +"].QueryTimeout");
				instance.InstanceSource = _ctx.StringValue("ListInstances.InstanceList["+ i +"].InstanceSource");
				instance.Host = _ctx.StringValue("ListInstances.InstanceList["+ i +"].Host");
				instance.State = _ctx.StringValue("ListInstances.InstanceList["+ i +"].State");
				instance.DataLinkName = _ctx.StringValue("ListInstances.InstanceList["+ i +"].DataLinkName");
				instance.ExportTimeout = _ctx.IntegerValue("ListInstances.InstanceList["+ i +"].ExportTimeout");
				instance.InstanceId = _ctx.StringValue("ListInstances.InstanceList["+ i +"].InstanceId");
				instance.InstanceType = _ctx.StringValue("ListInstances.InstanceList["+ i +"].InstanceType");
				instance.DatabasePassword = _ctx.StringValue("ListInstances.InstanceList["+ i +"].DatabasePassword");
				instance.InstanceAlias = _ctx.StringValue("ListInstances.InstanceList["+ i +"].InstanceAlias");
				instance.DdlOnline = _ctx.IntegerValue("ListInstances.InstanceList["+ i +"].DdlOnline");
				instance.EcsRegion = _ctx.StringValue("ListInstances.InstanceList["+ i +"].EcsRegion");

				List<string> instance_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstances.InstanceList["+ i +"].OwnerIdList.Length"); j++) {
					instance_ownerIdList.Add(_ctx.StringValue("ListInstances.InstanceList["+ i +"].OwnerIdList["+ j +"]"));
				}
				instance.OwnerIdList = instance_ownerIdList;

				List<string> instance_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListInstances.InstanceList["+ i +"].OwnerNameList.Length"); j++) {
					instance_ownerNameList.Add(_ctx.StringValue("ListInstances.InstanceList["+ i +"].OwnerNameList["+ j +"]"));
				}
				instance.OwnerNameList = instance_ownerNameList;

				listInstancesResponse_instanceList.Add(instance);
			}
			listInstancesResponse.InstanceList = listInstancesResponse_instanceList;
        
			return listInstancesResponse;
        }
    }
}
