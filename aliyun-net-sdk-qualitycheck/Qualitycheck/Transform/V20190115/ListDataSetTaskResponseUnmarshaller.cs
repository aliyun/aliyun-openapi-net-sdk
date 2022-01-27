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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ListDataSetTaskResponseUnmarshaller
    {
        public static ListDataSetTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSetTaskResponse listDataSetTaskResponse = new ListDataSetTaskResponse();

			listDataSetTaskResponse.HttpResponse = _ctx.HttpResponse;
			listDataSetTaskResponse.CurrentPage = _ctx.IntegerValue("ListDataSetTask.CurrentPage");
			listDataSetTaskResponse.DataSize = _ctx.IntegerValue("ListDataSetTask.DataSize");
			listDataSetTaskResponse.RequestId = _ctx.StringValue("ListDataSetTask.RequestId");
			listDataSetTaskResponse.Success = _ctx.BooleanValue("ListDataSetTask.Success");
			listDataSetTaskResponse.Code = _ctx.StringValue("ListDataSetTask.Code");
			listDataSetTaskResponse.IsAllcomplete = _ctx.IntegerValue("ListDataSetTask.IsAllcomplete");
			listDataSetTaskResponse.Message = _ctx.StringValue("ListDataSetTask.Message");
			listDataSetTaskResponse.PageSize = _ctx.IntegerValue("ListDataSetTask.PageSize");
			listDataSetTaskResponse.TotalCount = _ctx.IntegerValue("ListDataSetTask.TotalCount");

			List<ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo> listDataSetTaskResponse_data = new List<ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo>();
			for (int i = 0; i < _ctx.Length("ListDataSetTask.Data.Length"); i++) {
				ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo pageTaskInfo = new ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo();
				pageTaskInfo.Status = _ctx.IntegerValue("ListDataSetTask.Data["+ i +"].Status");
				pageTaskInfo.IsTaskComplete = _ctx.BooleanValue("ListDataSetTask.Data["+ i +"].IsTaskComplete");
				pageTaskInfo.ScheduleRatio = _ctx.FloatValue("ListDataSetTask.Data["+ i +"].ScheduleRatio");
				pageTaskInfo.TaskComplete = _ctx.BooleanValue("ListDataSetTask.Data["+ i +"].TaskComplete");
				pageTaskInfo.DataSetSize = _ctx.IntegerValue("ListDataSetTask.Data["+ i +"].DataSetSize");
				pageTaskInfo.RuleSize = _ctx.IntegerValue("ListDataSetTask.Data["+ i +"].RuleSize");
				pageTaskInfo.JobName = _ctx.StringValue("ListDataSetTask.Data["+ i +"].JobName");
				pageTaskInfo.TaskId = _ctx.StringValue("ListDataSetTask.Data["+ i +"].TaskId");

				List<string> pageTaskInfo_dataSets = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDataSetTask.Data["+ i +"].DataSets.Length"); j++) {
					pageTaskInfo_dataSets.Add(_ctx.StringValue("ListDataSetTask.Data["+ i +"].DataSets["+ j +"]"));
				}
				pageTaskInfo.DataSets = pageTaskInfo_dataSets;

				List<ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo.ListDataSetTask_RuleNameInfo> pageTaskInfo_ruleNameInfoList = new List<ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo.ListDataSetTask_RuleNameInfo>();
				for (int j = 0; j < _ctx.Length("ListDataSetTask.Data["+ i +"].RuleNameInfoList.Length"); j++) {
					ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo.ListDataSetTask_RuleNameInfo ruleNameInfo = new ListDataSetTaskResponse.ListDataSetTask_PageTaskInfo.ListDataSetTask_RuleNameInfo();
					ruleNameInfo.RuleName = _ctx.StringValue("ListDataSetTask.Data["+ i +"].RuleNameInfoList["+ j +"].RuleName");
					ruleNameInfo.Rid = _ctx.IntegerValue("ListDataSetTask.Data["+ i +"].RuleNameInfoList["+ j +"].Rid");

					pageTaskInfo_ruleNameInfoList.Add(ruleNameInfo);
				}
				pageTaskInfo.RuleNameInfoList = pageTaskInfo_ruleNameInfoList;

				listDataSetTaskResponse_data.Add(pageTaskInfo);
			}
			listDataSetTaskResponse.Data = listDataSetTaskResponse_data;
        
			return listDataSetTaskResponse;
        }
    }
}
