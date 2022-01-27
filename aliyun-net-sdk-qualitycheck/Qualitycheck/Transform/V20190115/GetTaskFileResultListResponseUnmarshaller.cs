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
    public class GetTaskFileResultListResponseUnmarshaller
    {
        public static GetTaskFileResultListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskFileResultListResponse getTaskFileResultListResponse = new GetTaskFileResultListResponse();

			getTaskFileResultListResponse.HttpResponse = _ctx.HttpResponse;
			getTaskFileResultListResponse.DataSize = _ctx.IntegerValue("GetTaskFileResultList.DataSize");
			getTaskFileResultListResponse.RequestId = _ctx.StringValue("GetTaskFileResultList.RequestId");
			getTaskFileResultListResponse.Success = _ctx.BooleanValue("GetTaskFileResultList.Success");
			getTaskFileResultListResponse.Code = _ctx.StringValue("GetTaskFileResultList.Code");
			getTaskFileResultListResponse.Message = _ctx.StringValue("GetTaskFileResultList.Message");
			getTaskFileResultListResponse.PageSize = _ctx.IntegerValue("GetTaskFileResultList.PageSize");
			getTaskFileResultListResponse.TotalCount = _ctx.IntegerValue("GetTaskFileResultList.TotalCount");

			List<GetTaskFileResultListResponse.GetTaskFileResultList_TaskResultReviewInfo> getTaskFileResultListResponse_data = new List<GetTaskFileResultListResponse.GetTaskFileResultList_TaskResultReviewInfo>();
			for (int i = 0; i < _ctx.Length("GetTaskFileResultList.Data.Length"); i++) {
				GetTaskFileResultListResponse.GetTaskFileResultList_TaskResultReviewInfo taskResultReviewInfo = new GetTaskFileResultListResponse.GetTaskFileResultList_TaskResultReviewInfo();
				taskResultReviewInfo.Status = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].Status");
				taskResultReviewInfo.DataType = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].DataType");
				taskResultReviewInfo.HitNumber = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].HitNumber");
				taskResultReviewInfo.HitRule = _ctx.BooleanValue("GetTaskFileResultList.Data["+ i +"].HitRule");
				taskResultReviewInfo.NextVid = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].NextVid");
				taskResultReviewInfo.PreVid = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].PreVid");
				taskResultReviewInfo.ReviewAccuracyRate = _ctx.FloatValue("GetTaskFileResultList.Data["+ i +"].ReviewAccuracyRate");
				taskResultReviewInfo.RealViolationNumber = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].RealViolationNumber");
				taskResultReviewInfo.IsHitRule = _ctx.BooleanValue("GetTaskFileResultList.Data["+ i +"].IsHitRule");
				taskResultReviewInfo.FileName = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].FileName");
				taskResultReviewInfo.TotalScore = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].TotalScore");
				taskResultReviewInfo.CheckNumber = _ctx.IntegerValue("GetTaskFileResultList.Data["+ i +"].CheckNumber");
				taskResultReviewInfo.FileMergeName = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].FileMergeName");
				taskResultReviewInfo.BucketName = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].BucketName");
				taskResultReviewInfo.HandTaskFile = _ctx.BooleanValue("GetTaskFileResultList.Data["+ i +"].HandTaskFile");
				taskResultReviewInfo.TaskId = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].TaskId");
				taskResultReviewInfo.Vid = _ctx.StringValue("GetTaskFileResultList.Data["+ i +"].Vid");

				List<string> taskResultReviewInfo_hitRuleSet = new List<string>();
				for (int j = 0; j < _ctx.Length("GetTaskFileResultList.Data["+ i +"].HitRuleSet.Length"); j++) {
					taskResultReviewInfo_hitRuleSet.Add(_ctx.StringValue("GetTaskFileResultList.Data["+ i +"].HitRuleSet["+ j +"]"));
				}
				taskResultReviewInfo.HitRuleSet = taskResultReviewInfo_hitRuleSet;

				getTaskFileResultListResponse_data.Add(taskResultReviewInfo);
			}
			getTaskFileResultListResponse.Data = getTaskFileResultListResponse_data;
        
			return getTaskFileResultListResponse;
        }
    }
}
