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
    public class DescribeDataLimitSetResponseUnmarshaller
    {
        public static DescribeDataLimitSetResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataLimitSetResponse describeDataLimitSetResponse = new DescribeDataLimitSetResponse();

			describeDataLimitSetResponse.HttpResponse = context.HttpResponse;
			describeDataLimitSetResponse.RequestId = context.StringValue("DescribeDataLimitSet.RequestId");

			DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet dataLimitSet = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet();
			dataLimitSet.ResourceType = context.IntegerValue("DescribeDataLimitSet.DataLimitSet.ResourceType");

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit> dataLimitSet_dataLimitList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit>();
			for (int i = 0; i < context.Length("DescribeDataLimitSet.DataLimitSet.DataLimitList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit dataLimit = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_DataLimit();
				dataLimit.RegionId = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].RegionId");
				dataLimit.LocalName = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].LocalName");
				dataLimit.ParentId = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].ParentId");
				dataLimit.Id = context.LongValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].Id");
				dataLimit.UserName = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].UserName");
				dataLimit.GmtCreate = context.LongValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].GmtCreate");
				dataLimit.Connector = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].Connector");
				dataLimit.CheckStatus = context.IntegerValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].CheckStatus");
				dataLimit.CheckStatusName = context.StringValue("DescribeDataLimitSet.DataLimitSet.DataLimitList["+ i +"].CheckStatusName");

				dataLimitSet_dataLimitList.Add(dataLimit);
			}
			dataLimitSet.DataLimitList = dataLimitSet_dataLimitList;

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket> dataLimitSet_ossBucketList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket>();
			for (int i = 0; i < context.Length("DescribeDataLimitSet.DataLimitSet.OssBucketList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket ossBucket = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_OssBucket();
				ossBucket.BucketName = context.StringValue("DescribeDataLimitSet.DataLimitSet.OssBucketList["+ i +"].BucketName");
				ossBucket.RegionId = context.StringValue("DescribeDataLimitSet.DataLimitSet.OssBucketList["+ i +"].RegionId");

				dataLimitSet_ossBucketList.Add(ossBucket);
			}
			dataLimitSet.OssBucketList = dataLimitSet_ossBucketList;

			List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region> dataLimitSet_regionList = new List<DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region>();
			for (int i = 0; i < context.Length("DescribeDataLimitSet.DataLimitSet.RegionList.Length"); i++) {
				DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region region = new DescribeDataLimitSetResponse.DescribeDataLimitSet_DataLimitSet.DescribeDataLimitSet_Region();
				region.LocalName = context.StringValue("DescribeDataLimitSet.DataLimitSet.RegionList["+ i +"].LocalName");
				region.RegionId = context.StringValue("DescribeDataLimitSet.DataLimitSet.RegionList["+ i +"].RegionId");

				dataLimitSet_regionList.Add(region);
			}
			dataLimitSet.RegionList = dataLimitSet_regionList;
			describeDataLimitSetResponse.DataLimitSet = dataLimitSet;
        
			return describeDataLimitSetResponse;
        }
    }
}
