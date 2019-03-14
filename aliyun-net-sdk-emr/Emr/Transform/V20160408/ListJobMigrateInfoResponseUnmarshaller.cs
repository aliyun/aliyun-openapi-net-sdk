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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListJobMigrateInfoResponseUnmarshaller
    {
        public static ListJobMigrateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListJobMigrateInfoResponse listJobMigrateInfoResponse = new ListJobMigrateInfoResponse();

			listJobMigrateInfoResponse.HttpResponse = context.HttpResponse;
			listJobMigrateInfoResponse.Total = context.LongValue("ListJobMigrateInfo.Total");

			List<ListJobMigrateInfoResponse.ListJobMigrateInfo_JobMigrateInfo> listJobMigrateInfoResponse_jobMigrateInfoList = new List<ListJobMigrateInfoResponse.ListJobMigrateInfo_JobMigrateInfo>();
			for (int i = 0; i < context.Length("ListJobMigrateInfo.JobMigrateInfoList.Length"); i++) {
				ListJobMigrateInfoResponse.ListJobMigrateInfo_JobMigrateInfo jobMigrateInfo = new ListJobMigrateInfoResponse.ListJobMigrateInfo_JobMigrateInfo();
				jobMigrateInfo.Id = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].Id");
				jobMigrateInfo.Name = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].Name");
				jobMigrateInfo.Type = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].Type");
				jobMigrateInfo.MaxRetry = context.IntegerValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].MaxRetry");
				jobMigrateInfo.FailedAction = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].FailedAction");
				jobMigrateInfo._Params = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].Params");
				jobMigrateInfo.NewId = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].NewId");
				jobMigrateInfo.PremigratedDate = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].PremigratedDate");
				jobMigrateInfo.MigratedDate = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].MigratedDate");
				jobMigrateInfo.CreateTime = context.StringValue("ListJobMigrateInfo.JobMigrateInfoList["+ i +"].CreateTime");

				listJobMigrateInfoResponse_jobMigrateInfoList.Add(jobMigrateInfo);
			}
			listJobMigrateInfoResponse.JobMigrateInfoList = listJobMigrateInfoResponse_jobMigrateInfoList;
        
			return listJobMigrateInfoResponse;
        }
    }
}
