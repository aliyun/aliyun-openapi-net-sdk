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
    public class GetStructSyncExecSqlDetailResponseUnmarshaller
    {
        public static GetStructSyncExecSqlDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStructSyncExecSqlDetailResponse getStructSyncExecSqlDetailResponse = new GetStructSyncExecSqlDetailResponse();

			getStructSyncExecSqlDetailResponse.HttpResponse = _ctx.HttpResponse;
			getStructSyncExecSqlDetailResponse.RequestId = _ctx.StringValue("GetStructSyncExecSqlDetail.RequestId");
			getStructSyncExecSqlDetailResponse.Success = _ctx.BooleanValue("GetStructSyncExecSqlDetail.Success");
			getStructSyncExecSqlDetailResponse.ErrorMessage = _ctx.StringValue("GetStructSyncExecSqlDetail.ErrorMessage");
			getStructSyncExecSqlDetailResponse.ErrorCode = _ctx.StringValue("GetStructSyncExecSqlDetail.ErrorCode");

			GetStructSyncExecSqlDetailResponse.GetStructSyncExecSqlDetail_StructSyncExecSqlDetail structSyncExecSqlDetail = new GetStructSyncExecSqlDetailResponse.GetStructSyncExecSqlDetail_StructSyncExecSqlDetail();
			structSyncExecSqlDetail.TotalSqlCount = _ctx.LongValue("GetStructSyncExecSqlDetail.StructSyncExecSqlDetail.TotalSqlCount");
			structSyncExecSqlDetail.ExecSql = _ctx.StringValue("GetStructSyncExecSqlDetail.StructSyncExecSqlDetail.ExecSql");
			getStructSyncExecSqlDetailResponse.StructSyncExecSqlDetail = structSyncExecSqlDetail;
        
			return getStructSyncExecSqlDetailResponse;
        }
    }
}
