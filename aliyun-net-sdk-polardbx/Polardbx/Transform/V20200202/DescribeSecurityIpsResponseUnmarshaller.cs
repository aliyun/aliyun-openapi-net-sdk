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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeSecurityIpsResponseUnmarshaller
    {
        public static DescribeSecurityIpsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityIpsResponse describeSecurityIpsResponse = new DescribeSecurityIpsResponse();

			describeSecurityIpsResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityIpsResponse.RequestId = _ctx.StringValue("DescribeSecurityIps.RequestId");
			describeSecurityIpsResponse.Success = _ctx.BooleanValue("DescribeSecurityIps.Success");
			describeSecurityIpsResponse.Message = _ctx.StringValue("DescribeSecurityIps.Message");

			DescribeSecurityIpsResponse.DescribeSecurityIps_Data data = new DescribeSecurityIpsResponse.DescribeSecurityIps_Data();
			data.DBInstanceName = _ctx.StringValue("DescribeSecurityIps.Data.DBInstanceName");

			List<DescribeSecurityIpsResponse.DescribeSecurityIps_Data.DescribeSecurityIps_GroupItem> data_groupItems = new List<DescribeSecurityIpsResponse.DescribeSecurityIps_Data.DescribeSecurityIps_GroupItem>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityIps.Data.GroupItems.Length"); i++) {
				DescribeSecurityIpsResponse.DescribeSecurityIps_Data.DescribeSecurityIps_GroupItem groupItem = new DescribeSecurityIpsResponse.DescribeSecurityIps_Data.DescribeSecurityIps_GroupItem();
				groupItem.GroupName = _ctx.StringValue("DescribeSecurityIps.Data.GroupItems["+ i +"].GroupName");
				groupItem.SecurityIPList = _ctx.StringValue("DescribeSecurityIps.Data.GroupItems["+ i +"].SecurityIPList");

				data_groupItems.Add(groupItem);
			}
			data.GroupItems = data_groupItems;
			describeSecurityIpsResponse.Data = data;
        
			return describeSecurityIpsResponse;
        }
    }
}
