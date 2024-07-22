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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListActionRecordsResponseUnmarshaller
    {
        public static ListActionRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListActionRecordsResponse listActionRecordsResponse = new ListActionRecordsResponse();

			listActionRecordsResponse.HttpResponse = _ctx.HttpResponse;
			listActionRecordsResponse.RequestId = _ctx.StringValue("ListActionRecords.RequestId");

			List<ListActionRecordsResponse.ListActionRecords_ActionRecord> listActionRecordsResponse_result = new List<ListActionRecordsResponse.ListActionRecords_ActionRecord>();
			for (int i = 0; i < _ctx.Length("ListActionRecords.Result.Length"); i++) {
				ListActionRecordsResponse.ListActionRecords_ActionRecord actionRecord = new ListActionRecordsResponse.ListActionRecords_ActionRecord();
				actionRecord.ActionName = _ctx.StringValue("ListActionRecords.Result["+ i +"].ActionName");
				actionRecord.ActionParams = _ctx.StringValue("ListActionRecords.Result["+ i +"].ActionParams");
				actionRecord.EndTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].EndTime");
				actionRecord.InstanceId = _ctx.StringValue("ListActionRecords.Result["+ i +"].InstanceId");
				actionRecord.Process = _ctx.StringValue("ListActionRecords.Result["+ i +"].Process");
				actionRecord.RecordDiff = _ctx.StringValue("ListActionRecords.Result["+ i +"].RecordDiff");
				actionRecord.RequestId = _ctx.StringValue("ListActionRecords.Result["+ i +"].RequestId");
				actionRecord.StartTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].StartTime");
				actionRecord.StateType = _ctx.StringValue("ListActionRecords.Result["+ i +"].StateType");
				actionRecord.UserId = _ctx.StringValue("ListActionRecords.Result["+ i +"].UserId");
				actionRecord.UserType = _ctx.StringValue("ListActionRecords.Result["+ i +"].UserType");
				actionRecord.OwnerId = _ctx.StringValue("ListActionRecords.Result["+ i +"].OwnerId");
				actionRecord.UserInfo = _ctx.StringValue("ListActionRecords.Result["+ i +"].UserInfo");
				actionRecord.MetaNow = _ctx.StringValue("ListActionRecords.Result["+ i +"].MetaNow");
				actionRecord.MetaOld = _ctx.StringValue("ListActionRecords.Result["+ i +"].MetaOld");

				List<string> actionRecord_actionResultAccessList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListActionRecords.Result["+ i +"].ActionResultAccessList.Length"); j++) {
					actionRecord_actionResultAccessList.Add(_ctx.StringValue("ListActionRecords.Result["+ i +"].ActionResultAccessList["+ j +"]"));
				}
				actionRecord.ActionResultAccessList = actionRecord_actionResultAccessList;

				List<string> actionRecord_recordIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListActionRecords.Result["+ i +"].RecordIds.Length"); j++) {
					actionRecord_recordIds.Add(_ctx.StringValue("ListActionRecords.Result["+ i +"].RecordIds["+ j +"]"));
				}
				actionRecord.RecordIds = actionRecord_recordIds;

				List<ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem> actionRecord_statusInfo = new List<ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem>();
				for (int j = 0; j < _ctx.Length("ListActionRecords.Result["+ i +"].StatusInfo.Length"); j++) {
					ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem statusInfoItem = new ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem();
					statusInfoItem.SubState = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].subState");
					statusInfoItem.NodeCount = _ctx.IntegerValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].nodeCount");
					statusInfoItem.CompleteNodeCount = _ctx.IntegerValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].completeNodeCount");
					statusInfoItem.Exception = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].exception");
					statusInfoItem.LatencyMills = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].latencyMills");
					statusInfoItem.Process = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].process");
					statusInfoItem.StartTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].startTime");
					statusInfoItem.EndTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].endTime");
					statusInfoItem.StateType = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].stateType");

					List<ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem.ListActionRecords_SubStatusInfoItem> statusInfoItem_subStatusInfo = new List<ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem.ListActionRecords_SubStatusInfoItem>();
					for (int k = 0; k < _ctx.Length("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo.Length"); k++) {
						ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem.ListActionRecords_SubStatusInfoItem subStatusInfoItem = new ListActionRecordsResponse.ListActionRecords_ActionRecord.ListActionRecords_StatusInfoItem.ListActionRecords_SubStatusInfoItem();
						subStatusInfoItem.SubState = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].subState");
						subStatusInfoItem.NodeCount = _ctx.IntegerValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].nodeCount");
						subStatusInfoItem.CompleteNodeCount = _ctx.IntegerValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].completeNodeCount");
						subStatusInfoItem.Exception = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].exception");
						subStatusInfoItem.LatencyMills = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].latencyMills");
						subStatusInfoItem.Process = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].process");
						subStatusInfoItem.StartTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].startTime");
						subStatusInfoItem.EndTime = _ctx.LongValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].endTime");
						subStatusInfoItem.StateType = _ctx.StringValue("ListActionRecords.Result["+ i +"].StatusInfo["+ j +"].SubStatusInfo["+ k +"].stateType");

						statusInfoItem_subStatusInfo.Add(subStatusInfoItem);
					}
					statusInfoItem.SubStatusInfo = statusInfoItem_subStatusInfo;

					actionRecord_statusInfo.Add(statusInfoItem);
				}
				actionRecord.StatusInfo = actionRecord_statusInfo;

				listActionRecordsResponse_result.Add(actionRecord);
			}
			listActionRecordsResponse.Result = listActionRecordsResponse_result;
        
			return listActionRecordsResponse;
        }
    }
}
