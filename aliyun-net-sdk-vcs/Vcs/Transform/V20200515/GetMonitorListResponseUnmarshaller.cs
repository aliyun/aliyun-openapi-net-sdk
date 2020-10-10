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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetMonitorListResponseUnmarshaller
    {
        public static GetMonitorListResponse Unmarshall(UnmarshallerContext context)
        {
			GetMonitorListResponse getMonitorListResponse = new GetMonitorListResponse();

			getMonitorListResponse.HttpResponse = context.HttpResponse;
			getMonitorListResponse.Code = context.StringValue("GetMonitorList.Code");
			getMonitorListResponse.Message = context.StringValue("GetMonitorList.Message");
			getMonitorListResponse.RequestId = context.StringValue("GetMonitorList.RequestId");

			GetMonitorListResponse.GetMonitorList_Data data = new GetMonitorListResponse.GetMonitorList_Data();
			data.PageNo = context.IntegerValue("GetMonitorList.Data.PageNo");
			data.PageSize = context.IntegerValue("GetMonitorList.Data.PageSize");
			data.TotalCount = context.IntegerValue("GetMonitorList.Data.TotalCount");
			data.TotalPage = context.IntegerValue("GetMonitorList.Data.TotalPage");

			List<GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record> data_records = new List<GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record>();
			for (int i = 0; i < context.Length("GetMonitorList.Data.Records.Length"); i++) {
				GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record record = new GetMonitorListResponse.GetMonitorList_Data.GetMonitorList_Record();
				record.TaskId = context.StringValue("GetMonitorList.Data.Records["+ i +"].TaskId");
				record.Status = context.StringValue("GetMonitorList.Data.Records["+ i +"].Status");
				record.MonitorType = context.StringValue("GetMonitorList.Data.Records["+ i +"].MonitorType");
				record.RuleName = context.StringValue("GetMonitorList.Data.Records["+ i +"].RuleName");
				record.AlgorithmVendor = context.StringValue("GetMonitorList.Data.Records["+ i +"].AlgorithmVendor");
				record.CreateDate = context.StringValue("GetMonitorList.Data.Records["+ i +"].CreateDate");
				record.ModifiedDate = context.StringValue("GetMonitorList.Data.Records["+ i +"].ModifiedDate");
				record.DeviceList = context.StringValue("GetMonitorList.Data.Records["+ i +"].DeviceList");
				record.Attributes = context.StringValue("GetMonitorList.Data.Records["+ i +"].Attributes");
				record.RuleExpression = context.StringValue("GetMonitorList.Data.Records["+ i +"].RuleExpression");
				record.NotifierType = context.StringValue("GetMonitorList.Data.Records["+ i +"].NotifierType");
				record.NotifierExtra = context.StringValue("GetMonitorList.Data.Records["+ i +"].NotifierExtra");
				record.Description = context.StringValue("GetMonitorList.Data.Records["+ i +"].Description");
				record.Expression = context.StringValue("GetMonitorList.Data.Records["+ i +"].Expression");
				record.ImageMatch = context.StringValue("GetMonitorList.Data.Records["+ i +"].ImageMatch");

				data_records.Add(record);
			}
			data.Records = data_records;
			getMonitorListResponse.Data = data;
        
			return getMonitorListResponse;
        }
    }
}
