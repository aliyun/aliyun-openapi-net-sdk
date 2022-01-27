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
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class DescribeHiTSDBInstanceListResponseUnmarshaller
    {
        public static DescribeHiTSDBInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHiTSDBInstanceListResponse describeHiTSDBInstanceListResponse = new DescribeHiTSDBInstanceListResponse();

			describeHiTSDBInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeHiTSDBInstanceListResponse.RequestId = _ctx.StringValue("DescribeHiTSDBInstanceList.RequestId");
			describeHiTSDBInstanceListResponse.PageNumber = _ctx.IntegerValue("DescribeHiTSDBInstanceList.PageNumber");
			describeHiTSDBInstanceListResponse.PageSize = _ctx.IntegerValue("DescribeHiTSDBInstanceList.PageSize");
			describeHiTSDBInstanceListResponse.Total = _ctx.IntegerValue("DescribeHiTSDBInstanceList.Total");

			List<DescribeHiTSDBInstanceListResponse.DescribeHiTSDBInstanceList_Instance> describeHiTSDBInstanceListResponse_instanceList = new List<DescribeHiTSDBInstanceListResponse.DescribeHiTSDBInstanceList_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeHiTSDBInstanceList.InstanceList.Length"); i++) {
				DescribeHiTSDBInstanceListResponse.DescribeHiTSDBInstanceList_Instance instance = new DescribeHiTSDBInstanceListResponse.DescribeHiTSDBInstanceList_Instance();
				instance.InstanceId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceId");
				instance.InstanceAlias = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceAlias");
				instance.InstanceDescription = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceDescription");
				instance.UserId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].UserId");
				instance.RegionId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].RegionId");
				instance.ZoneId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].ZoneId");
				instance.InstanceStatus = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceStatus");
				instance.ChargeType = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].ChargeType");
				instance.NetworkType = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].NetworkType");
				instance.GmtCreated = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].GmtCreated");
				instance.GmtExpire = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].GmtExpire");
				instance.InstanceClass = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceClass");
				instance.InstanceStorage = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceStorage");
				instance.InstanceTps = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].InstanceTps");
				instance.LockMode = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].LockMode");
				instance.EngineType = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].EngineType");
				instance.MaxSeriesPerDatabase = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].MaxSeriesPerDatabase");
				instance.VpcId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].VpcId");
				instance.VswitchId = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].VswitchId");
				instance.Status = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].Status");
				instance.PaymentType = _ctx.StringValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].PaymentType");
				instance.CreateTime = _ctx.LongValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].CreateTime");
				instance.ExpiredTime = _ctx.LongValue("DescribeHiTSDBInstanceList.InstanceList["+ i +"].ExpiredTime");

				describeHiTSDBInstanceListResponse_instanceList.Add(instance);
			}
			describeHiTSDBInstanceListResponse.InstanceList = describeHiTSDBInstanceListResponse_instanceList;
        
			return describeHiTSDBInstanceListResponse;
        }
    }
}
