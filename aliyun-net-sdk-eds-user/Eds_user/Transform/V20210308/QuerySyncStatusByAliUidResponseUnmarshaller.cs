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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class QuerySyncStatusByAliUidResponseUnmarshaller
    {
        public static QuerySyncStatusByAliUidResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySyncStatusByAliUidResponse querySyncStatusByAliUidResponse = new QuerySyncStatusByAliUidResponse();

			querySyncStatusByAliUidResponse.HttpResponse = _ctx.HttpResponse;
			querySyncStatusByAliUidResponse.Success = _ctx.BooleanValue("QuerySyncStatusByAliUid.Success");
			querySyncStatusByAliUidResponse.Code = _ctx.StringValue("QuerySyncStatusByAliUid.Code");
			querySyncStatusByAliUidResponse.Message = _ctx.StringValue("QuerySyncStatusByAliUid.Message");
			querySyncStatusByAliUidResponse.HttpStatusCode = _ctx.IntegerValue("QuerySyncStatusByAliUid.HttpStatusCode");
			querySyncStatusByAliUidResponse.RequestId = _ctx.StringValue("QuerySyncStatusByAliUid.RequestId");

			QuerySyncStatusByAliUidResponse.QuerySyncStatusByAliUid_Data data = new QuerySyncStatusByAliUidResponse.QuerySyncStatusByAliUid_Data();
			data.Id = _ctx.LongValue("QuerySyncStatusByAliUid.Data.Id");
			data.GmtCreated = _ctx.StringValue("QuerySyncStatusByAliUid.Data.GmtCreated");
			data.GmtModified = _ctx.StringValue("QuerySyncStatusByAliUid.Data.GmtModified");
			data.AliUid = _ctx.LongValue("QuerySyncStatusByAliUid.Data.AliUid");
			data.Status = _ctx.StringValue("QuerySyncStatusByAliUid.Data.Status");
			data.CorpId = _ctx.StringValue("QuerySyncStatusByAliUid.Data.CorpId");
			data.LatestBeginTime = _ctx.StringValue("QuerySyncStatusByAliUid.Data.LatestBeginTime");
			data.LatestEndTime = _ctx.StringValue("QuerySyncStatusByAliUid.Data.LatestEndTime");
			data.LatestSuccessTime = _ctx.StringValue("QuerySyncStatusByAliUid.Data.LatestSuccessTime");
			querySyncStatusByAliUidResponse.Data = data;
        
			return querySyncStatusByAliUidResponse;
        }
    }
}
