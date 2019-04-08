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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeBackupPlanListResponseUnmarshaller
    {
        public static DescribeBackupPlanListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupPlanListResponse describeBackupPlanListResponse = new DescribeBackupPlanListResponse();

			describeBackupPlanListResponse.HttpResponse = context.HttpResponse;
			describeBackupPlanListResponse.Success = context.BooleanValue("DescribeBackupPlanList.Success");
			describeBackupPlanListResponse.ErrCode = context.StringValue("DescribeBackupPlanList.ErrCode");
			describeBackupPlanListResponse.ErrMessage = context.StringValue("DescribeBackupPlanList.ErrMessage");
			describeBackupPlanListResponse.HttpStatusCode = context.IntegerValue("DescribeBackupPlanList.HttpStatusCode");
			describeBackupPlanListResponse.RequestId = context.StringValue("DescribeBackupPlanList.RequestId");
			describeBackupPlanListResponse.TotalPages = context.IntegerValue("DescribeBackupPlanList.TotalPages");
			describeBackupPlanListResponse.PageSize = context.IntegerValue("DescribeBackupPlanList.PageSize");
			describeBackupPlanListResponse.PageNum = context.IntegerValue("DescribeBackupPlanList.PageNum");
			describeBackupPlanListResponse.TotalElements = context.IntegerValue("DescribeBackupPlanList.TotalElements");

			List<string> describeBackupPlanListResponse_items = new List<string>();
			for (int i = 0; i < context.Length("DescribeBackupPlanList.Items.Length"); i++) {
				describeBackupPlanListResponse_items.Add(context.StringValue("DescribeBackupPlanList.Items["+ i +"]"));
			}
			describeBackupPlanListResponse.Items = describeBackupPlanListResponse_items;
        
			return describeBackupPlanListResponse;
        }
    }
}
