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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeModifyPGHbaConfigLogResponseUnmarshaller
    {
        public static DescribeModifyPGHbaConfigLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeModifyPGHbaConfigLogResponse describeModifyPGHbaConfigLogResponse = new DescribeModifyPGHbaConfigLogResponse();

			describeModifyPGHbaConfigLogResponse.HttpResponse = _ctx.HttpResponse;
			describeModifyPGHbaConfigLogResponse.DBInstanceId = _ctx.StringValue("DescribeModifyPGHbaConfigLog.DBInstanceId");
			describeModifyPGHbaConfigLogResponse.RequestId = _ctx.StringValue("DescribeModifyPGHbaConfigLog.RequestId");
			describeModifyPGHbaConfigLogResponse.LogItemCount = _ctx.IntegerValue("DescribeModifyPGHbaConfigLog.LogItemCount");

			List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem> describeModifyPGHbaConfigLogResponse_hbaLogItems = new List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem>();
			for (int i = 0; i < _ctx.Length("DescribeModifyPGHbaConfigLog.HbaLogItems.Length"); i++) {
				DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem hbaLogItem = new DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem();
				hbaLogItem.ModifyStatus = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].ModifyStatus");
				hbaLogItem.StatusReason = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].StatusReason");
				hbaLogItem.ModifyTime = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].ModifyTime");

				List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem> hbaLogItem_beforeHbaItems = new List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem>();
				for (int j = 0; j < _ctx.Length("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems.Length"); j++) {
					DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem hbaItem = new DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem();
					hbaItem.Type = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Type");
					hbaItem.Mask = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Mask");
					hbaItem.Database = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Database");
					hbaItem.PriorityId = _ctx.IntegerValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].PriorityId");
					hbaItem.Address = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Address");
					hbaItem.Option = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Option");
					hbaItem.Method = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].Method");
					hbaItem.User = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].BeforeHbaItems["+ j +"].User");

					hbaLogItem_beforeHbaItems.Add(hbaItem);
				}
				hbaLogItem.BeforeHbaItems = hbaLogItem_beforeHbaItems;

				List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem> hbaLogItem_afterHbaItems = new List<DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem>();
				for (int j = 0; j < _ctx.Length("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems.Length"); j++) {
					DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem hbaItem = new DescribeModifyPGHbaConfigLogResponse.DescribeModifyPGHbaConfigLog_HbaLogItem.DescribeModifyPGHbaConfigLog_HbaItem();
					hbaItem.Type = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Type");
					hbaItem.Mask = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Mask");
					hbaItem.Database = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Database");
					hbaItem.PriorityId = _ctx.IntegerValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].PriorityId");
					hbaItem.Address = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Address");
					hbaItem.Option = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Option");
					hbaItem.Method = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].Method");
					hbaItem.User = _ctx.StringValue("DescribeModifyPGHbaConfigLog.HbaLogItems["+ i +"].AfterHbaItems["+ j +"].User");

					hbaLogItem_afterHbaItems.Add(hbaItem);
				}
				hbaLogItem.AfterHbaItems = hbaLogItem_afterHbaItems;

				describeModifyPGHbaConfigLogResponse_hbaLogItems.Add(hbaLogItem);
			}
			describeModifyPGHbaConfigLogResponse.HbaLogItems = describeModifyPGHbaConfigLogResponse_hbaLogItems;
        
			return describeModifyPGHbaConfigLogResponse;
        }
    }
}
