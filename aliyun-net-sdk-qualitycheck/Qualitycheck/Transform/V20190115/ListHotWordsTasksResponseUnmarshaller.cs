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
    public class ListHotWordsTasksResponseUnmarshaller
    {
        public static ListHotWordsTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListHotWordsTasksResponse listHotWordsTasksResponse = new ListHotWordsTasksResponse();

			listHotWordsTasksResponse.HttpResponse = _ctx.HttpResponse;
			listHotWordsTasksResponse.RequestId = _ctx.StringValue("ListHotWordsTasks.RequestId");
			listHotWordsTasksResponse.Success = _ctx.BooleanValue("ListHotWordsTasks.Success");
			listHotWordsTasksResponse.Code = _ctx.StringValue("ListHotWordsTasks.Code");
			listHotWordsTasksResponse.Message = _ctx.StringValue("ListHotWordsTasks.Message");
			listHotWordsTasksResponse.PageNumber = _ctx.IntegerValue("ListHotWordsTasks.PageNumber");
			listHotWordsTasksResponse.PageSize = _ctx.IntegerValue("ListHotWordsTasks.PageSize");
			listHotWordsTasksResponse.Count = _ctx.IntegerValue("ListHotWordsTasks.Count");

			List<ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo> listHotWordsTasksResponse_data = new List<ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo>();
			for (int i = 0; i < _ctx.Length("ListHotWordsTasks.Data.Length"); i++) {
				ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo hotWordsTaskPo = new ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo();
				hotWordsTaskPo.TaskConfigId = _ctx.LongValue("ListHotWordsTasks.Data["+ i +"].TaskConfigId");
				hotWordsTaskPo.Name = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].Name");
				hotWordsTaskPo.Status = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].Status");
				hotWordsTaskPo.Type = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].Type");
				hotWordsTaskPo.StartTime = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].StartTime");
				hotWordsTaskPo.TimeInterval = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].TimeInterval");
				hotWordsTaskPo.TimeUnit = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].TimeUnit");
				hotWordsTaskPo.EndTime = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].EndTime");
				hotWordsTaskPo.InstanceStatus = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].InstanceStatus");
				hotWordsTaskPo.LastExecutionTime = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].LastExecutionTime");
				hotWordsTaskPo.Message = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].Message");

				ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo.ListHotWordsTasks_DialogueParam dialogueParam = new ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo.ListHotWordsTasks_DialogueParam();
				dialogueParam.DialogueId = _ctx.LongValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.DialogueId");
				dialogueParam.Role = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.Role");
				dialogueParam.StartIndex = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.StartIndex");
				dialogueParam.EndIndex = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.EndIndex");
				dialogueParam.SourceType = _ctx.IntegerValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.SourceType");
				dialogueParam.DataSetIds = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.DataSetIds");
				dialogueParam.StartTime = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.StartTime");
				dialogueParam.EndTime = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].DialogueParam.EndTime");
				hotWordsTaskPo.DialogueParam = dialogueParam;

				ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo.ListHotWordsTasks_WordsParam wordsParam = new ListHotWordsTasksResponse.ListHotWordsTasks_HotWordsTaskPo.ListHotWordsTasks_WordsParam();
				wordsParam.ExtraConfigId = _ctx.LongValue("ListHotWordsTasks.Data["+ i +"].WordsParam.ExtraConfigId");
				wordsParam.Excludes = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].WordsParam.Excludes");
				wordsParam.Includes = _ctx.StringValue("ListHotWordsTasks.Data["+ i +"].WordsParam.Includes");
				hotWordsTaskPo.WordsParam = wordsParam;

				listHotWordsTasksResponse_data.Add(hotWordsTaskPo);
			}
			listHotWordsTasksResponse.Data = listHotWordsTasksResponse_data;
        
			return listHotWordsTasksResponse;
        }
    }
}
