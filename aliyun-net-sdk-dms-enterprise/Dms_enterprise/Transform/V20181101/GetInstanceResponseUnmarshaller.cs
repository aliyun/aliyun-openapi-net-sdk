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
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");
			getInstanceResponse.Success = context.BooleanValue("GetInstance.Success");
			getInstanceResponse.ErrorMessage = context.StringValue("GetInstance.ErrorMessage");
			getInstanceResponse.ErrorCode = context.StringValue("GetInstance.ErrorCode");

			GetInstanceResponse.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Instance();
			instance.InstanceId = context.StringValue("GetInstance.Instance.InstanceId");
			instance.InstanceType = context.StringValue("GetInstance.Instance.InstanceType");
			instance.EnvType = context.StringValue("GetInstance.Instance.EnvType");
			instance.Host = context.StringValue("GetInstance.Instance.Host");
			instance.Port = context.IntegerValue("GetInstance.Instance.Port");
			instance.Sid = context.StringValue("GetInstance.Instance.Sid");
			instance.InstanceAlias = context.StringValue("GetInstance.Instance.InstanceAlias");
			instance.DataLinkName = context.StringValue("GetInstance.Instance.DataLinkName");
			instance.DbaNickName = context.StringValue("GetInstance.Instance.DbaNickName");
			instance.SafeRuleId = context.StringValue("GetInstance.Instance.SafeRuleId");
			instance.QueryTimeout = context.IntegerValue("GetInstance.Instance.QueryTimeout");
			instance.ExportTimeout = context.IntegerValue("GetInstance.Instance.ExportTimeout");
			instance.State = context.StringValue("GetInstance.Instance.State");
			instance.DbaId = context.StringValue("GetInstance.Instance.DbaId");
			instance.DdlOnline = context.IntegerValue("GetInstance.Instance.DdlOnline");
			instance.UseDsql = context.IntegerValue("GetInstance.Instance.UseDsql");
			instance.EcsInstanceId = context.StringValue("GetInstance.Instance.EcsInstanceId");
			instance.VpcId = context.StringValue("GetInstance.Instance.VpcId");
			instance.EcsRegion = context.StringValue("GetInstance.Instance.EcsRegion");
			instance.DatabaseUser = context.StringValue("GetInstance.Instance.DatabaseUser");
			instance.DatabasePassword = context.StringValue("GetInstance.Instance.DatabasePassword");
			instance.InstanceSource = context.StringValue("GetInstance.Instance.InstanceSource");
			getInstanceResponse.Instance = instance;
        
			return getInstanceResponse;
        }
    }
}
