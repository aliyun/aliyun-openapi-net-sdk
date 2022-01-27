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
    public class GetStructSyncJobDetailResponseUnmarshaller
    {
        public static GetStructSyncJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStructSyncJobDetailResponse getStructSyncJobDetailResponse = new GetStructSyncJobDetailResponse();

			getStructSyncJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			getStructSyncJobDetailResponse.RequestId = _ctx.StringValue("GetStructSyncJobDetail.RequestId");
			getStructSyncJobDetailResponse.Success = _ctx.BooleanValue("GetStructSyncJobDetail.Success");
			getStructSyncJobDetailResponse.ErrorMessage = _ctx.StringValue("GetStructSyncJobDetail.ErrorMessage");
			getStructSyncJobDetailResponse.ErrorCode = _ctx.StringValue("GetStructSyncJobDetail.ErrorCode");

			GetStructSyncJobDetailResponse.GetStructSyncJobDetail_StructSyncJobDetail structSyncJobDetail = new GetStructSyncJobDetailResponse.GetStructSyncJobDetail_StructSyncJobDetail();
			structSyncJobDetail.JobStatus = _ctx.StringValue("GetStructSyncJobDetail.StructSyncJobDetail.JobStatus");
			structSyncJobDetail.Message = _ctx.StringValue("GetStructSyncJobDetail.StructSyncJobDetail.Message");
			structSyncJobDetail.TableAnalyzed = _ctx.LongValue("GetStructSyncJobDetail.StructSyncJobDetail.TableAnalyzed");
			structSyncJobDetail.TableCount = _ctx.LongValue("GetStructSyncJobDetail.StructSyncJobDetail.TableCount");
			structSyncJobDetail.SqlCount = _ctx.LongValue("GetStructSyncJobDetail.StructSyncJobDetail.SqlCount");
			structSyncJobDetail.ExecuteCount = _ctx.LongValue("GetStructSyncJobDetail.StructSyncJobDetail.ExecuteCount");
			structSyncJobDetail.SecurityRule = _ctx.StringValue("GetStructSyncJobDetail.StructSyncJobDetail.SecurityRule");
			structSyncJobDetail.DBTaskGroupId = _ctx.LongValue("GetStructSyncJobDetail.StructSyncJobDetail.DBTaskGroupId");
			getStructSyncJobDetailResponse.StructSyncJobDetail = structSyncJobDetail;
        
			return getStructSyncJobDetailResponse;
        }
    }
}
