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
    public class DescribeReadDBInstanceDelayResponseUnmarshaller
    {
        public static DescribeReadDBInstanceDelayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeReadDBInstanceDelayResponse describeReadDBInstanceDelayResponse = new DescribeReadDBInstanceDelayResponse();

			describeReadDBInstanceDelayResponse.HttpResponse = _ctx.HttpResponse;
			describeReadDBInstanceDelayResponse.RequestId = _ctx.StringValue("DescribeReadDBInstanceDelay.RequestId");
			describeReadDBInstanceDelayResponse.DBInstanceId = _ctx.StringValue("DescribeReadDBInstanceDelay.DBInstanceId");
			describeReadDBInstanceDelayResponse.ReadDBInstanceId = _ctx.StringValue("DescribeReadDBInstanceDelay.ReadDBInstanceId");
			describeReadDBInstanceDelayResponse.DelayTime = _ctx.IntegerValue("DescribeReadDBInstanceDelay.DelayTime");

			List<DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem> describeReadDBInstanceDelayResponse_items = new List<DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeReadDBInstanceDelay.Items.Length"); i++) {
				DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem itemsItem = new DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem();
				itemsItem.DBInstanceId = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].DBInstanceId");

				List<string> itemsItem_readDBInstanceNames = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeReadDBInstanceDelay.Items["+ i +"].ReadDBInstanceNames.Length"); j++) {
					itemsItem_readDBInstanceNames.Add(_ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadDBInstanceNames["+ j +"]"));
				}
				itemsItem.ReadDBInstanceNames = itemsItem_readDBInstanceNames;

				List<string> itemsItem_readDelayTimes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeReadDBInstanceDelay.Items["+ i +"].ReadDelayTimes.Length"); j++) {
					itemsItem_readDelayTimes.Add(_ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadDelayTimes["+ j +"]"));
				}
				itemsItem.ReadDelayTimes = itemsItem_readDelayTimes;

				List<DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem.DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem> itemsItem_readonlyInstanceDelay = new List<DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem.DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem>();
				for (int j = 0; j < _ctx.Length("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay.Length"); j++) {
					DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem.DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem readonlyInstanceDelayItem = new DescribeReadDBInstanceDelayResponse.DescribeReadDBInstanceDelay_ItemsItem.DescribeReadDBInstanceDelay_ReadonlyInstanceDelayItem();
					readonlyInstanceDelayItem.ReplayLatency = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].ReplayLatency");
					readonlyInstanceDelayItem.FlushLag = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].FlushLag");
					readonlyInstanceDelayItem.FlushLatency = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].FlushLatency");
					readonlyInstanceDelayItem.SendLatency = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].SendLatency");
					readonlyInstanceDelayItem.WriteLag = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].WriteLag");
					readonlyInstanceDelayItem.ReplayLag = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].ReplayLag");
					readonlyInstanceDelayItem.WriteLatency = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].WriteLatency");
					readonlyInstanceDelayItem.ReadDBInstanceName = _ctx.StringValue("DescribeReadDBInstanceDelay.Items["+ i +"].ReadonlyInstanceDelay["+ j +"].ReadDBInstanceName");

					itemsItem_readonlyInstanceDelay.Add(readonlyInstanceDelayItem);
				}
				itemsItem.ReadonlyInstanceDelay = itemsItem_readonlyInstanceDelay;

				describeReadDBInstanceDelayResponse_items.Add(itemsItem);
			}
			describeReadDBInstanceDelayResponse.Items = describeReadDBInstanceDelayResponse_items;
        
			return describeReadDBInstanceDelayResponse;
        }
    }
}
