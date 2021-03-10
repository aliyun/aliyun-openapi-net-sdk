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
    public class GetDataCronClearTaskDetailListResponseUnmarshaller
    {
        public static GetDataCronClearTaskDetailListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataCronClearTaskDetailListResponse getDataCronClearTaskDetailListResponse = new GetDataCronClearTaskDetailListResponse();

			getDataCronClearTaskDetailListResponse.HttpResponse = _ctx.HttpResponse;
			getDataCronClearTaskDetailListResponse.TotalCount = _ctx.LongValue("GetDataCronClearTaskDetailList.TotalCount");
			getDataCronClearTaskDetailListResponse.RequestId = _ctx.StringValue("GetDataCronClearTaskDetailList.RequestId");
			getDataCronClearTaskDetailListResponse.ErrorCode = _ctx.StringValue("GetDataCronClearTaskDetailList.ErrorCode");
			getDataCronClearTaskDetailListResponse.ErrorMessage = _ctx.StringValue("GetDataCronClearTaskDetailList.ErrorMessage");
			getDataCronClearTaskDetailListResponse.Success = _ctx.BooleanValue("GetDataCronClearTaskDetailList.Success");

			List<GetDataCronClearTaskDetailListResponse.GetDataCronClearTaskDetailList_DataCronClearTaskDetail> getDataCronClearTaskDetailListResponse_dataCronClearTaskDetailList = new List<GetDataCronClearTaskDetailListResponse.GetDataCronClearTaskDetailList_DataCronClearTaskDetail>();
			for (int i = 0; i < _ctx.Length("GetDataCronClearTaskDetailList.DataCronClearTaskDetailList.Length"); i++) {
				GetDataCronClearTaskDetailListResponse.GetDataCronClearTaskDetailList_DataCronClearTaskDetail dataCronClearTaskDetail = new GetDataCronClearTaskDetailListResponse.GetDataCronClearTaskDetailList_DataCronClearTaskDetail();
				dataCronClearTaskDetail.JobStatus = _ctx.StringValue("GetDataCronClearTaskDetailList.DataCronClearTaskDetailList["+ i +"].jobStatus");
				dataCronClearTaskDetail.CreateTime = _ctx.StringValue("GetDataCronClearTaskDetailList.DataCronClearTaskDetailList["+ i +"].CreateTime");
				dataCronClearTaskDetail.ActualAffectRows = _ctx.LongValue("GetDataCronClearTaskDetailList.DataCronClearTaskDetailList["+ i +"].ActualAffectRows");
				dataCronClearTaskDetail.DBTaskGroupId = _ctx.LongValue("GetDataCronClearTaskDetailList.DataCronClearTaskDetailList["+ i +"].DBTaskGroupId");

				getDataCronClearTaskDetailListResponse_dataCronClearTaskDetailList.Add(dataCronClearTaskDetail);
			}
			getDataCronClearTaskDetailListResponse.DataCronClearTaskDetailList = getDataCronClearTaskDetailListResponse_dataCronClearTaskDetailList;
        
			return getDataCronClearTaskDetailListResponse;
        }
    }
}
