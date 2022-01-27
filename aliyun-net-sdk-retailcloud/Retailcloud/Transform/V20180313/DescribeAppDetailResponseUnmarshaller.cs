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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeAppDetailResponseUnmarshaller
    {
        public static DescribeAppDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppDetailResponse describeAppDetailResponse = new DescribeAppDetailResponse();

			describeAppDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAppDetailResponse.Code = _ctx.LongValue("DescribeAppDetail.Code");
			describeAppDetailResponse.RequestId = _ctx.StringValue("DescribeAppDetail.RequestId");
			describeAppDetailResponse.ErrMessage = _ctx.StringValue("DescribeAppDetail.ErrMessage");

			DescribeAppDetailResponse.DescribeAppDetail_Result result = new DescribeAppDetailResponse.DescribeAppDetail_Result();
			result.ServiceType = _ctx.StringValue("DescribeAppDetail.Result.ServiceType");
			result.BizTitle = _ctx.StringValue("DescribeAppDetail.Result.BizTitle");
			result.BizName = _ctx.StringValue("DescribeAppDetail.Result.BizName");
			result.AppId = _ctx.LongValue("DescribeAppDetail.Result.AppId");
			result.Language = _ctx.StringValue("DescribeAppDetail.Result.Language");
			result.Title = _ctx.StringValue("DescribeAppDetail.Result.Title");
			result.OperatingSystem = _ctx.StringValue("DescribeAppDetail.Result.OperatingSystem");
			result.DeployType = _ctx.StringValue("DescribeAppDetail.Result.DeployType");
			result.Description = _ctx.StringValue("DescribeAppDetail.Result.Description");
			result.AppStateType = _ctx.StringValue("DescribeAppDetail.Result.AppStateType");

			List<DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_UserRole> result_userRoles = new List<DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_UserRole>();
			for (int i = 0; i < _ctx.Length("DescribeAppDetail.Result.UserRoles.Length"); i++) {
				DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_UserRole userRole = new DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_UserRole();
				userRole.UserId = _ctx.StringValue("DescribeAppDetail.Result.UserRoles["+ i +"].UserId");
				userRole.UserType = _ctx.StringValue("DescribeAppDetail.Result.UserRoles["+ i +"].UserType");
				userRole.RealName = _ctx.StringValue("DescribeAppDetail.Result.UserRoles["+ i +"].RealName");
				userRole.RoleName = _ctx.StringValue("DescribeAppDetail.Result.UserRoles["+ i +"].RoleName");

				result_userRoles.Add(userRole);
			}
			result.UserRoles = result_userRoles;

			List<DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_MiddleWareInfo> result_middleWareInfoList = new List<DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_MiddleWareInfo>();
			for (int i = 0; i < _ctx.Length("DescribeAppDetail.Result.MiddleWareInfoList.Length"); i++) {
				DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_MiddleWareInfo middleWareInfo = new DescribeAppDetailResponse.DescribeAppDetail_Result.DescribeAppDetail_MiddleWareInfo();
				middleWareInfo.AppId = _ctx.LongValue("DescribeAppDetail.Result.MiddleWareInfoList["+ i +"].AppId");
				middleWareInfo.Code = _ctx.IntegerValue("DescribeAppDetail.Result.MiddleWareInfoList["+ i +"].Code");
				middleWareInfo.Name = _ctx.StringValue("DescribeAppDetail.Result.MiddleWareInfoList["+ i +"].Name");

				result_middleWareInfoList.Add(middleWareInfo);
			}
			result.MiddleWareInfoList = result_middleWareInfoList;
			describeAppDetailResponse.Result = result;
        
			return describeAppDetailResponse;
        }
    }
}
