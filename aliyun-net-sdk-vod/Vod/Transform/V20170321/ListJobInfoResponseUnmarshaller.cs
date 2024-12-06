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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListJobInfoResponseUnmarshaller
    {
        public static ListJobInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListJobInfoResponse listJobInfoResponse = new ListJobInfoResponse();

			listJobInfoResponse.HttpResponse = _ctx.HttpResponse;
			listJobInfoResponse.RequestId = _ctx.StringValue("ListJobInfo.RequestId");
			listJobInfoResponse.MediaId = _ctx.StringValue("ListJobInfo.MediaId");
			listJobInfoResponse.JobType = _ctx.StringValue("ListJobInfo.JobType");

			List<ListJobInfoResponse.ListJobInfo_JobInfoDO> listJobInfoResponse_jobInfoList = new List<ListJobInfoResponse.ListJobInfo_JobInfoDO>();
			for (int i = 0; i < _ctx.Length("ListJobInfo.JobInfoList.Length"); i++) {
				ListJobInfoResponse.ListJobInfo_JobInfoDO jobInfoDO = new ListJobInfoResponse.ListJobInfo_JobInfoDO();
				jobInfoDO.JobId = _ctx.StringValue("ListJobInfo.JobInfoList["+ i +"].JobId");
				jobInfoDO.Status = _ctx.StringValue("ListJobInfo.JobInfoList["+ i +"].Status");
				jobInfoDO.UserId = _ctx.LongValue("ListJobInfo.JobInfoList["+ i +"].UserId");
				jobInfoDO.CreateTime = _ctx.StringValue("ListJobInfo.JobInfoList["+ i +"].CreateTime");
				jobInfoDO.CompleteTime = _ctx.StringValue("ListJobInfo.JobInfoList["+ i +"].CompleteTime");

				listJobInfoResponse_jobInfoList.Add(jobInfoDO);
			}
			listJobInfoResponse.JobInfoList = listJobInfoResponse_jobInfoList;
        
			return listJobInfoResponse;
        }
    }
}
