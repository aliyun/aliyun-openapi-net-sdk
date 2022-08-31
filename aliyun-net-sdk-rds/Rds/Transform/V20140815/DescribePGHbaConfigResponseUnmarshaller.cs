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
    public class DescribePGHbaConfigResponseUnmarshaller
    {
        public static DescribePGHbaConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePGHbaConfigResponse describePGHbaConfigResponse = new DescribePGHbaConfigResponse();

			describePGHbaConfigResponse.HttpResponse = _ctx.HttpResponse;
			describePGHbaConfigResponse.HbaModifyTime = _ctx.StringValue("DescribePGHbaConfig.HbaModifyTime");
			describePGHbaConfigResponse.ModifyStatusReason = _ctx.StringValue("DescribePGHbaConfig.ModifyStatusReason");
			describePGHbaConfigResponse.RequestId = _ctx.StringValue("DescribePGHbaConfig.RequestId");
			describePGHbaConfigResponse.LastModifyStatus = _ctx.StringValue("DescribePGHbaConfig.LastModifyStatus");
			describePGHbaConfigResponse.DBInstanceId = _ctx.StringValue("DescribePGHbaConfig.DBInstanceId");

			List<DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem> describePGHbaConfigResponse_defaultHbaItems = new List<DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem>();
			for (int i = 0; i < _ctx.Length("DescribePGHbaConfig.DefaultHbaItems.Length"); i++) {
				DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem hbaItem = new DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem();
				hbaItem.Type = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Type");
				hbaItem.Mask = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Mask");
				hbaItem.Database = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Database");
				hbaItem.PriorityId = _ctx.IntegerValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].PriorityId");
				hbaItem.Address = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Address");
				hbaItem.Option = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Option");
				hbaItem.Method = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].Method");
				hbaItem.User = _ctx.StringValue("DescribePGHbaConfig.DefaultHbaItems["+ i +"].User");

				describePGHbaConfigResponse_defaultHbaItems.Add(hbaItem);
			}
			describePGHbaConfigResponse.DefaultHbaItems = describePGHbaConfigResponse_defaultHbaItems;

			List<DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem> describePGHbaConfigResponse_runningHbaItems = new List<DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem>();
			for (int i = 0; i < _ctx.Length("DescribePGHbaConfig.RunningHbaItems.Length"); i++) {
				DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem hbaItem = new DescribePGHbaConfigResponse.DescribePGHbaConfig_HbaItem();
				hbaItem.Type = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Type");
				hbaItem.Mask = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Mask");
				hbaItem.Database = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Database");
				hbaItem.PriorityId = _ctx.IntegerValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].PriorityId");
				hbaItem.Address = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Address");
				hbaItem.Option = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Option");
				hbaItem.Method = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].Method");
				hbaItem.User = _ctx.StringValue("DescribePGHbaConfig.RunningHbaItems["+ i +"].User");

				describePGHbaConfigResponse_runningHbaItems.Add(hbaItem);
			}
			describePGHbaConfigResponse.RunningHbaItems = describePGHbaConfigResponse_runningHbaItems;
        
			return describePGHbaConfigResponse;
        }
    }
}
