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
    public class DescribeWebLockBindListResponseUnmarshaller
    {
        public static DescribeWebLockBindListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeWebLockBindListResponse describeWebLockBindListResponse = new DescribeWebLockBindListResponse();

			describeWebLockBindListResponse.HttpResponse = _ctx.HttpResponse;
			describeWebLockBindListResponse.RequestId = _ctx.StringValue("DescribeWebLockBindList.RequestId");
			describeWebLockBindListResponse.PageSize = _ctx.IntegerValue("DescribeWebLockBindList.PageSize");
			describeWebLockBindListResponse.CurrentPage = _ctx.IntegerValue("DescribeWebLockBindList.CurrentPage");
			describeWebLockBindListResponse.TotalCount = _ctx.IntegerValue("DescribeWebLockBindList.TotalCount");

			List<DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind> describeWebLockBindListResponse_bindList = new List<DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind>();
			for (int i = 0; i < _ctx.Length("DescribeWebLockBindList.BindList.Length"); i++) {
				DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind bind = new DescribeWebLockBindListResponse.DescribeWebLockBindList_Bind();
				bind.Uuid = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].Uuid");
				bind.InstanceName = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].InstanceName");
				bind.InternetIp = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].InternetIp");
				bind.IntranetIp = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].IntranetIp");
				bind.Os = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].Os");
				bind.DirCount = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].DirCount");
				bind.ServiceStatus = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceStatus");
				bind.ServiceCode = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceCode");
				bind.ServiceDetail = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].ServiceDetail");
				bind.Status = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].Status");
				bind.Percent = _ctx.IntegerValue("DescribeWebLockBindList.BindList["+ i +"].Percent");
				bind.AuditCount = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].AuditCount");
				bind.BlockCount = _ctx.StringValue("DescribeWebLockBindList.BindList["+ i +"].BlockCount");

				describeWebLockBindListResponse_bindList.Add(bind);
			}
			describeWebLockBindListResponse.BindList = describeWebLockBindListResponse_bindList;
        
			return describeWebLockBindListResponse;
        }
    }
}
