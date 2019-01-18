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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class QueryAddUserInfoResponseUnmarshaller
    {
        public static QueryAddUserInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAddUserInfoResponse queryAddUserInfoResponse = new QueryAddUserInfoResponse();

			queryAddUserInfoResponse.HttpResponse = context.HttpResponse;
			queryAddUserInfoResponse.RequestId = context.StringValue("QueryAddUserInfo.RequestId");
			queryAddUserInfoResponse.Code = context.IntegerValue("QueryAddUserInfo.Code");
			queryAddUserInfoResponse.Message = context.StringValue("QueryAddUserInfo.Message");
			queryAddUserInfoResponse.Success = context.BooleanValue("QueryAddUserInfo.Success");

			QueryAddUserInfoResponse.QueryAddUserInfo_Data data = new QueryAddUserInfoResponse.QueryAddUserInfo_Data();

			List<QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_CurrentFaceInfosItem> data_currentFaceInfos = new List<QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_CurrentFaceInfosItem>();
			for (int i = 0; i < context.Length("QueryAddUserInfo.Data.CurrentFaceInfos.Length"); i++) {
				QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_CurrentFaceInfosItem currentFaceInfosItem = new QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_CurrentFaceInfosItem();
				currentFaceInfosItem.UserId = context.StringValue("QueryAddUserInfo.Data.CurrentFaceInfos["+ i +"].UserId");
				currentFaceInfosItem.ClientTag = context.StringValue("QueryAddUserInfo.Data.CurrentFaceInfos["+ i +"].ClientTag");
				currentFaceInfosItem.Index = context.IntegerValue("QueryAddUserInfo.Data.CurrentFaceInfos["+ i +"].Index");

				data_currentFaceInfos.Add(currentFaceInfosItem);
			}
			data.CurrentFaceInfos = data_currentFaceInfos;

			List<QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_FailedFaceInfosItem> data_failedFaceInfos = new List<QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_FailedFaceInfosItem>();
			for (int i = 0; i < context.Length("QueryAddUserInfo.Data.FailedFaceInfos.Length"); i++) {
				QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_FailedFaceInfosItem failedFaceInfosItem = new QueryAddUserInfoResponse.QueryAddUserInfo_Data.QueryAddUserInfo_FailedFaceInfosItem();
				failedFaceInfosItem.UserId = context.StringValue("QueryAddUserInfo.Data.FailedFaceInfos["+ i +"].UserId");
				failedFaceInfosItem.ClientTag = context.StringValue("QueryAddUserInfo.Data.FailedFaceInfos["+ i +"].ClientTag");
				failedFaceInfosItem.Index = context.IntegerValue("QueryAddUserInfo.Data.FailedFaceInfos["+ i +"].Index");

				data_failedFaceInfos.Add(failedFaceInfosItem);
			}
			data.FailedFaceInfos = data_failedFaceInfos;
			queryAddUserInfoResponse.Data = data;
        
			return queryAddUserInfoResponse;
        }
    }
}