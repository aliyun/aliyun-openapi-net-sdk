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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class KillProcessListResponseUnmarshaller
    {
        public static KillProcessListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			KillProcessListResponse killProcessListResponse = new KillProcessListResponse();

			killProcessListResponse.HttpResponse = _ctx.HttpResponse;
			killProcessListResponse.RequestId = _ctx.StringValue("KillProcessList.RequestId");

			List<KillProcessListResponse.KillProcessList_DataItem> killProcessListResponse_data = new List<KillProcessListResponse.KillProcessList_DataItem>();
			for (int i = 0; i < _ctx.Length("KillProcessList.Data.Length"); i++) {
				KillProcessListResponse.KillProcessList_DataItem dataItem = new KillProcessListResponse.KillProcessList_DataItem();
				dataItem.SessionId = _ctx.LongValue("KillProcessList.Data["+ i +"].SessionId");
				dataItem.ServerIp = _ctx.StringValue("KillProcessList.Data["+ i +"].ServerIp");
				dataItem.Status = _ctx.StringValue("KillProcessList.Data["+ i +"].Status");
				dataItem.ErrorMessage = _ctx.StringValue("KillProcessList.Data["+ i +"].ErrorMessage");
				dataItem.ClientIp = _ctx.StringValue("KillProcessList.Data["+ i +"].ClientIp");
				dataItem.TenantId = _ctx.StringValue("KillProcessList.Data["+ i +"].TenantId");
				dataItem.User = _ctx.StringValue("KillProcessList.Data["+ i +"].User");
				dataItem.Database = _ctx.StringValue("KillProcessList.Data["+ i +"].Database");
				dataItem.SqlText = _ctx.StringValue("KillProcessList.Data["+ i +"].SqlText");
				dataItem.Command = _ctx.StringValue("KillProcessList.Data["+ i +"].Command");
				dataItem.ExecuteTime = _ctx.StringValue("KillProcessList.Data["+ i +"].ExecuteTime");

				killProcessListResponse_data.Add(dataItem);
			}
			killProcessListResponse.Data = killProcessListResponse_data;
        
			return killProcessListResponse;
        }
    }
}
