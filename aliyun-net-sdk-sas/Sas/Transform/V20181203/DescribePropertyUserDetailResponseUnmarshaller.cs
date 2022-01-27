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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribePropertyUserDetailResponseUnmarshaller
    {
        public static DescribePropertyUserDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertyUserDetailResponse describePropertyUserDetailResponse = new DescribePropertyUserDetailResponse();

			describePropertyUserDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertyUserDetailResponse.RequestId = _ctx.StringValue("DescribePropertyUserDetail.RequestId");

			DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PageInfo pageInfo = new DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertyUserDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertyUserDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertyUserDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertyUserDetail.PageInfo.CurrentPage");
			describePropertyUserDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser> describePropertyUserDetailResponse_propertys = new List<DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser>();
			for (int i = 0; i < _ctx.Length("DescribePropertyUserDetail.Propertys.Length"); i++) {
				DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser propertyUser = new DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser();
				propertyUser.LastLoginTime = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].LastLoginTime");
				propertyUser.LastLoginTimestamp = _ctx.LongValue("DescribePropertyUserDetail.Propertys["+ i +"].LastLoginTimestamp");
				propertyUser.IsRoot = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].IsRoot");
				propertyUser.InstanceName = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InstanceName");
				propertyUser.AccountsExpirationDate = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].AccountsExpirationDate");
				propertyUser.PasswordExpirationDate = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].PasswordExpirationDate");
				propertyUser.Ip = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Ip");
				propertyUser.Create = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Create");
				propertyUser.CreateTimestamp = _ctx.LongValue("DescribePropertyUserDetail.Propertys["+ i +"].CreateTimestamp");
				propertyUser.User = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].User");
				propertyUser.Uuid = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Uuid");
				propertyUser.LastLoginIp = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].LastLoginIp");
				propertyUser.InstanceId = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InstanceId");
				propertyUser.IntranetIp = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].IntranetIp");
				propertyUser.InternetIp = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InternetIp");
				propertyUser.Status = _ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Status");

				List<string> propertyUser_groupNames = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePropertyUserDetail.Propertys["+ i +"].GroupNames.Length"); j++) {
					propertyUser_groupNames.Add(_ctx.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].GroupNames["+ j +"]"));
				}
				propertyUser.GroupNames = propertyUser_groupNames;

				describePropertyUserDetailResponse_propertys.Add(propertyUser);
			}
			describePropertyUserDetailResponse.Propertys = describePropertyUserDetailResponse_propertys;
        
			return describePropertyUserDetailResponse;
        }
    }
}
