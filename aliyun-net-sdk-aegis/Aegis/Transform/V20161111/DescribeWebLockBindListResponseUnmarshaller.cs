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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWebLockBindListResponseUnmarshaller
    {
        public static DescribeWebLockBindListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebLockBindListResponse describeWebLockBindListResponse = new DescribeWebLockBindListResponse();

			describeWebLockBindListResponse.HttpResponse = context.HttpResponse;
			describeWebLockBindListResponse.RequestId = context.StringValue("DescribeWebLockBindList.RequestId");
			describeWebLockBindListResponse.PageSize = context.IntegerValue("DescribeWebLockBindList.PageSize");
			describeWebLockBindListResponse.CurrentPage = context.IntegerValue("DescribeWebLockBindList.CurrentPage");
			describeWebLockBindListResponse.TotalCount = context.IntegerValue("DescribeWebLockBindList.TotalCount");

			List<DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind> describeWebLockBindListResponse_bindList = new List<DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind>();
			for (int i = 0; i < context.Length("DescribeWebLockBindList.BindList.Length"); i++) {
				DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind bind = new DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind();
				bind.Uuid = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].Uuid");
				bind.InstanceName = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].InstanceName");
				bind.InternetIp = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].InternetIp");
				bind.IntranetIp = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].IntranetIp");
				bind.Os = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].Os");
				bind.DirCount = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].DirCount");
				bind.ServiceStatus = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceStatus");
				bind.ServiceCode = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceCode");
				bind.ServiceDetail = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceDetail");
				bind.Status = context.StringValue("DescribeWebLockBindList.BindList["+ i +"].Status");

				describeWebLockBindListResponse_bindList.Add(bind);
			}
			describeWebLockBindListResponse.BindList = describeWebLockBindListResponse_bindList;
        
			return describeWebLockBindListResponse;
        }
    }
}
