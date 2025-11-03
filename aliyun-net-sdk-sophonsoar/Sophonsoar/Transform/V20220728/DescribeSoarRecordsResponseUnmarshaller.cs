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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeSoarRecordsResponseUnmarshaller
    {
        public static DescribeSoarRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSoarRecordsResponse describeSoarRecordsResponse = new DescribeSoarRecordsResponse();

			describeSoarRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSoarRecordsResponse.RequestId = _ctx.StringValue("DescribeSoarRecords.RequestId");

			DescribeSoarRecordsResponse.DescribeSoarRecords_Page page = new DescribeSoarRecordsResponse.DescribeSoarRecords_Page();
			page.TotalCount = _ctx.IntegerValue("DescribeSoarRecords.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribeSoarRecords.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribeSoarRecords.Page.PageSize");
			describeSoarRecordsResponse.Page = page;

			List<DescribeSoarRecordsResponse.DescribeSoarRecords_Data> describeSoarRecordsResponse_soarExecuteRecords = new List<DescribeSoarRecordsResponse.DescribeSoarRecords_Data>();
			for (int i = 0; i < _ctx.Length("DescribeSoarRecords.SoarExecuteRecords.Length"); i++) {
				DescribeSoarRecordsResponse.DescribeSoarRecords_Data data = new DescribeSoarRecordsResponse.DescribeSoarRecords_Data();
				data.TriggerType = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].TriggerType");
				data.TaskName = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].TaskName");
				data.StartTime = _ctx.LongValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].StartTime");
				data.EndTime = _ctx.LongValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].EndTime");
				data.Status = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].Status");
				data.RequestUuid = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].RequestUuid");
				data.TriggerUser = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].TriggerUser");
				data.ErrorMsg = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].ErrorMsg");
				data.RawEventReq = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].RawEventReq");
				data.TaskflowMd5 = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].TaskflowMd5");

				List<DescribeSoarRecordsResponse.DescribeSoarRecords_Data.DescribeSoarRecords_Output> data_outputList = new List<DescribeSoarRecordsResponse.DescribeSoarRecords_Data.DescribeSoarRecords_Output>();
				for (int j = 0; j < _ctx.Length("DescribeSoarRecords.SoarExecuteRecords["+ i +"].OutputList.Length"); j++) {
					DescribeSoarRecordsResponse.DescribeSoarRecords_Data.DescribeSoarRecords_Output output = new DescribeSoarRecordsResponse.DescribeSoarRecords_Data.DescribeSoarRecords_Output();
					output.Content = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].OutputList["+ j +"].Content");
					output.NodeName = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].OutputList["+ j +"].NodeName");
					output.ActionUuid = _ctx.StringValue("DescribeSoarRecords.SoarExecuteRecords["+ i +"].OutputList["+ j +"].ActionUuid");

					data_outputList.Add(output);
				}
				data.OutputList = data_outputList;

				describeSoarRecordsResponse_soarExecuteRecords.Add(data);
			}
			describeSoarRecordsResponse.SoarExecuteRecords = describeSoarRecordsResponse_soarExecuteRecords;
        
			return describeSoarRecordsResponse;
        }
    }
}
