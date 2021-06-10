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
    public class ListDBTaskSQLJobDetailResponseUnmarshaller
    {
        public static ListDBTaskSQLJobDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDBTaskSQLJobDetailResponse listDBTaskSQLJobDetailResponse = new ListDBTaskSQLJobDetailResponse();

			listDBTaskSQLJobDetailResponse.HttpResponse = _ctx.HttpResponse;
			listDBTaskSQLJobDetailResponse.RequestId = _ctx.StringValue("ListDBTaskSQLJobDetail.RequestId");
			listDBTaskSQLJobDetailResponse.Success = _ctx.BooleanValue("ListDBTaskSQLJobDetail.Success");
			listDBTaskSQLJobDetailResponse.ErrorMessage = _ctx.StringValue("ListDBTaskSQLJobDetail.ErrorMessage");
			listDBTaskSQLJobDetailResponse.ErrorCode = _ctx.StringValue("ListDBTaskSQLJobDetail.ErrorCode");
			listDBTaskSQLJobDetailResponse.TotalCount = _ctx.LongValue("ListDBTaskSQLJobDetail.TotalCount");

			List<ListDBTaskSQLJobDetailResponse.ListDBTaskSQLJobDetail_DBTaskSQLJobDetail> listDBTaskSQLJobDetailResponse_dBTaskSQLJobDetailList = new List<ListDBTaskSQLJobDetailResponse.ListDBTaskSQLJobDetail_DBTaskSQLJobDetail>();
			for (int i = 0; i < _ctx.Length("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList.Length"); i++) {
				ListDBTaskSQLJobDetailResponse.ListDBTaskSQLJobDetail_DBTaskSQLJobDetail dBTaskSQLJobDetail = new ListDBTaskSQLJobDetailResponse.ListDBTaskSQLJobDetail_DBTaskSQLJobDetail();
				dBTaskSQLJobDetail.JobDetailId = _ctx.LongValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].JobDetailId");
				dBTaskSQLJobDetail.CurrentSql = _ctx.StringValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].CurrentSql");
				dBTaskSQLJobDetail.ExecuteCount = _ctx.LongValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].ExecuteCount");
				dBTaskSQLJobDetail.JobId = _ctx.LongValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].JobId");
				dBTaskSQLJobDetail.DbId = _ctx.LongValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].DbId");
				dBTaskSQLJobDetail.Logic = _ctx.BooleanValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].Logic");
				dBTaskSQLJobDetail.Skip = _ctx.BooleanValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].Skip");
				dBTaskSQLJobDetail.SqlType = _ctx.StringValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].SqlType");
				dBTaskSQLJobDetail.Status = _ctx.StringValue("ListDBTaskSQLJobDetail.DBTaskSQLJobDetailList["+ i +"].Status");

				listDBTaskSQLJobDetailResponse_dBTaskSQLJobDetailList.Add(dBTaskSQLJobDetail);
			}
			listDBTaskSQLJobDetailResponse.DBTaskSQLJobDetailList = listDBTaskSQLJobDetailResponse_dBTaskSQLJobDetailList;
        
			return listDBTaskSQLJobDetailResponse;
        }
    }
}
