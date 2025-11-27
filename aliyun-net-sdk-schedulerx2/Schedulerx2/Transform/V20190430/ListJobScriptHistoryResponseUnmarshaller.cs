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
    public class ListJobScriptHistoryResponseUnmarshaller
    {
        public static ListJobScriptHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobScriptHistoryResponse listJobScriptHistoryResponse = new ListJobScriptHistoryResponse();

			listJobScriptHistoryResponse.HttpResponse = _ctx.HttpResponse;
			listJobScriptHistoryResponse.Code = _ctx.IntegerValue("ListJobScriptHistory.Code");
			listJobScriptHistoryResponse.Message = _ctx.StringValue("ListJobScriptHistory.Message");
			listJobScriptHistoryResponse.RequestId = _ctx.StringValue("ListJobScriptHistory.RequestId");
			listJobScriptHistoryResponse.Success = _ctx.BooleanValue("ListJobScriptHistory.Success");

			ListJobScriptHistoryResponse.ListJobScriptHistory_Data data = new ListJobScriptHistoryResponse.ListJobScriptHistory_Data();

			List<ListJobScriptHistoryResponse.ListJobScriptHistory_Data.ListJobScriptHistory_JobScriptHistoryInfo> data_jobScriptHistoryInfos = new List<ListJobScriptHistoryResponse.ListJobScriptHistory_Data.ListJobScriptHistory_JobScriptHistoryInfo>();
			for (int i = 0; i < _ctx.Length("ListJobScriptHistory.Data.JobScriptHistoryInfos.Length"); i++) {
				ListJobScriptHistoryResponse.ListJobScriptHistory_Data.ListJobScriptHistory_JobScriptHistoryInfo jobScriptHistoryInfo = new ListJobScriptHistoryResponse.ListJobScriptHistory_Data.ListJobScriptHistory_JobScriptHistoryInfo();
				jobScriptHistoryInfo.VersionesDescription = _ctx.StringValue("ListJobScriptHistory.Data.JobScriptHistoryInfos["+ i +"].VersionesDescription");
				jobScriptHistoryInfo.Creator = _ctx.StringValue("ListJobScriptHistory.Data.JobScriptHistoryInfos["+ i +"].Creator");
				jobScriptHistoryInfo.CreateTime = _ctx.StringValue("ListJobScriptHistory.Data.JobScriptHistoryInfos["+ i +"].CreateTime");
				jobScriptHistoryInfo.ScriptContent = _ctx.StringValue("ListJobScriptHistory.Data.JobScriptHistoryInfos["+ i +"].ScriptContent");

				data_jobScriptHistoryInfos.Add(jobScriptHistoryInfo);
			}
			data.JobScriptHistoryInfos = data_jobScriptHistoryInfos;
			listJobScriptHistoryResponse.Data = data;
        
			return listJobScriptHistoryResponse;
        }
    }
}
