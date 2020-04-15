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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribePrivilegesResponseUnmarshaller
    {
        public static DescribePrivilegesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePrivilegesResponse describePrivilegesResponse = new DescribePrivilegesResponse();

			describePrivilegesResponse.HttpResponse = context.HttpResponse;
			describePrivilegesResponse.RequestId = context.StringValue("DescribePrivileges.RequestId");
			describePrivilegesResponse.PageSize = context.IntegerValue("DescribePrivileges.PageSize");
			describePrivilegesResponse.CurrentPage = context.IntegerValue("DescribePrivileges.CurrentPage");
			describePrivilegesResponse.TotalCount = context.IntegerValue("DescribePrivileges.TotalCount");

			List<DescribePrivilegesResponse.DescribePrivileges_Privilege> describePrivilegesResponse_items = new List<DescribePrivilegesResponse.DescribePrivileges_Privilege>();
			for (int i = 0; i < context.Length("DescribePrivileges.Items.Length"); i++) {
				DescribePrivilegesResponse.DescribePrivileges_Privilege privilege = new DescribePrivilegesResponse.DescribePrivileges_Privilege();
				privilege.Id = context.LongValue("DescribePrivileges.Items["+ i +"].Id");
				privilege.AccountId = context.LongValue("DescribePrivileges.Items["+ i +"].AccountId");
				privilege.AccountType = context.IntegerValue("DescribePrivileges.Items["+ i +"].AccountType");
				privilege.UseAccountId = context.LongValue("DescribePrivileges.Items["+ i +"].UseAccountId");
				privilege.UseAccountType = context.IntegerValue("DescribePrivileges.Items["+ i +"].UseAccountType");
				privilege.ProductName = context.StringValue("DescribePrivileges.Items["+ i +"].ProductName");
				privilege.ProductCode = context.StringValue("DescribePrivileges.Items["+ i +"].productCode");
				privilege.DataType = context.StringValue("DescribePrivileges.Items["+ i +"].DataType");
				privilege.DataTypeId = context.StringValue("DescribePrivileges.Items["+ i +"].DataTypeId");
				privilege.DataTypeName = context.StringValue("DescribePrivileges.Items["+ i +"].DataTypeName");
				privilege.DataInstance = context.StringValue("DescribePrivileges.Items["+ i +"].DataInstance");
				privilege.DataTable = context.StringValue("DescribePrivileges.Items["+ i +"].DataTable");
				privilege.DataColumn = context.StringValue("DescribePrivileges.Items["+ i +"].DataColumn");
				privilege.DataPackage = context.StringValue("DescribePrivileges.Items["+ i +"].DataPackage");
				privilege.ResourceName = context.StringValue("DescribePrivileges.Items["+ i +"].ResourceName");
				privilege.ResourcePath = context.StringValue("DescribePrivileges.Items["+ i +"].ResourcePath");
				privilege.Operation = context.StringValue("DescribePrivileges.Items["+ i +"].Operation");
				privilege.PolicyCondition = context.StringValue("DescribePrivileges.Items["+ i +"].PolicyCondition");
				privilege.Sensitive = context.StringValue("DescribePrivileges.Items["+ i +"].Sensitive");

				describePrivilegesResponse_items.Add(privilege);
			}
			describePrivilegesResponse.Items = describePrivilegesResponse_items;
        
			return describePrivilegesResponse;
        }
    }
}
