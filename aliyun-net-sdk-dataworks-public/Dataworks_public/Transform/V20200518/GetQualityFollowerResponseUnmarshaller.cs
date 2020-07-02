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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetQualityFollowerResponseUnmarshaller
    {
        public static GetQualityFollowerResponse Unmarshall(UnmarshallerContext context)
        {
			GetQualityFollowerResponse getQualityFollowerResponse = new GetQualityFollowerResponse();

			getQualityFollowerResponse.HttpResponse = context.HttpResponse;
			getQualityFollowerResponse.ErrorCode = context.StringValue("GetQualityFollower.ErrorCode");
			getQualityFollowerResponse.Success = context.BooleanValue("GetQualityFollower.Success");
			getQualityFollowerResponse.ErrorMessage = context.StringValue("GetQualityFollower.ErrorMessage");
			getQualityFollowerResponse.HttpStatusCode = context.IntegerValue("GetQualityFollower.HttpStatusCode");
			getQualityFollowerResponse.RequestId = context.StringValue("GetQualityFollower.RequestId");

			List<GetQualityFollowerResponse.GetQualityFollower_Follower> getQualityFollowerResponse_data = new List<GetQualityFollowerResponse.GetQualityFollower_Follower>();
			for (int i = 0; i < context.Length("GetQualityFollower.Data.Length"); i++) {
				GetQualityFollowerResponse.GetQualityFollower_Follower follower = new GetQualityFollowerResponse.GetQualityFollower_Follower();
				follower.ProjectName = context.StringValue("GetQualityFollower.Data["+ i +"].ProjectName");
				follower.TableName = context.StringValue("GetQualityFollower.Data["+ i +"].TableName");
				follower.Id = context.LongValue("GetQualityFollower.Data["+ i +"].Id");
				follower.EntityId = context.StringValue("GetQualityFollower.Data["+ i +"].EntityId");
				follower.Follower = context.StringValue("GetQualityFollower.Data["+ i +"].Follower");
				follower.AlarmMode = context.IntegerValue("GetQualityFollower.Data["+ i +"].AlarmMode");

				getQualityFollowerResponse_data.Add(follower);
			}
			getQualityFollowerResponse.Data = getQualityFollowerResponse_data;
        
			return getQualityFollowerResponse;
        }
    }
}
