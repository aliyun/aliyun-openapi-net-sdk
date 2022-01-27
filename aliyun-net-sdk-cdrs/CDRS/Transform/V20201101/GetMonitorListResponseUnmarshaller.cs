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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class GetMonitorListResponseUnmarshaller
    {
        public static GetMonitorListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMonitorListResponse getMonitorListResponse = new GetMonitorListResponse();

			getMonitorListResponse.HttpResponse = _ctx.HttpResponse;
			getMonitorListResponse.Code = _ctx.StringValue("GetMonitorList.Code");
			getMonitorListResponse.Message = _ctx.StringValue("GetMonitorList.Message");
			getMonitorListResponse.RequestId = _ctx.StringValue("GetMonitorList.RequestId");

			GetMonitorListResponse.GetMonitorList_Data data = new GetMonitorListResponse.GetMonitorList_Data();
			data.PageNumber = _ctx.IntegerValue("GetMonitorList.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("GetMonitorList.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("GetMonitorList.Data.TotalCount");
			data.TotalPage = _ctx.IntegerValue("GetMonitorList.Data.TotalPage");

			List<GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record> data_records = new List<GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record>();
			for (int i = 0; i < _ctx.Length("GetMonitorList.Data.Records.Length"); i++) {
				GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record record = new GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record();
				record.TaskId = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].TaskId");
				record.Status = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].Status");
				record.MonitorType = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].MonitorType");
				record.RuleName = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].RuleName");
				record.AlgorithmVendor = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].AlgorithmVendor");
				record.CreateDate = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].CreateDate");
				record.ModifiedDate = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].ModifiedDate");
				record.DeviceList = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].DeviceList");
				record.Attributes = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].Attributes");
				record.RuleExpression = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].RuleExpression");
				record.NotifierType = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].NotifierType");
				record.NotifierExtra = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].NotifierExtra");
				record.Description = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].Description");
				record.Expression = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].Expression");
				record.ImageMatch = _ctx.StringValue("GetMonitorList.Data.Records["+ i +"].ImageMatch");

				data_records.Add(record);
			}
			data.Records = data_records;
			getMonitorListResponse.Data = data;
        
			return getMonitorListResponse;
        }
    }
}
