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
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class ExploreHiTSDBInstanceDeletionJobListResponseUnmarshaller
    {
        public static ExploreHiTSDBInstanceDeletionJobListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExploreHiTSDBInstanceDeletionJobListResponse exploreHiTSDBInstanceDeletionJobListResponse = new ExploreHiTSDBInstanceDeletionJobListResponse();

			exploreHiTSDBInstanceDeletionJobListResponse.HttpResponse = _ctx.HttpResponse;
			exploreHiTSDBInstanceDeletionJobListResponse.RequestId = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.RequestId");
			exploreHiTSDBInstanceDeletionJobListResponse.PageNumber = _ctx.IntegerValue("ExploreHiTSDBInstanceDeletionJobList.PageNumber");
			exploreHiTSDBInstanceDeletionJobListResponse.PageSize = _ctx.IntegerValue("ExploreHiTSDBInstanceDeletionJobList.PageSize");
			exploreHiTSDBInstanceDeletionJobListResponse.Total = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.Total");

			List<ExploreHiTSDBInstanceDeletionJobListResponse.ExploreHiTSDBInstanceDeletionJobList_JobItem> exploreHiTSDBInstanceDeletionJobListResponse_jobList = new List<ExploreHiTSDBInstanceDeletionJobListResponse.ExploreHiTSDBInstanceDeletionJobList_JobItem>();
			for (int i = 0; i < _ctx.Length("ExploreHiTSDBInstanceDeletionJobList.JobList.Length"); i++) {
				ExploreHiTSDBInstanceDeletionJobListResponse.ExploreHiTSDBInstanceDeletionJobList_JobItem jobItem = new ExploreHiTSDBInstanceDeletionJobListResponse.ExploreHiTSDBInstanceDeletionJobList_JobItem();
				jobItem.Id = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Id");
				jobItem.InstanceId = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].InstanceId");
				jobItem.Ip = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Ip");
				jobItem.Port = _ctx.IntegerValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Port");
				jobItem.Metric = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Metric");
				jobItem.Tags = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Tags");
				jobItem.StartTime = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].StartTime");
				jobItem.EndTime = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].EndTime");
				jobItem.Status = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].Status");
				jobItem.JobTyp = _ctx.StringValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].JobTyp");
				jobItem.JobCreationTime = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].JobCreationTime");
				jobItem.JobStartTime = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].JobStartTime");
				jobItem.JobEndTime = _ctx.LongValue("ExploreHiTSDBInstanceDeletionJobList.JobList["+ i +"].JobEndTime");

				exploreHiTSDBInstanceDeletionJobListResponse_jobList.Add(jobItem);
			}
			exploreHiTSDBInstanceDeletionJobListResponse.JobList = exploreHiTSDBInstanceDeletionJobListResponse_jobList;
        
			return exploreHiTSDBInstanceDeletionJobListResponse;
        }
    }
}
