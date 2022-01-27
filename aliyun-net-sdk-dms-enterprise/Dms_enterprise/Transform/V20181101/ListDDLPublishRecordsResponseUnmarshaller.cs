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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListDDLPublishRecordsResponseUnmarshaller
    {
        public static ListDDLPublishRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDDLPublishRecordsResponse listDDLPublishRecordsResponse = new ListDDLPublishRecordsResponse();

			listDDLPublishRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listDDLPublishRecordsResponse.RequestId = _ctx.StringValue("ListDDLPublishRecords.RequestId");
			listDDLPublishRecordsResponse.Success = _ctx.BooleanValue("ListDDLPublishRecords.Success");
			listDDLPublishRecordsResponse.ErrorMessage = _ctx.StringValue("ListDDLPublishRecords.ErrorMessage");
			listDDLPublishRecordsResponse.ErrorCode = _ctx.StringValue("ListDDLPublishRecords.ErrorCode");

			List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord> listDDLPublishRecordsResponse_dDLPublishRecordList = new List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord>();
			for (int i = 0; i < _ctx.Length("ListDDLPublishRecords.DDLPublishRecordList.Length"); i++) {
				ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord dDLPublishRecord = new ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord();
				dDLPublishRecord.AuditStatus = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].AuditStatus");
				dDLPublishRecord.AuditExpireTime = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].AuditExpireTime");
				dDLPublishRecord.CreatorId = _ctx.LongValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].CreatorId");
				dDLPublishRecord.Finality = _ctx.BooleanValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].Finality");
				dDLPublishRecord.FinalityReason = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].FinalityReason");
				dDLPublishRecord.PublishStatus = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishStatus");
				dDLPublishRecord.RiskLevel = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].RiskLevel");
				dDLPublishRecord.StatusDesc = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].StatusDesc");
				dDLPublishRecord.WorkflowInstanceId = _ctx.LongValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].WorkflowInstanceId");

				List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo> dDLPublishRecord_publishTaskInfoList = new List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo>();
				for (int j = 0; j < _ctx.Length("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList.Length"); j++) {
					ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo publishTaskInfo = new ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo();
					publishTaskInfo.DbId = _ctx.LongValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].DbId");
					publishTaskInfo.Logic = _ctx.BooleanValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].Logic");
					publishTaskInfo.PlanTime = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PlanTime");
					publishTaskInfo.PublishStrategy = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishStrategy");
					publishTaskInfo.StatusDesc = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].StatusDesc");
					publishTaskInfo.TaskJobStatus = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].TaskJobStatus");

					List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo.ListDDLPublishRecords_PublishJob> publishTaskInfo_publishJobList = new List<ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo.ListDDLPublishRecords_PublishJob>();
					for (int k = 0; k < _ctx.Length("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList.Length"); k++) {
						ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo.ListDDLPublishRecords_PublishJob publishJob = new ListDDLPublishRecordsResponse.ListDDLPublishRecords_DDLPublishRecord.ListDDLPublishRecords_PublishTaskInfo.ListDDLPublishRecords_PublishJob();
						publishJob.ExecuteCount = _ctx.LongValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].ExecuteCount");
						publishJob.Scripts = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].Scripts");
						publishJob.TableName = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].TableName");
						publishJob.StatusDesc = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].StatusDesc");
						publishJob.TaskJobStatus = _ctx.StringValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].TaskJobStatus");
						publishJob.DBTaskGroupId = _ctx.LongValue("ListDDLPublishRecords.DDLPublishRecordList["+ i +"].PublishTaskInfoList["+ j +"].PublishJobList["+ k +"].DBTaskGroupId");

						publishTaskInfo_publishJobList.Add(publishJob);
					}
					publishTaskInfo.PublishJobList = publishTaskInfo_publishJobList;

					dDLPublishRecord_publishTaskInfoList.Add(publishTaskInfo);
				}
				dDLPublishRecord.PublishTaskInfoList = dDLPublishRecord_publishTaskInfoList;

				listDDLPublishRecordsResponse_dDLPublishRecordList.Add(dDLPublishRecord);
			}
			listDDLPublishRecordsResponse.DDLPublishRecordList = listDDLPublishRecordsResponse_dDLPublishRecordList;
        
			return listDDLPublishRecordsResponse;
        }
    }
}
