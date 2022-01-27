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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ExecuteStatusResponseUnmarshaller
    {
        public static ExecuteStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecuteStatusResponse executeStatusResponse = new ExecuteStatusResponse();

			executeStatusResponse.HttpResponse = _ctx.HttpResponse;
			executeStatusResponse.Code = _ctx.IntegerValue("ExecuteStatus.Code");
			executeStatusResponse.Message = _ctx.StringValue("ExecuteStatus.Message");
			executeStatusResponse.Success = _ctx.BooleanValue("ExecuteStatus.Success");
			executeStatusResponse.RequestId = _ctx.StringValue("ExecuteStatus.RequestId");

			ExecuteStatusResponse.ExecuteStatus_Data data = new ExecuteStatusResponse.ExecuteStatus_Data();
			data.Id = _ctx.LongValue("ExecuteStatus.Data.Id");
			data.Region = _ctx.StringValue("ExecuteStatus.Data.Region");
			data.NamespaceId = _ctx.StringValue("ExecuteStatus.Data.NamespaceId");
			data.TenantId = _ctx.StringValue("ExecuteStatus.Data.TenantId");
			data.Source = _ctx.StringValue("ExecuteStatus.Data.Source");
			data.AccountId = _ctx.StringValue("ExecuteStatus.Data.AccountId");
			data.AppId = _ctx.StringValue("ExecuteStatus.Data.AppId");
			data.Ip = _ctx.StringValue("ExecuteStatus.Data.Ip");
			data.PodName = _ctx.StringValue("ExecuteStatus.Data.PodName");
			data.Status = _ctx.StringValue("ExecuteStatus.Data.Status");
			executeStatusResponse.Data = data;
        
			return executeStatusResponse;
        }
    }
}
