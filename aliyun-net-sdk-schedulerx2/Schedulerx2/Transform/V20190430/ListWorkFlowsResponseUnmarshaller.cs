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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class ListWorkFlowsResponseUnmarshaller
    {
        public static ListWorkFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkFlowsResponse listWorkFlowsResponse = new ListWorkFlowsResponse();

			listWorkFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listWorkFlowsResponse.RequestId = _ctx.StringValue("ListWorkFlows.RequestId");
			listWorkFlowsResponse.Message = _ctx.StringValue("ListWorkFlows.Message");
			listWorkFlowsResponse.Code = _ctx.IntegerValue("ListWorkFlows.Code");
			listWorkFlowsResponse.Success = _ctx.BooleanValue("ListWorkFlows.Success");

			ListWorkFlowsResponse.ListWorkFlows_Data data = new ListWorkFlowsResponse.ListWorkFlows_Data();
			data.PageSize = _ctx.IntegerValue("ListWorkFlows.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("ListWorkFlows.Data.PageNumber");
			data.Total = _ctx.IntegerValue("ListWorkFlows.Data.Total");

			List<ListWorkFlowsResponse.ListWorkFlows_Data.ListWorkFlows_Record> data_records = new List<ListWorkFlowsResponse.ListWorkFlows_Data.ListWorkFlows_Record>();
			for (int i = 0; i < _ctx.Length("ListWorkFlows.Data.Records.Length"); i++) {
				ListWorkFlowsResponse.ListWorkFlows_Data.ListWorkFlows_Record record = new ListWorkFlowsResponse.ListWorkFlows_Data.ListWorkFlows_Record();
				record.Description = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Description");
				record.Updater = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Updater");
				record.Calendar = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Calendar");
				record.MaxConcurrency = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].MaxConcurrency");
				record.TimeExpression = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].TimeExpression");
				record.Creator = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Creator");
				record.WorkflowId = _ctx.LongValue("ListWorkFlows.Data.Records["+ i +"].WorkflowId");
				record._Namespace = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Namespace");
				record.GroupId = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].GroupId");
				record.Name = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].Name");
				record.TimeType = _ctx.StringValue("ListWorkFlows.Data.Records["+ i +"].TimeType");

				data_records.Add(record);
			}
			data.Records = data_records;
			listWorkFlowsResponse.Data = data;
        
			return listWorkFlowsResponse;
        }
    }
}
