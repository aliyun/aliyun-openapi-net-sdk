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
    public class GetCdrsMonitorListResponseUnmarshaller
    {
        public static GetCdrsMonitorListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCdrsMonitorListResponse getCdrsMonitorListResponse = new GetCdrsMonitorListResponse();

			getCdrsMonitorListResponse.HttpResponse = _ctx.HttpResponse;
			getCdrsMonitorListResponse.Code = _ctx.StringValue("GetCdrsMonitorList.Code");
			getCdrsMonitorListResponse.Message = _ctx.StringValue("GetCdrsMonitorList.Message");
			getCdrsMonitorListResponse.RequestId = _ctx.StringValue("GetCdrsMonitorList.RequestId");

			GetCdrsMonitorListResponse.GetCdrsMonitorList_Data data = new GetCdrsMonitorListResponse.GetCdrsMonitorList_Data();
			data.PageNo = _ctx.IntegerValue("GetCdrsMonitorList.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("GetCdrsMonitorList.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("GetCdrsMonitorList.Data.TotalCount");
			data.TotalPage = _ctx.IntegerValue("GetCdrsMonitorList.Data.TotalPage");

			List<GetCdrsMonitorListResponse.GetCdrsMonitorList_Data.GetCdrsMonitorList_Record> data_records = new List<GetCdrsMonitorListResponse.GetCdrsMonitorList_Data.GetCdrsMonitorList_Record>();
			for (int i = 0; i < _ctx.Length("GetCdrsMonitorList.Data.Records.Length"); i++) {
				GetCdrsMonitorListResponse.GetCdrsMonitorList_Data.GetCdrsMonitorList_Record record = new GetCdrsMonitorListResponse.GetCdrsMonitorList_Data.GetCdrsMonitorList_Record();
				record.TaskId = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].TaskId");
				record.Status = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].Status");
				record.MonitorType = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].MonitorType");
				record.RuleName = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].RuleName");
				record.AlgorithmVendor = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].AlgorithmVendor");
				record.CreateDate = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].CreateDate");
				record.ModifiedDate = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].ModifiedDate");
				record.DeviceList = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].DeviceList");
				record.Attributes = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].Attributes");
				record.RuleExpression = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].RuleExpression");
				record.NotifierType = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].NotifierType");
				record.NotifierExtra = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].NotifierExtra");
				record.Description = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].Description");
				record.Expression = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].Expression");
				record.ImageMatch = _ctx.StringValue("GetCdrsMonitorList.Data.Records["+ i +"].ImageMatch");

				data_records.Add(record);
			}
			data.Records = data_records;
			getCdrsMonitorListResponse.Data = data;
        
			return getCdrsMonitorListResponse;
        }
    }
}
