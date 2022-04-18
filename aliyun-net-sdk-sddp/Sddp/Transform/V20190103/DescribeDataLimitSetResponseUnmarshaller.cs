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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataLimitSetResponseUnmarshaller
    {
        public static DescribeDataLimitSetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataLimitSetResponse describeDataLimitSetResponse = new DescribeDataLimitSetResponse();

			describeDataLimitSetResponse.HttpResponse = _ctx.HttpResponse;
			describeDataLimitSetResponse.RequestId = _ctx.StringValue("DescribeDataLimitSet.RequestId");

			DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet dataLimitSet = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet();
			dataLimitSet.ResourceTypeCode = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.ResourceTypeCode");
			dataLimitSet.ResourceType = _ctx.LongValue("DescribeDataLimitSet.DataLimitSet.ResourceType");
			dataLimitSet.TotalCount = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.TotalCount");

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit> dataLimitSet_dataLimitList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimitSet.DataLimitSet.DataLimitList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit dataLimit = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit();
				dataLimit.SupportEvent = _ctx.BooleanValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].SupportEvent");
				dataLimit.LocalName = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].LocalName");
				dataLimit.CheckStatus = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].CheckStatus");
				dataLimit.Connector = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].Connector");
				dataLimit.Port = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].Port");
				dataLimit.CheckStatusName = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].CheckStatusName");
				dataLimit.RegionId = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].RegionId");
				dataLimit.ParentId = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].ParentId");
				dataLimit.ResourceType = _ctx.LongValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].ResourceType");
				dataLimit.LogStoreDay = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].LogStoreDay");
				dataLimit.EventStatus = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].EventStatus");
				dataLimit.GmtCreate = _ctx.LongValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].GmtCreate");
				dataLimit.ResourceTypeCode = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].ResourceTypeCode");
				dataLimit.UserName = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].UserName");
				dataLimit.Id = _ctx.LongValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].Id");
				dataLimit.AuditStatus = _ctx.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].AuditStatus");

				dataLimitSet_dataLimitList.Add(dataLimit);
			}
			dataLimitSet.DataLimitList = dataLimitSet_dataLimitList;

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket> dataLimitSet_ossBucketList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimitSet.DataLimitSet.OssBucketList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket ossBucket = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket();
				ossBucket.RegionId = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.OssBucketList["+ i +"].RegionId");
				ossBucket.BucketName = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.OssBucketList["+ i +"].BucketName");

				dataLimitSet_ossBucketList.Add(ossBucket);
			}
			dataLimitSet.OssBucketList = dataLimitSet_ossBucketList;

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region> dataLimitSet_regionList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region>();
			for (int i = 0; i < _ctx.Length("DescribeDataLimitSet.DataLimitSet.RegionList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region region = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region();
				region.RegionId = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.RegionList["+ i +"].RegionId");
				region.LocalName = _ctx.StringValue("DescribeDataLimitSet.DataLimitSet.RegionList["+ i +"].LocalName");

				dataLimitSet_regionList.Add(region);
			}
			dataLimitSet.RegionList = dataLimitSet_regionList;
			describeDataLimitSetResponse.DataLimitSet = dataLimitSet;
        
			return describeDataLimitSetResponse;
        }
    }
}
