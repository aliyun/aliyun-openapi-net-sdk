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
        public static DescribePropertyUserDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePropertyUserDetailResponse describePropertyUserDetailResponse = new DescribePropertyUserDetailResponse();

			describePropertyUserDetailResponse.HttpResponse = context.HttpResponse;
			describePropertyUserDetailResponse.RequestId = context.StringValue("DescribePropertyUserDetail.RequestId");

			DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PageInfo pageInfo = new DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribePropertyUserDetail.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribePropertyUserDetail.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribePropertyUserDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribePropertyUserDetail.PageInfo.CurrentPage");
			describePropertyUserDetailResponse.PageInfo = pageInfo;

			List<DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser> describePropertyUserDetailResponse_propertys = new List<DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser>();
			for (int i = 0; i < context.Length("DescribePropertyUserDetail.Propertys.Length"); i++) {
				DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser propertyUser = new DescribePropertyUserDetailResponse.DescribePropertyUserDetail_PropertyUser();
				propertyUser.LastLoginTime = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].LastLoginTime");
				propertyUser.IsRoot = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].IsRoot");
				propertyUser.InstanceName = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InstanceName");
				propertyUser.AccountsExpirationDate = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].AccountsExpirationDate");
				propertyUser.PasswordExpirationDate = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].PasswordExpirationDate");
				propertyUser.Ip = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Ip");
				propertyUser.Create = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Create");
				propertyUser.CreateTimestamp = context.LongValue("DescribePropertyUserDetail.Propertys["+ i +"].CreateTimestamp");
				propertyUser.User = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].User");
				propertyUser.Uuid = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Uuid");
				propertyUser.LastLoginIp = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].LastLoginIp");
				propertyUser.InstanceId = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InstanceId");
				propertyUser.IntranetIp = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].IntranetIp");
				propertyUser.InternetIp = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].InternetIp");
				propertyUser.Status = context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].Status");

				List<string> propertyUser_groupNames = new List<string>();
				for (int j = 0; j < context.Length("DescribePropertyUserDetail.Propertys["+ i +"].GroupNames.Length"); j++) {
					propertyUser_groupNames.Add(context.StringValue("DescribePropertyUserDetail.Propertys["+ i +"].GroupNames["+ j +"]"));
				}
				propertyUser.GroupNames = propertyUser_groupNames;

				describePropertyUserDetailResponse_propertys.Add(propertyUser);
			}
			describePropertyUserDetailResponse.Propertys = describePropertyUserDetailResponse_propertys;
        
			return describePropertyUserDetailResponse;
        }
    }
}
