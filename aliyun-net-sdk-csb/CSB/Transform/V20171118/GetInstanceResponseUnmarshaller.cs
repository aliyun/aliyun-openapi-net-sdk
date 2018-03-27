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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CSB.Model.V20171118;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class GetInstanceResponseUnmarshaller
    {
        public static GetInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			GetInstanceResponse getInstanceResponse = new GetInstanceResponse();

			getInstanceResponse.HttpResponse = context.HttpResponse;
			getInstanceResponse.Code = context.IntegerValue("GetInstance.Code");
			getInstanceResponse.Message = context.StringValue("GetInstance.Message");
			getInstanceResponse.RequestId = context.StringValue("GetInstance.RequestId");

			GetInstanceResponse.GetInstance_Data data = new GetInstanceResponse.GetInstance_Data();

			GetInstanceResponse.GetInstance_Data.GetInstance_Instance instance = new GetInstanceResponse.GetInstance_Data.GetInstance_Instance();
			instance.ApprLevel = context.IntegerValue("GetInstance.Data.Instance.ApprLevel");
			instance.ApprUser1 = context.StringValue("GetInstance.Data.Instance.ApprUser1");
			instance.ApprUser2 = context.StringValue("GetInstance.Data.Instance.ApprUser2");
			instance.BrokerVpcId = context.StringValue("GetInstance.Data.Instance.BrokerVpcId");
			instance.BrokerVpcName = context.StringValue("GetInstance.Data.Instance.BrokerVpcName");
			instance.ClientVpcId = context.StringValue("GetInstance.Data.Instance.ClientVpcId");
			instance.ClientVpcName = context.StringValue("GetInstance.Data.Instance.ClientVpcName");
			instance.ClusterMembers = context.IntegerValue("GetInstance.Data.Instance.ClusterMembers");
			instance.CredentialGroup = context.LongValue("GetInstance.Data.Instance.CredentialGroup");
			instance.CsbAccountId = context.StringValue("GetInstance.Data.Instance.CsbAccountId");
			instance.CsbId = context.LongValue("GetInstance.Data.Instance.CsbId");
			instance.DbStatus = context.IntegerValue("GetInstance.Data.Instance.DbStatus");
			instance.Description = context.StringValue("GetInstance.Data.Instance.Description");
			instance.FrontStatus = context.StringValue("GetInstance.Data.Instance.FrontStatus");
			instance.GmtCreate = context.LongValue("GetInstance.Data.Instance.GmtCreate");
			instance.GmtModified = context.LongValue("GetInstance.Data.Instance.GmtModified");
			instance.Id = context.LongValue("GetInstance.Data.Instance.Id");
			instance.InstanceCategory = context.IntegerValue("GetInstance.Data.Instance.InstanceCategory");
			instance.InstanceType = context.IntegerValue("GetInstance.Data.Instance.InstanceType");
			instance.IpList = context.StringValue("GetInstance.Data.Instance.IpList");
			instance.IsImported = context.BooleanValue("GetInstance.Data.Instance.IsImported");
			instance.IsPublic = context.BooleanValue("GetInstance.Data.Instance.IsPublic");
			instance.Name = context.StringValue("GetInstance.Data.Instance.Name");
			instance.OwnerId = context.StringValue("GetInstance.Data.Instance.OwnerId");
			instance.SentinelCtlStr = context.StringValue("GetInstance.Data.Instance.SentinelCtlStr");
			instance.SentinelCtrl = context.LongValue("GetInstance.Data.Instance.SentinelCtrl");
			instance.SentinelGridInterval = context.IntegerValue("GetInstance.Data.Instance.SentinelGridInterval");
			instance.SentinelQps = context.LongValue("GetInstance.Data.Instance.SentinelQps");
			instance.Status = context.StringValue("GetInstance.Data.Instance.Status");
			instance.StatusCode = context.IntegerValue("GetInstance.Data.Instance.StatusCode");
			instance.TenantId = context.StringValue("GetInstance.Data.Instance.TenantId");
			instance.Testable = context.BooleanValue("GetInstance.Data.Instance.Testable");
			instance.UserId = context.StringValue("GetInstance.Data.Instance.UserId");
			instance.Visible = context.BooleanValue("GetInstance.Data.Instance.Visible");
			instance.VpcName = context.StringValue("GetInstance.Data.Instance.VpcName");
			data.Instance = instance;
			getInstanceResponse.Data = data;
        
			return getInstanceResponse;
        }
    }
}