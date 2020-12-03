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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaDBInfoResponseUnmarshaller
    {
        public static GetMetaDBInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaDBInfoResponse getMetaDBInfoResponse = new GetMetaDBInfoResponse();

			getMetaDBInfoResponse.HttpResponse = _ctx.HttpResponse;
			getMetaDBInfoResponse.RequestId = _ctx.StringValue("GetMetaDBInfo.RequestId");

			GetMetaDBInfoResponse.GetMetaDBInfo_Data data = new GetMetaDBInfoResponse.GetMetaDBInfo_Data();
			data.AppGuid = _ctx.StringValue("GetMetaDBInfo.Data.AppGuid");
			data.TenantId = _ctx.LongValue("GetMetaDBInfo.Data.TenantId");
			data.Endpoint = _ctx.StringValue("GetMetaDBInfo.Data.Endpoint");
			data.ProjectId = _ctx.LongValue("GetMetaDBInfo.Data.ProjectId");
			data.EnvType = _ctx.IntegerValue("GetMetaDBInfo.Data.EnvType");
			data.ProjectName = _ctx.StringValue("GetMetaDBInfo.Data.ProjectName");
			data.ProjectNameCn = _ctx.StringValue("GetMetaDBInfo.Data.ProjectNameCn");
			data.CreateTime = _ctx.LongValue("GetMetaDBInfo.Data.CreateTime");
			data.ModifyTime = _ctx.LongValue("GetMetaDBInfo.Data.ModifyTime");
			data.OwnerId = _ctx.StringValue("GetMetaDBInfo.Data.OwnerId");
			data.OwnerName = _ctx.StringValue("GetMetaDBInfo.Data.OwnerName");
			data.Name = _ctx.StringValue("GetMetaDBInfo.Data.Name");
			data.Type = _ctx.StringValue("GetMetaDBInfo.Data.Type");
			data.Comment = _ctx.StringValue("GetMetaDBInfo.Data.Comment");
			data.Location = _ctx.StringValue("GetMetaDBInfo.Data.Location");
			data.ClusterBizId = _ctx.StringValue("GetMetaDBInfo.Data.ClusterBizId");
			getMetaDBInfoResponse.Data = data;
        
			return getMetaDBInfoResponse;
        }
    }
}
